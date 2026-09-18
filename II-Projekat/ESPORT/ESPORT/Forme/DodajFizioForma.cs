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
    public partial class DodajFizioForma : Form
    {
        public DodajFizioForma()
        {
            InitializeComponent();
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

            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da dodate novog fizioterapeuta?",
                                                  "Potvrda dodavanja",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                FizioterapeutBasic f = new FizioterapeutBasic();

                // Polja nasleđena iz Osoba
                f.Ime = textBoxIme.Text.Trim();
                f.Prezime = textBoxPrezime.Text.Trim();
                f.DatumRodjenja = dtpdatum.Value;
                f.Drzava = textBoxdrzava.Text.Trim();
                f.Email = textBoxemail.Text.Trim();
                f.StatusAngazmana = comboBoxstatusaranzmana.SelectedItem?.ToString() ?? "";

                // Specifična polja za Fizioterapeuta
                f.OblastRada = textBoxoblastrada.Text.Trim();
                f.PeriodiDostupnosti = textBoxperioddostupnosti.Text.Trim();

                // Poziv DTO menadžera za čuvanje
                DTOManager.dodajFizioterapeuta(f);

                MessageBox.Show("Fizioterapeut je uspešno dodat!",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
