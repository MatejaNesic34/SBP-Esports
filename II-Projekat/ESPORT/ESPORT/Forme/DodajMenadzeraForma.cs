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
    public partial class DodajMenadzeraForma : Form
    {
        public DodajMenadzeraForma()
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

            MenadzerBasic m = new MenadzerBasic();

            m.Ime = textBoxIme.Text.Trim();
            m.Prezime = textBoxPrezime.Text.Trim();
            m.DatumRodjenja = dtpdatum.Value;
            m.Drzava = textBoxdrzava.Text.Trim();
            m.Email = textBoxemail.Text.Trim();
            m.StatusAngazmana = comboBoxstatusaranzmana.SelectedItem.ToString();
            m.DatumPrvogAngazovanja = DateTime.Now;

            m.OblastOdgovornosti = textBoxoblastodgovornosti.Text.Trim();

            DTOManager.dodajMenadzera(m);

            MessageBox.Show("Menadžer je uspešno dodat!",
                            "Obaveštenje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

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