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

            PsihologBasic p = new PsihologBasic();

            p.Ime = textBoxIme.Text.Trim();
            p.Prezime = textBoxPrezime.Text.Trim();
            p.DatumRodjenja = dtpdatum.Value;
            p.Drzava = textBoxdrzava.Text.Trim();
            p.Email = textBoxemail.Text.Trim();
            p.StatusAngazmana = comboBoxstatusaranzmana.SelectedItem.ToString();
            p.DatumPrvogAngazovanja = DateTime.Now;

            p.OblastRada = textBoxoblastrada.Text.Trim();
            p.PeriodiDostupnosti = textBoxperioddostupnosti.Text.Trim();

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