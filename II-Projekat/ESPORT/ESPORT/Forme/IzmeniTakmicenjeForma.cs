using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.TakmicenjeDTO;

namespace ESPORT.Forme
{
    public partial class IzmeniTakmicenjeForma : Form
    {
        private TakmicenjeBasic takmicenje;

        public IzmeniTakmicenjeForma()
        {
            InitializeComponent();
        }

        public IzmeniTakmicenjeForma(TakmicenjeBasic takmicenje)
        {
            InitializeComponent();

            this.takmicenje = takmicenje;

            popuniIgre();
        }

        private void IzmeniTakmicenjeForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();

            this.Text =
                $"IZMENA TAKMICENJA {takmicenje.Naziv.ToUpper()}";
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
        }

        public void popuniPodacima()
        {
            txtNaziv.Text = this.takmicenje.Naziv;
            txtOrganizator.Text = this.takmicenje.Organizator;
            txtTipTakmicenja.Text = this.takmicenje.TipTakmicenja;
            txtRegion.Text = this.takmicenje.Region;
            txtLokacija.Text = this.takmicenje.Lokacija;
            txtFormatTakmicenja.Text = this.takmicenje.FormatTakmicenja;

            dtpDatumPocetka.Value = this.takmicenje.DatumPocetka;
            dtpDatumZavrsetka.Value = this.takmicenje.DatumZavrsetka;

            txtNagradniFond.Text =
                this.takmicenje.NagradniFond.ToString();

            txtValutaNagrade.Text =
                this.takmicenje.ValutaNagrade;

            txtStatus.Text =
                this.takmicenje.Status;

            for (int i = 0; i < cmbIgra.Items.Count; i++)
            {
                IgraDTO.IgraPregled igra =
                    (IgraDTO.IgraPregled)cmbIgra.Items[i];

                if (igra.IgraId == this.takmicenje.IgraId)
                {
                    cmbIgra.SelectedIndex = i;
                    break;
                }
            }
        }

        private void izmeniTakmicenjeBtn_Click(object sender, EventArgs e)
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

            IgraDTO.IgraPregled izabranaIgra =
                (IgraDTO.IgraPregled)cmbIgra.SelectedItem;

            this.takmicenje.Naziv = txtNaziv.Text;
            this.takmicenje.Organizator = txtOrganizator.Text;
            this.takmicenje.TipTakmicenja = txtTipTakmicenja.Text;
            this.takmicenje.IgraId = izabranaIgra.IgraId;
            this.takmicenje.Region = txtRegion.Text;
            this.takmicenje.Lokacija = txtLokacija.Text;
            this.takmicenje.FormatTakmicenja = txtFormatTakmicenja.Text;
            this.takmicenje.DatumPocetka = dtpDatumPocetka.Value;
            this.takmicenje.DatumZavrsetka = dtpDatumZavrsetka.Value;
            this.takmicenje.NagradniFond = nagradniFond;
            this.takmicenje.ValutaNagrade = txtValutaNagrade.Text;
            this.takmicenje.Status = txtStatus.Text;

            if (DTOManager.azurirajTakmicenje(this.takmicenje))
            {
                MessageBox.Show(
                    "Takmičenje je uspešno izmenjeno!",
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