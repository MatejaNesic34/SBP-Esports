using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ESPORT.AnaliticarDTO;

namespace ESPORT.Forme
{
    public partial class DodajAnaliticaraForm : Form
    {
        public DodajAnaliticaraForm()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIme.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrezime.Text) ||
                string.IsNullOrWhiteSpace(textBoxemail.Text) ||
                comboBoxstatusaranzmana.SelectedItem == null)
            {
                MessageBox.Show("Obavezna polja: Ime, prezime, email i status!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            AnaliticarBasic a = new AnaliticarBasic();

            a.Ime = textBoxIme.Text.Trim();
            a.Prezime = textBoxPrezime.Text.Trim();
            a.DatumRodjenja = dtpdatum.Value;
            a.Drzava = textBoxdrzava.Text.Trim();
            a.Email = textBoxemail.Text.Trim();
            a.DatumPrvogAngazovanja = dtpdatumprvogangazovanja.Value;
            a.StatusAngazmana = comboBoxstatusaranzmana.SelectedItem.ToString();

            a.OblastAnalize = textBoxoblastanalize.Text.Trim();
            a.Alati = textBoxalati.Text.Trim();
            a.NivoIskustva = textBoxnivoiskustva.Text.Trim();

            DTOManager.dodajAnaliticara(a);

            MessageBox.Show("Analitičar je uspešno dodat!",
                            "Obaveštenje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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