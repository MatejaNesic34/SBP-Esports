using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.DogadjajNaMecuDTO;

namespace ESPORT.Forme
{
    public partial class IzmeniDogadjajForma : Form
    {
        private DogadjajNaMecuBasic dogadjaj;

        public IzmeniDogadjajForma(DogadjajNaMecuBasic d)
        {
            InitializeComponent();

            dogadjaj = d;
        }

        private void IzmeniDogadjajForma_Load(object sender, EventArgs e)
        {
            popuniMeceve();
            popuniTipoveDogadjaja();

            dtpVremeDogadjaja.Value = dogadjaj.VremeDogadjaja;
            txtOpis.Text = dogadjaj.Opis;
            txtOdlukaSudije.Text = dogadjaj.OdlukaSudije;

            for (int i = 0; i < cmbMec.Items.Count; i++)
            {
                MecDTO.MecPregled m =
                    (MecDTO.MecPregled)cmbMec.Items[i];

                if (m.MecId == dogadjaj.MecId)
                {
                    cmbMec.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbTipDogadjaja.Items.Count; i++)
            {
                if (cmbTipDogadjaja.Items[i].ToString() == dogadjaj.TipDogadjaja)
                {
                    cmbTipDogadjaja.SelectedIndex = i;
                    break;
                }
            }
        }

        private void popuniMeceve()
        {
            cmbMec.Items.Clear();

            List<MecDTO.MecPregled> mecevi =
                DTOManager.vratiSveMeceve();

            foreach (MecDTO.MecPregled m in mecevi)
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

        private void izmeniBtn_Click(object sender, EventArgs e)
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

            if (cmbTipDogadjaja.SelectedItem == null)
            {
                MessageBox.Show(
                    "Molimo vas da izaberete tip događaja!",
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

            MecDTO.MecPregled izabraniMec =
                (MecDTO.MecPregled)cmbMec.SelectedItem;

            DogadjajNaMecuBasic izmenjeniDogadjaj =
                new DogadjajNaMecuBasic(
                    dogadjaj.DogadjajId,
                    izabraniMec.MecId,
                    cmbTipDogadjaja.SelectedItem.ToString(),
                    dtpVremeDogadjaja.Value,
                    txtOpis.Text,
                    txtOdlukaSudije.Text);

            if (DTOManager.azurirajDogadjajNaMecu(izmenjeniDogadjaj))
            {
                MessageBox.Show(
                    "Događaj je uspešno izmenjen!",
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