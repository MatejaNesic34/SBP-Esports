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
    public partial class IzmeniFizioForma : Form
    {
        private FizioterapeutBasic fizioterapeut;

        public IzmeniFizioForma()
        {
            InitializeComponent();
        }

        public IzmeniFizioForma(FizioterapeutBasic f)
        {
            InitializeComponent();
            this.fizioterapeut = f;
            popuniPoljaPodacima();
        }

        private void popuniPoljaPodacima()
        {
            if (fizioterapeut == null) return;

            textBoxIme.Text = fizioterapeut.Ime ?? "";
            textBoxPrezime.Text = fizioterapeut.Prezime ?? "";
            dtpdatum.Value = fizioterapeut.DatumRodjenja ?? DateTime.Now;
            textBoxdrzava.Text = fizioterapeut.Drzava ?? "";
            textBoxemail.Text = fizioterapeut.Email ?? "";
            comboBoxstatusaranzmana.SelectedItem = fizioterapeut.StatusAngazmana;

            // Specifična polja za Fizioterapeuta
            textBoxoblastrada.Text = fizioterapeut.OblastRada ?? "";
            textBoxperioddostupnosti.Text = fizioterapeut.PeriodiDostupnosti ?? "";
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

            DialogResult result = MessageBox.Show($"Da li ste sigurni da želite da sačuvate izmene za fizioterapeuta '{fizioterapeut.Ime} {fizioterapeut.Prezime}'?",
                                                  "Potvrda izmene",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                fizioterapeut.Ime = textBoxIme.Text.Trim();
                fizioterapeut.Prezime = textBoxPrezime.Text.Trim();
                fizioterapeut.DatumRodjenja = dtpdatum.Value;
                fizioterapeut.Drzava = textBoxdrzava.Text.Trim();
                fizioterapeut.Email = textBoxemail.Text.Trim();
                fizioterapeut.StatusAngazmana = comboBoxstatusaranzmana.SelectedItem?.ToString() ?? "";

                fizioterapeut.OblastRada = textBoxoblastrada.Text.Trim();
                fizioterapeut.PeriodiDostupnosti = textBoxperioddostupnosti.Text.Trim();

                DTOManager.azurirajFizioterapeuta(fizioterapeut);

                MessageBox.Show("Podaci o fizioterapeutu su uspešno izmenjeni!",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnotkazi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Da li ste sigurni da želite da odustanete?",
                "Potvrda otkazivanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
