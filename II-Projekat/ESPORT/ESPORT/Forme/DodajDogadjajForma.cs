using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.MecDTO;
using static ESPORT.DogadjajNaMecuDTO;

namespace ESPORT.Forme
{
    public partial class DodajDogadjajForma : Form
    {
        public DodajDogadjajForma()
        {
            InitializeComponent();
        }

        private void DodajDogadjajForma_Load(object sender, EventArgs e)
        {
            popuniMeceve();
            popuniTipoveDogadjaja();
        }

        private void popuniMeceve()
        {
            cmbMec.Items.Clear();

            List<MecPregled> mecevi =
                DTOManager.vratiSveMeceve();

            foreach (MecPregled m in mecevi)
            {
                cmbMec.Items.Add(m);
            }

            cmbMec.DisplayMember = "Prikaz";

            if (cmbMec.Items.Count > 0)
                cmbMec.SelectedIndex = 0;
        }

        private void popuniTipoveDogadjaja()
        {
            cmbTipDogadjaja.Items.Clear();

            cmbTipDogadjaja.Items.Add("Tehnički problem");
            cmbTipDogadjaja.Items.Add("Pauza");
            cmbTipDogadjaja.Items.Add("Žalba");
            cmbTipDogadjaja.Items.Add("Odluka sudije");

            if (cmbTipDogadjaja.Items.Count > 0)
                cmbTipDogadjaja.SelectedIndex = 0;
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (cmbMec.SelectedItem == null)
            {
                MessageBox.Show(
                    "Molimo vas da izaberete meč!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            MecPregled izabraniMec =
                (MecPregled)cmbMec.SelectedItem;

            if (cmbTipDogadjaja.SelectedItem == null)
            {
                MessageBox.Show(
                    "Molimo vas da unesete tip događaja!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtOpis.Text))
            {
                MessageBox.Show(
                    "Molimo vas da unesete opis događaja!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DogadjajNaMecuBasic noviDogadjaj =
                new DogadjajNaMecuBasic(
                    0,
                    izabraniMec.MecId,
                    cmbTipDogadjaja.SelectedItem.ToString(),
                    dtpVremeDogadjaja.Value,
                    txtOpis.Text,
                    txtOdlukaSudije.Text);

            if (DTOManager.dodajDogadjajNaMecu(noviDogadjaj))
            {
                MessageBox.Show(
                    "Događaj je uspešno dodat!",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}