using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class IzmeniPsihologaForma : Form
    {
        private PsihologBasic psiholog;

        public IzmeniPsihologaForma()
        {
            InitializeComponent();
        }

        public IzmeniPsihologaForma(PsihologBasic p)
        {
            InitializeComponent();
            this.psiholog = p;
            popuniPoljaPodacima();
        }

        private void popuniPoljaPodacima()
        {
            if (psiholog == null) return;

            textBoxIme.Text = psiholog.Ime ?? "";
            textBoxPrezime.Text = psiholog.Prezime ?? "";
            dtpdatum.Value = psiholog.DatumRodjenja ?? DateTime.Now;
            textBoxdrzava.Text = psiholog.Drzava ?? "";
            textBoxemail.Text = psiholog.Email ?? "";
            comboBoxstatusaranzmana.SelectedItem = psiholog.StatusAngazmana;

            // Specifična polja za Psihologa
            textBoxoblastrada.Text = psiholog.OblastRada ?? "";
            textBoxperioddostupnosti.Text = psiholog.PeriodiDostupnosti ?? "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIme.Text) || string.IsNullOrWhiteSpace(textBoxPrezime.Text))
            {
                MessageBox.Show("Ime i prezime su obavezni!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Da li ste sigurni da želite da sačuvate izmene za psihologa '{psiholog.Ime} {psiholog.Prezime}'?",
                                                  "Potvrda izmene",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                psiholog.Ime = textBoxIme.Text.Trim();
                psiholog.Prezime = textBoxPrezime.Text.Trim();
                psiholog.DatumRodjenja = dtpdatum.Value;
                psiholog.Drzava = textBoxdrzava.Text.Trim();
                psiholog.Email = textBoxemail.Text.Trim();
                psiholog.StatusAngazmana = comboBoxstatusaranzmana.SelectedItem?.ToString() ?? "";

                psiholog.OblastRada = textBoxoblastrada.Text.Trim();
                psiholog.PeriodiDostupnosti = textBoxperioddostupnosti.Text.Trim();

                DTOManager.azurirajPsihologa(psiholog);

                MessageBox.Show("Podaci o psihologu su uspešno izmenjeni!",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
