using System;
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
    public partial class IzmeniAnaliticaraForm : Form
    {
        private AnaliticarBasic analiticar;

        public IzmeniAnaliticaraForm()
        {
            InitializeComponent();
        }

        public IzmeniAnaliticaraForm(AnaliticarBasic a)
        {
            InitializeComponent();
            this.analiticar = a;
            popuniPoljaPodacima();
        }


        private void popuniPoljaPodacima()
        {
            if (analiticar == null) return;

            textBoxIme.Text = analiticar.Ime ?? "";
            textBoxPrezime.Text = analiticar.Prezime ?? "";
            dtpdatum.Value = analiticar.DatumRodjenja ?? DateTime.Now;
            textBoxdrzava.Text = analiticar.Drzava ?? "";
            textBoxemail.Text = analiticar.Email ?? "";
            comboBoxstatusaranzmana.SelectedItem = analiticar.StatusAngazmana;

            textBoxoblastanalize.Text = analiticar.OblastAnalize ?? "";
            textBoxalati.Text = analiticar.Alati ?? "";
            textBoxnivoiskustva.Text = analiticar.NivoIskustva ?? "";
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIme.Text) || string.IsNullOrWhiteSpace(textBoxPrezime.Text))
            {
                MessageBox.Show("Ime i prezime su obavezni!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Da li ste sigurni da želite da sačuvate izmene za analitičara '{analiticar.Ime} {analiticar.Prezime}'?",
                                                  "Potvrda izmene",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                analiticar.Ime = textBoxIme.Text.Trim();
                analiticar.Prezime = textBoxPrezime.Text.Trim();
                analiticar.DatumRodjenja = dtpdatum.Value;
                analiticar.Drzava = textBoxdrzava.Text.Trim();
                analiticar.Email = textBoxemail.Text.Trim();
                analiticar.StatusAngazmana = comboBoxstatusaranzmana.SelectedItem?.ToString() ?? "";

                analiticar.OblastAnalize = textBoxoblastanalize.Text.Trim();
                analiticar.Alati = textBoxalati.Text.Trim();
                analiticar.NivoIskustva = textBoxnivoiskustva.Text.Trim();

                DTOManager.azurirajAnaliticara(analiticar);

                MessageBox.Show("Podaci o analitičaru su uspešno izmenjeni!",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}