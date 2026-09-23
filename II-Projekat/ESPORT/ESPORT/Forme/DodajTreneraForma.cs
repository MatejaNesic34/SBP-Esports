using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if (string.IsNullOrWhiteSpace(textBoxIme.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrezime.Text) ||
                string.IsNullOrWhiteSpace(textBoxdrzava.Text) ||
                string.IsNullOrWhiteSpace(textBoxemail.Text) ||
                string.IsNullOrWhiteSpace(textboxstilrada.Text))
            {
                MessageBox.Show("Molimo vas da popunite sva tekstualna polja!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxstatusaranzmana.SelectedItem == null ||
                (comboBoxtipuloge.SelectedItem == null && string.IsNullOrWhiteSpace(comboBoxtipuloge.Text)))
            {
                MessageBox.Show("Molimo vas da izaberete status angažmana i tip uloge!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            TrenerBasic tb = new TrenerBasic();

            tb.Ime = textBoxIme.Text.Trim();
            tb.Prezime = textBoxPrezime.Text.Trim();
            tb.DatumRodjenja = dtpdatum.Value;
            tb.Drzava = textBoxdrzava.Text.Trim();
            tb.Email = textBoxemail.Text.Trim();
            tb.StatusAngazmana = comboBoxstatusaranzmana.SelectedItem.ToString();
            tb.DatumPrvogAngazovanja = dtpdatum.Value;
            tb.TipUloge = comboBoxtipuloge.SelectedItem?.ToString() ?? comboBoxtipuloge.Text.Trim();
            tb.StilRada = textboxstilrada.Text.Trim();
            tb.DatumPrvogAngazovanja = DateTime.Now;

            DTOManager.dodajTrenera(tb);

            MessageBox.Show("Trener je uspešno dodat!",
                            "Obaveštenje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}