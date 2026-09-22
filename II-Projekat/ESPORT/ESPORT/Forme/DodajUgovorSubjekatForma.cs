using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class DodajUgovorSubjekatForma : Form
    {
        private readonly int ugovorId;
        private readonly string nazivUgovoraZaPrikaz;

        // Forma se otvara za VEĆ IZABRANI sponzorski ugovor (iz liste u roditeljskoj formi),
        // pa nema potrebe da učitavamo sve sponzorske ugovore iz baze.
        public DodajUgovorSubjekatForma(int ugovorId, string nazivUgovoraZaPrikaz)
        {
            InitializeComponent();
            this.ugovorId = ugovorId;
            this.nazivUgovoraZaPrikaz = nazivUgovoraZaPrikaz;
        }

        private void DodajUgovorSubjekatForma_Load(object sender, EventArgs e)
        {
            // Combo sa samo jednom stavkom - već izabranim ugovorom - da se ne bi menjao,
            // a da ostatak koda (SelectedValue) ostane isti kao pre
            List<SponzorDTO.SponzorskiUgovorBasic> samoOvajUgovor =
                new List<SponzorDTO.SponzorskiUgovorBasic>
                {
                    new SponzorDTO.SponzorskiUgovorBasic { UgovorId = ugovorId, NazivSponzora = nazivUgovoraZaPrikaz }
                };

            cmbUgovor.DataSource = samoOvajUgovor;
            cmbUgovor.DisplayMember = "NazivSponzora";
            cmbUgovor.ValueMember = "UgovorId";
            cmbUgovor.SelectedIndex = 0;
            cmbUgovor.Enabled = false;

            // Popunjavanje tipova subjekata
            cmbTipSubjekta.Items.Clear();
            cmbTipSubjekta.Items.Add("Igrač");
            cmbTipSubjekta.Items.Add("Tim");
            cmbTipSubjekta.Items.Add("Takmičenje");
            cmbTipSubjekta.SelectedIndex = 0;
        }

        private void cmbTipSubjekta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKonkretanSubjekat.DataSource = null;
            cmbKonkretanSubjekat.Items.Clear();

            string izabraniTip = cmbTipSubjekta.SelectedItem.ToString();

            if (izabraniTip == "Igrač")
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
            else if (izabraniTip == "Tim")
            {
                List<TimDTO.TimPregled> timovi = DTOManager.vratiSveTimove();
                cmbKonkretanSubjekat.DataSource = timovi;
                cmbKonkretanSubjekat.DisplayMember = "Naziv";
                cmbKonkretanSubjekat.ValueMember = "TimId";
            }
            else if (izabraniTip == "Takmičenje")
            {
                List<TakmicenjeDTO.TakmicenjePregled> takmicenja = DTOManager.vratiSvaTakmicenja();
                cmbKonkretanSubjekat.DataSource = takmicenja;
                cmbKonkretanSubjekat.DisplayMember = "Naziv";
                cmbKonkretanSubjekat.ValueMember = "TakmicenjeId";
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (cmbUgovor.SelectedValue == null || cmbKonkretanSubjekat.SelectedValue == null)
            {
                MessageBox.Show("Molimo izaberite ugovor i subjekat.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Uspešno sačuvan subjekat ugovora!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
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