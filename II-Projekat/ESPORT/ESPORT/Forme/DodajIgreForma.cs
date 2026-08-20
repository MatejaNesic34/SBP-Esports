using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ESPORT.IgraDTO;

namespace ESPORT.Forme
{
    public partial class DodajIgreForma : Form
    {
        public DodajIgreForma()
        {
            InitializeComponent();
        }

        private void dodajbtn_Click(object sender, EventArgs e)
        {
            // Validacija unosa
            if (string.IsNullOrWhiteSpace(nazivtextBox.Text))
            {
                MessageBox.Show("Polje 'Naziv' ne sme biti prazno!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kreiranje DTO objekta sa podacima iz forme
                IgraBasic igra = new IgraBasic
                {
                    Naziv = nazivtextBox.Text.Trim(),
                    Zanr = zanrtextBox.Text.Trim()
                };

                // Poziv DTOManager-a za upis u bazu
                DTOManager.dodajIgru(igra);

                MessageBox.Show("Igra je uspešno dodata!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Postavljamo DialogResult na OK kako bi glavna forma znala da treba da osveži ListView
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri dodavanju igre: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
