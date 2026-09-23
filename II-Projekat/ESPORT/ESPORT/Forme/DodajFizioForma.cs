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
            if (string.IsNullOrWhiteSpace(textBoxIme.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrezime.Text))
            {
                MessageBox.Show("Molimo vas da popunite sva tekstualna polja!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxstatusaranzmana.SelectedItem == null)
            {
                MessageBox.Show("Molimo vas da izaberete status angažmana!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            FizioterapeutBasic f = new FizioterapeutBasic();

            f.Ime = textBoxIme.Text.Trim();
            f.Prezime = textBoxPrezime.Text.Trim();
            f.DatumRodjenja = dtpdatum.Value;
            f.Drzava = textBoxdrzava.Text.Trim();
            f.Email = textBoxemail.Text.Trim();
            f.StatusAngazmana = comboBoxstatusaranzmana.SelectedItem.ToString();
            f.DatumPrvogAngazovanja = DateTime.Now;

            f.OblastRada = textBoxoblastrada.Text.Trim();
            f.PeriodiDostupnosti = textBoxperioddostupnosti.Text.Trim();

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