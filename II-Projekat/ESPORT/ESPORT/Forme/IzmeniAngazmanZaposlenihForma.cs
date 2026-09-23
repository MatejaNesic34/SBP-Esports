using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static ESPORT.IgracDTO;
using static ESPORT.OsobaDTO;

namespace ESPORT.Forme
{
    public partial class IzmeniAngazmanZaposlenihForma : Form
    {
        private int angazmanId;

        public IzmeniAngazmanZaposlenihForma(int id)
        {
            InitializeComponent();

            angazmanId = id;
        }

        private void IzmeniAngazmanZaposlenihForma_Load(object sender, EventArgs e)
        {
            popuniOsobe();
            popuniTimove();
            popuniUloge();

            ucitajPodatke();
        }

        private void popuniOsobe()
        {
            cmbOsoba.Items.Clear();

            List<OsobaPregled> osobe =
                DTOManager.vratiSveOsobe();

            List<IgracPregled> igraci =
                DTOManager.vratiSveIgrace();

            List<TrenerDTO.TrenerPregled> treneri =
                DTOManager.vratiSveTrenere();

            HashSet<int> igracIds = igraci
                .Select(i => i.OsobaId)
                .ToHashSet();

            HashSet<int> trenerIds = treneri
                .Select(t => t.OsobaId)
                .ToHashSet();

            foreach (OsobaPregled o in osobe)
            {
                if (igracIds.Contains(o.OsobaId) ||
                    trenerIds.Contains(o.OsobaId))
                {
                    continue;
                }

                cmbOsoba.Items.Add(
                    new ComboBoxItem(
                        o.OsobaId,
                        o.Ime + " " + o.Prezime));
            }
        }

        private void popuniTimove()
        {
            cmbTim.Items.Clear();

            List<TimDTO.TimPregled> timovi =
                DTOManager.vratiSveTimove();

            foreach (TimDTO.TimPregled t in timovi)
            {
                cmbTim.Items.Add(
                    new ComboBoxItem(
                        t.TimId,
                        t.Naziv));
            }
        }

        private void popuniUloge()
        {
            cmbNazivUloge.Items.Clear();

            cmbNazivUloge.Items.Add("Analiticar");
            cmbNazivUloge.Items.Add("Menadzer");
            cmbNazivUloge.Items.Add("Psiholog");
            cmbNazivUloge.Items.Add("Fizioterapeut");
            cmbNazivUloge.Items.Add("Skaut");
            cmbNazivUloge.Items.Add("Kreator sadrzaja");
        }

        private void ucitajPodatke()
        {
            AngazmanZaposlenihDTO.AngazmanZaposlenihBasic a =
                DTOManager.vratiAngazmanZaposlenih(angazmanId);

            if (a == null)
            {
                MessageBox.Show(
                    "Angažman zaposlenog nije pronađen.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();
                return;
            }

            // Osoba
            for (int i = 0; i < cmbOsoba.Items.Count; i++)
            {
                ComboBoxItem item =
                    (ComboBoxItem)cmbOsoba.Items[i];

                if (item.Id == a.OsobaId)
                {
                    cmbOsoba.SelectedIndex = i;
                    break;
                }
            }

            // Tim
            for (int i = 0; i < cmbTim.Items.Count; i++)
            {
                ComboBoxItem item =
                    (ComboBoxItem)cmbTim.Items[i];

                if (item.Id == a.TimId)
                {
                    cmbTim.SelectedIndex = i;
                    break;
                }
            }

            // Uloga
            for (int i = 0; i < cmbNazivUloge.Items.Count; i++)
            {
                if (cmbNazivUloge.Items[i].ToString() == a.NazivUloge)
                {
                    cmbNazivUloge.SelectedIndex = i;
                    break;
                }
            }

            // Datum od
            dtpDatumOd.Value = a.DatumOd;

            // Datum do
            if (a.DatumDo.HasValue)
            {
                chkDatumDo.Checked = true;
                dtpDatumDo.Enabled = true;
                dtpDatumDo.Value = a.DatumDo.Value;
            }
            else
            {
                chkDatumDo.Checked = false;
                dtpDatumDo.Enabled = false;
            }

            // Plata
            if (a.Plata.HasValue)
                txtPlata.Text = a.Plata.Value.ToString("0.00");
            else
                txtPlata.Text = "";
        }

        private void chkDatumDo_CheckedChanged(object sender, EventArgs e)
        {
            dtpDatumDo.Enabled = chkDatumDo.Checked;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (cmbOsoba.SelectedItem == null)
            {
                MessageBox.Show("Izaberite osobu.");
                return;
            }

            if (cmbTim.SelectedItem == null)
            {
                MessageBox.Show("Izaberite tim.");
                return;
            }

            if (cmbNazivUloge.SelectedItem == null)
            {
                MessageBox.Show("Izaberite naziv uloge.");
                return;
            }

            decimal? plata = null;

            if (!string.IsNullOrWhiteSpace(txtPlata.Text))
            {
                if (!decimal.TryParse(
                        txtPlata.Text,
                        out decimal plataVrednost))
                {
                    MessageBox.Show("Plata mora biti broj.");
                    return;
                }

                if (plataVrednost < 0)
                {
                    MessageBox.Show("Plata ne može biti negativna.");
                    return;
                }

                plata = plataVrednost;
            }

            DateTime? datumDo = null;

            if (chkDatumDo.Checked)
            {
                if (dtpDatumDo.Value.Date < dtpDatumOd.Value.Date)
                {
                    MessageBox.Show(
                        "Datum do ne može biti pre datuma od.");
                    return;
                }

                datumDo = dtpDatumDo.Value.Date;
            }

            ComboBoxItem osoba =
                (ComboBoxItem)cmbOsoba.SelectedItem;

            ComboBoxItem tim =
                (ComboBoxItem)cmbTim.SelectedItem;

            string nazivUloge =
                cmbNazivUloge.SelectedItem.ToString();

            AngazmanZaposlenihDTO.AngazmanZaposlenihBasic podaci =
                new AngazmanZaposlenihDTO.AngazmanZaposlenihBasic(
                    angazmanId,
                    osoba.Id,
                    tim.Id,
                    nazivUloge,
                    dtpDatumOd.Value.Date,
                    datumDo,
                    plata
                );

            bool uspesno =
                DTOManager.azurirajAngazmanZaposlenih(podaci);

            if (uspesno)
            {
                MessageBox.Show(
                    "Angažman zaposlenog je uspešno izmenjen.",
                    "Uspeh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}