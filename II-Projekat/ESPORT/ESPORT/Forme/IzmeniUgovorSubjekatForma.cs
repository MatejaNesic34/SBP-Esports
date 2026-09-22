using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class IzmeniUgovorSubjekatForma : Form
    {
        private readonly int _idUgovora;
        private readonly string _nazivUgovoraZaPrikaz;

        // Forma se otvara za VEĆ IZABRANI sponzorski ugovor (iz liste u roditeljskoj formi),
        // pa nema potrebe da učitavamo sve sponzorske ugovore iz baze.
        public IzmeniUgovorSubjekatForma(int idUgovora, string nazivUgovoraZaPrikaz)
        {
            InitializeComponent();
            _idUgovora = idUgovora;
            _nazivUgovoraZaPrikaz = nazivUgovoraZaPrikaz;
        }

        private void IzmeniUgovorSubjekatForma_Load(object sender, EventArgs e)
        {
            // Combo sa samo jednom stavkom - već izabranim ugovorom - da se ne bi menjao,
            // a da ostatak koda (SelectedValue) ostane isti kao pre
            List<SponzorDTO.SponzorskiUgovorBasic> samoOvajUgovor =
                new List<SponzorDTO.SponzorskiUgovorBasic>
                {
                    new SponzorDTO.SponzorskiUgovorBasic { UgovorId = _idUgovora, NazivSponzora = _nazivUgovoraZaPrikaz }
                };

            cmbUgovor.DataSource = samoOvajUgovor;
            cmbUgovor.DisplayMember = "NazivSponzora";
            cmbUgovor.ValueMember = "UgovorId";
            cmbUgovor.SelectedIndex = 0;
            cmbUgovor.Enabled = false;

            // Učitavanje tipova
            cmbTipSubjekta.Items.Clear();
            cmbTipSubjekta.Items.Add("Igrač");
            cmbTipSubjekta.Items.Add("Tim");
            cmbTipSubjekta.Items.Add("Takmičenje");

            // Učitavanje podataka o postojećem zapisu koji se menja
            // (kod UgovorSubjekat je UgovorId ujedno i njegov PK, isti kao id sponzorskog ugovora)
            UgovorDTO.UgovorSubjekatBasic postojeciZapis = DTOManager.vratiUgovorSubjekat(_idUgovora);

            if (postojeciZapis != null)
            {
                cmbUgovor.SelectedValue = postojeciZapis.UgovorId;

                string tipSubjekta =
                    postojeciZapis.IgracId.HasValue ? "Igrač" :
                    postojeciZapis.TimId.HasValue ? "Tim" :
                    postojeciZapis.TakmicenjeId.HasValue ? "Takmičenje" : null;

                if (tipSubjekta != null)
                {
                    cmbTipSubjekta.SelectedItem = tipSubjekta;

                    // Osvežavanje subjekata za taj tip i selektovanje konkretnog
                    UcitajSubjekteZaTip(tipSubjekta);

                    int idSubjekta =
                        postojeciZapis.IgracId ?? postojeciZapis.TimId ?? postojeciZapis.TakmicenjeId ?? 0;
                    cmbKonkretanSubjekat.SelectedValue = idSubjekta;
                }
            }
        }

        private void cmbTipSubjekta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipSubjekta.SelectedItem != null)
            {
                UcitajSubjekteZaTip(cmbTipSubjekta.SelectedItem.ToString());
            }
        }

        private void UcitajSubjekteZaTip(string tip)
        {
            cmbKonkretanSubjekat.DataSource = null;
            cmbKonkretanSubjekat.Items.Clear();

            if (tip == "Igrač")
            {
                // IgracDTO.IgracPregled nema jedno polje za prikaz (ima Ime/Prezime/Nadimak
                // odvojeno), pa ih ovde spajamo u anonimni tip samo za potrebe ComboBox-a
                var igraci = DTOManager.vratiSveIgrace()
                    .Select(i => new
                    {
                        i.OsobaId,
                        Prikaz = $"{i.Ime} {i.Prezime} ({i.Nadimak})"
                    })
                    .ToList();

                cmbKonkretanSubjekat.DataSource = igraci;
                cmbKonkretanSubjekat.DisplayMember = "Prikaz";
                cmbKonkretanSubjekat.ValueMember = "OsobaId";
            }
            else if (tip == "Tim")
            {
                List<TimDTO.TimPregled> timovi = DTOManager.vratiSveTimove();
                cmbKonkretanSubjekat.DataSource = timovi;
                cmbKonkretanSubjekat.DisplayMember = "Naziv";
                cmbKonkretanSubjekat.ValueMember = "TimId";
            }
            else if (tip == "Takmičenje")
            {
                List<TakmicenjeDTO.TakmicenjePregled> takmicenja = DTOManager.vratiSvaTakmicenja();
                cmbKonkretanSubjekat.DataSource = takmicenja;
                cmbKonkretanSubjekat.DisplayMember = "Naziv";
                cmbKonkretanSubjekat.ValueMember = "TakmicenjeId";
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (cmbUgovor.SelectedValue == null || cmbKonkretanSubjekat.SelectedValue == null)
            {
                MessageBox.Show("Molimo popunite sva polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idUgovora = (int)cmbUgovor.SelectedValue;
            string tipSubjekta = cmbTipSubjekta.SelectedItem.ToString();
            int idSubjekta = (int)cmbKonkretanSubjekat.SelectedValue;

            UgovorDTO.UgovorSubjekatBasic subjekat = new UgovorDTO.UgovorSubjekatBasic
            {
                UgovorId = idUgovora,
                TimId = tipSubjekta == "Tim" ? idSubjekta : (int?)null,
                IgracId = tipSubjekta == "Igrač" ? idSubjekta : (int?)null,
                TakmicenjeId = tipSubjekta == "Takmičenje" ? idSubjekta : (int?)null
            };

            if (DTOManager.sacuvajUgovorSubjekat(subjekat))
            {
                MessageBox.Show("Uspešno izmenjen zapis ugovora subjekta!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}