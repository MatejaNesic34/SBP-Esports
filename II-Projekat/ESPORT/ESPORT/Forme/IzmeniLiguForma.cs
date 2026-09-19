using System;
using System.Windows.Forms;
using static ESPORT.LigaDTO;

namespace ESPORT.Forme
{
    public partial class IzmeniLiguForma : Form
    {
        private LigaBasic liga;

        public IzmeniLiguForma(LigaBasic liga)
        {
            InitializeComponent();

            this.liga = liga;

            popuniPodacima();
        }

        private void popuniPodacima()
        {
            txtTakmicenjeId.Text = liga.TakmicenjeId.ToString();
            txtSistemBodovanja.Text = liga.SistemBodovanja;
        }

        private void izmeniLiguBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTakmicenjeId.Text, out int takmicenjeId))
            {
                MessageBox.Show(
                    "Takmičenje ID mora biti broj!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtSistemBodovanja.Text))
            {
                MessageBox.Show(
                    "Unesite sistem bodovanja!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            liga.TakmicenjeId = takmicenjeId;
            liga.SistemBodovanja = txtSistemBodovanja.Text;

            DTOManager.azurirajLigu(liga);

            if (DTOManager.azurirajLigu(liga))
            {
                MessageBox.Show(
                    "Liga je uspešno izmenjena!",
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