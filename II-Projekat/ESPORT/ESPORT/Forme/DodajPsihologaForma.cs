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
    public partial class DodajPsihologaForma : Form
    {
        public DodajPsihologaForma()
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

            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da dodate novog psihologa?",
                                                  "Potvrda dodavanja",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                PsihologBasic p = new PsihologBasic();

                // Polja nasleđena iz Osoba
                p.Ime = textBoxIme.Text.Trim();
                p.Prezime = textBoxPrezime.Text.Trim();
                p.DatumRodjenja = dtpdatum.Value;
                p.Drzava = textBoxdrzava.Text.Trim();
                p.Email = textBoxemail.Text.Trim();
                p.StatusAngazmana = comboBoxstatusaranzmana.SelectedItem?.ToString() ?? "";

                // Specifična polja za Psihologa
                p.OblastRada = textBoxoblastrada.Text.Trim();
                p.PeriodiDostupnosti = textBoxperioddostupnosti.Text.Trim();

                // Poziv DTO menadžera za čuvanje
                DTOManager.dodajPsihologa(p);

                MessageBox.Show("Psiholog je uspešno dodat!",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
