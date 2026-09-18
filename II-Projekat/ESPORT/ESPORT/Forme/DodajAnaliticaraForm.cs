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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
            if (string.IsNullOrWhiteSpace(textBoxIme.Text) || string.IsNullOrWhiteSpace(textBoxPrezime.Text))
            {
                MessageBox.Show("Ime i prezime su obavezni!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da dodate novog analitičara?",
                                                  "Potvrda dodavanja",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AnaliticarBasic a = new AnaliticarBasic();

                a.Ime = textBoxIme.Text.Trim();
                a.Prezime = textBoxPrezime.Text.Trim();
                a.DatumRodjenja = dtpdatum.Value;
                a.Drzava = textBoxdrzava.Text.Trim();
                a.Email = textBoxemail.Text.Trim();
                a.StatusAngazmana = comboBoxstatusaranzmana.SelectedItem?.ToString() ?? "";

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
        }
    }
}
