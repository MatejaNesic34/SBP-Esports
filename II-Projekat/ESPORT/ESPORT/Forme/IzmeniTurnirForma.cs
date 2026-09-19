using System;
using System.Windows.Forms;
using static ESPORT.TurnirDTO;

namespace ESPORT.Forme
{
    public partial class IzmeniTurnirForma : Form
    {
        private TurnirBasic turnir;

        public IzmeniTurnirForma(TurnirBasic turnir)
        {
            InitializeComponent();

            this.turnir = turnir;

            popuniPodacima();
        }

        private void popuniPodacima()
        {
            txtTakmicenjeId.Text =
                turnir.TakmicenjeId.ToString();

            txtTipKostura.Text =
                turnir.TipKostura;

            txtPravilaNapredovanja.Text =
                turnir.PravilaNapredovanja;

            txtBrojMecevaPoRundi.Text =
                turnir.BrojMecevaPoRundi;
        }

        private void izmeniTurnirBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTipKostura.Text))
            {
                MessageBox.Show(
                    "Unesite tip kostura!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            turnir.TipKostura =
                txtTipKostura.Text;

            turnir.PravilaNapredovanja =
                txtPravilaNapredovanja.Text;

            turnir.BrojMecevaPoRundi =
                txtBrojMecevaPoRundi.Text;

            if (DTOManager.azurirajTurnir(turnir))
            {
                MessageBox.Show(
                    "Turnir je uspešno izmenjen!",
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