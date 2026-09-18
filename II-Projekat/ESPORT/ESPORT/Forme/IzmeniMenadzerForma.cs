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
    public partial class IzmeniMenadzerForma : Form
    {
        private MenadzerBasic menadzer;

        public IzmeniMenadzerForma()
        {
            InitializeComponent();
        }

        public IzmeniMenadzerForma(MenadzerBasic m)
        {
            InitializeComponent();
            this.menadzer = m;
            popuniPoljaPodacima();
        }

        private void popuniPoljaPodacima()
        {
            if (menadzer == null) return;

            textBoxIme.Text = menadzer.Ime ?? "";
            textBoxPrezime.Text = menadzer.Prezime ?? "";
            dtpdatum.Value = menadzer.DatumRodjenja ?? DateTime.Now;
            textBoxdrzava.Text = menadzer.Drzava ?? "";
            textBoxemail.Text = menadzer.Email ?? "";
            comboBoxstatusaranzmana.SelectedItem = menadzer.StatusAngazmana;

            textBoxoblastodgovornosti.Text = menadzer.OblastOdgovornosti ?? "";
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

            DialogResult result = MessageBox.Show($"Da li ste sigurni da želite da sačuvate izmene za menadžera '{menadzer.Ime} {menadzer.Prezime}'?",
                                                  "Potvrda izmene",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                menadzer.Ime = textBoxIme.Text.Trim();
                menadzer.Prezime = textBoxPrezime.Text.Trim();
                menadzer.DatumRodjenja = dtpdatum.Value;
                menadzer.Drzava = textBoxdrzava.Text.Trim();
                menadzer.Email = textBoxemail.Text.Trim();
                menadzer.StatusAngazmana = comboBoxstatusaranzmana.SelectedItem?.ToString() ?? "";

                menadzer.OblastOdgovornosti = textBoxoblastodgovornosti.Text.Trim();

                DTOManager.azurirajMenadzera(menadzer);

                MessageBox.Show("Podaci o menadžeru su uspešno izmenjeni!",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
