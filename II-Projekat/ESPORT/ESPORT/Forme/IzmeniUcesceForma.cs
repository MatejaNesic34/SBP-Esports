using System;
using System.Windows.Forms;
using static ESPORT.UcesceTimaUFaziDTO;

namespace ESPORT.Forme
{
    public partial class IzmeniUcesceForma : Form
    {
        private UcesceBasic ucesce;

        public IzmeniUcesceForma(UcesceBasic ucesce)
        {
            InitializeComponent();

            this.ucesce = ucesce;

            popuniPodacima();
        }

        private void popuniPodacima()
        {
            txtFaza.Text =
                ucesce.FazaId.ToString();

            txtTim.Text =
                ucesce.TimId.ToString();

            if (!string.IsNullOrEmpty(ucesce.Status))
            {
                cmbStatus.Text = ucesce.Status;
            }


            txtRezultat.Text =
                ucesce.OstvareniRezultat;

            txtPobede.Text =
                ucesce.BrojPobeda.ToString();

            txtPorazi.Text =
                ucesce.BrojPoraza.ToString();

            txtBodovi.Text =
                ucesce.OsvojeniBodovi.ToString();

            txtPlasman.Text =
                ucesce.KonacanPlasman.HasValue
                    ? ucesce.KonacanPlasman.Value.ToString()
                    : "";
        }

        private void izmeniUcesceBtn_Click(
            object sender,
            EventArgs e)
        {
            if (!int.TryParse(
                txtPobede.Text,
                out int pobede) ||
                pobede < 0)
            {
                MessageBox.Show(
                    "Broj pobeda mora biti ceo broj veći ili jednak nuli!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cmbStatus.SelectedItem == null && string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                MessageBox.Show(
                    "Izaberite ili unesite status!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!int.TryParse(
                txtPorazi.Text,
                out int porazi) ||
                porazi < 0)
            {
                MessageBox.Show(
                    "Broj poraza mora biti ceo broj veći ili jednak nuli!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!int.TryParse(
                txtBodovi.Text,
                out int bodovi) ||
                bodovi < 0)
            {
                MessageBox.Show(
                    "Broj bodova mora biti ceo broj veći ili jednak nuli!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int? plasman = null;

            if (!string.IsNullOrWhiteSpace(txtPlasman.Text))
            {
                if (!int.TryParse(
                    txtPlasman.Text,
                    out int plasmanVrednost) ||
                    plasmanVrednost <= 0)
                {
                    MessageBox.Show(
                        "Konačan plasman mora biti pozitivan ceo broj!",
                        "Upozorenje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                plasman = plasmanVrednost;
            }

            ucesce.Status =
                cmbStatus.SelectedItem?.ToString() ?? cmbStatus.Text.Trim();

            ucesce.OstvareniRezultat =
                txtRezultat.Text;

            ucesce.BrojPobeda =
                pobede;

            ucesce.BrojPoraza =
                porazi;

            ucesce.OsvojeniBodovi =
                bodovi;

            ucesce.KonacanPlasman =
                plasman;

            bool uspesno =
                DTOManager.azurirajUcesce(ucesce);

            if (uspesno)
            {
                MessageBox.Show(
                    "Učešće je uspešno izmenjeno!",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void odustaniBtn_Click(
            object sender,
            EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}