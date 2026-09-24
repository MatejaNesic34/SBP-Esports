using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.TakmicenjeDTO;

namespace ESPORT.Forme
{
    public partial class DodajTakmicenjeForma : Form
    {
        TakmicenjeBasic takmicenje;

        public DodajTakmicenjeForma()
        {
            InitializeComponent();

            takmicenje = new TakmicenjeBasic();

            popuniIgre();
        }

        private void popuniIgre()
        {
            List<IgraDTO.IgraPregled> igre =
                DTOManager.vratiSveIgre();

            foreach (IgraDTO.IgraPregled igra in igre)
            {
                cmbIgra.Items.Add(igra);
            }

            cmbIgra.DisplayMember = "Naziv";
            cmbIgra.ValueMember = "IgraId";

            if (cmbIgra.Items.Count > 0)
                cmbIgra.SelectedIndex = 0;
        }

        private void dodajTakmicenjeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show(
                    "Unesite naziv takmičenja.",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtOrganizator.Text))
            {
                MessageBox.Show(
                    "Unesite organizatora.",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cmbIgra.SelectedItem == null)
            {
                MessageBox.Show(
                    "Izaberite igru.",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            if (cmbTipTakmicenja.SelectedItem == null && string.IsNullOrWhiteSpace(cmbTipTakmicenja.Text))
            {
                MessageBox.Show(
                    "Izaberite ili unesite tip takmičenja.",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (dtpDatumZavrsetka.Value < dtpDatumPocetka.Value)
            {
                MessageBox.Show(
                    "Datum završetka ne može biti pre datuma početka.",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!decimal.TryParse(
                txtNagradniFond.Text,
                out decimal nagradniFond))
            {
                MessageBox.Show(
                    "Nagradni fond mora biti broj.",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cmbStatus.SelectedItem == null && string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                MessageBox.Show(
                    "Izaberite ili unesite status takmičenja.",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            IgraDTO.IgraPregled izabranaIgra =
                (IgraDTO.IgraPregled)cmbIgra.SelectedItem;

            this.takmicenje.Naziv = txtNaziv.Text;
            this.takmicenje.Organizator = txtOrganizator.Text;
            this.takmicenje.TipTakmicenja = cmbTipTakmicenja.SelectedItem?.ToString() ?? cmbTipTakmicenja.Text.Trim();
            this.takmicenje.IgraId = izabranaIgra.IgraId;
            this.takmicenje.Region = txtRegion.Text;
            this.takmicenje.Lokacija = txtLokacija.Text;
            this.takmicenje.FormatTakmicenja = txtFormatTakmicenja.Text;
            this.takmicenje.DatumPocetka = dtpDatumPocetka.Value;
            this.takmicenje.DatumZavrsetka = dtpDatumZavrsetka.Value;
            this.takmicenje.NagradniFond = nagradniFond;
            this.takmicenje.ValutaNagrade = txtValutaNagrade.Text;
            this.takmicenje.Status =cmbStatus.SelectedItem?.ToString() ?? cmbStatus.Text.Trim();

            if (DTOManager.dodajTakmicenje(this.takmicenje))
            {
                MessageBox.Show(
                    "Takmičenje je uspešno dodato!",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}