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
using static ESPORT.IgracDTO.TrenerDTO;

namespace ESPORT.Forme
{
    public partial class DodajTreneraForma : Form
    {
        public DodajTreneraForma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validacija obaveznih polja
            if (string.IsNullOrWhiteSpace(textBoxIme.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrezime.Text))
            {
                MessageBox.Show("Polja Ime i Prezime su obavezna!",
                                "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kreiranje DTO objekta za Trenera
            TrenerBasic tb = new TrenerBasic
            {
                Ime = textBoxIme.Text.Trim(),
                Prezime = textBoxPrezime.Text.Trim(),
                DatumRodjenja = dtpdatum.Value,
                Drzava = textBoxdrzava.Text.Trim(),
                Email = textBoxemail.Text.Trim(),
                StatusAngazmana = comboBoxstatusaranzmana.SelectedItem?.ToString() ?? "Aktivan",
                TipUloge = comboBoxtipuloge.SelectedItem?.ToString() ?? comboBoxtipuloge.Text.Trim(),
                StilRada = textboxstilrada.Text.Trim(),
                DatumPrvogAngazovanja = DateTime.Now
            };



            // Poziv DTOManager-a za upis u bazu
            DTOManager.dodajTrenera(tb);

            MessageBox.Show("Trener je uspešno dodat!", "Obaveštenje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
