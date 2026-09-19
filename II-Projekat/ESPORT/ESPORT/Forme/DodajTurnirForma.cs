using System;
using System.Windows.Forms;
using static ESPORT.TurnirDTO;

namespace ESPORT.Forme
{
    public partial class DodajTurnirForma : Form
    {
        private TurnirBasic turnir;

        public DodajTurnirForma()
        {
            InitializeComponent();

            turnir = new TurnirBasic();
        }

        private void dodajTurnirBtn_Click(object sender, EventArgs e)
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

            if (string.IsNullOrWhiteSpace(txtTipKostura.Text))
            {
                MessageBox.Show(
                    "Unesite tip kostura!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            turnir.TakmicenjeId = takmicenjeId;
            turnir.TipKostura = txtTipKostura.Text;
            turnir.PravilaNapredovanja = txtPravilaNapredovanja.Text;
            turnir.BrojMecevaPoRundi = txtBrojMecevaPoRundi.Text;

            bool uspesno = DTOManager.dodajTurnir(turnir);

            if (uspesno)
            {
                MessageBox.Show(
                    "Turnir je uspešno dodat!",
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