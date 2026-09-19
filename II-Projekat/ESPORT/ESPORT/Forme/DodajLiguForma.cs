using System;
using System.Windows.Forms;
using static ESPORT.LigaDTO;

namespace ESPORT.Forme
{
    public partial class DodajLiguForma : Form
    {
        private LigaBasic liga;

        public DodajLiguForma()
        {
            InitializeComponent();

            liga = new LigaBasic();
        }

        private void dodajLiguBtn_Click(object sender, EventArgs e)
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

            bool uspesno = DTOManager.dodajLigu(liga);

            if (uspesno)
            {
                MessageBox.Show(
                    "Liga je uspešno dodata!",
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