using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ESPORT.IgracDTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ESPORT.Forme
{
    public partial class DodajIgracaForm : Form
    {
        public DodajIgracaForm()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIme.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrezime.Text) ||
                string.IsNullOrWhiteSpace(textBoxnadimak.Text))
            {
                MessageBox.Show("Polja Ime, Prezime i Nadimak su obavezna!",
                                "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IgracBasic ib = new IgracBasic
            {
                Ime = textBoxIme.Text.Trim(),
                Prezime = textBoxPrezime.Text.Trim(),
                Nadimak = textBoxnadimak.Text.Trim(),
                PrimarnaUloga = textBoxprimarnauloga.Text.Trim(),
                SekundarnaUloga = textBoxsekundarnauloga.Text.Trim(),
                DominantniStil = textBoxdominantanstiligre.Text.Trim(),
                Rang = textBoxrang.Text.Trim(),
                DatumRodjenja = dtpdatum.Value,
                Drzava = textBoxdrzava.Text.Trim(),
                Email = textBoxemail.Text.Trim(),
                StatusAngazmana = comboBoxstatusaranzmana.SelectedItem?.ToString() ?? ""
            };

            string brojTelefona = textBoxtelefon.Text.Trim();
            if (!string.IsNullOrEmpty(brojTelefona))
            {
                ib.Telefoni.Add(brojTelefona);
            }

            DTOManager.dodajIgraca(ib);

            MessageBox.Show("Igrač je uspešno dodat!", "Obaveštenje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void otkazibtn_Click(object sender, EventArgs e)
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
