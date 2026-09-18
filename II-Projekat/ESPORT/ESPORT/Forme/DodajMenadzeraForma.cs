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
            if (string.IsNullOrWhiteSpace(textBoxIme.Text) || string.IsNullOrWhiteSpace(textBoxPrezime.Text))
            {
                MessageBox.Show("Ime i prezime su obavezni!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da dodate novog menadžera?",
                                                  "Potvrda dodavanja",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MenadzerBasic m = new MenadzerBasic();

                m.Ime = textBoxIme.Text.Trim();
                m.Prezime = textBoxPrezime.Text.Trim();
                m.DatumRodjenja = dtpdatum.Value;
                m.Drzava = textBoxdrzava.Text.Trim();
                m.Email = textBoxemail.Text.Trim();
               // m.DatumPrvogAngazovanja = dtpdatumprvogangazovanja.Value;
                m.StatusAngazmana = comboBoxstatusaranzmana.SelectedItem?.ToString() ?? "";

                m.OblastOdgovornosti = textBoxoblastodgovornosti.Text.Trim();

                DTOManager.dodajMenadzera(m);

                MessageBox.Show("Menadžer je uspešno dodat!",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
