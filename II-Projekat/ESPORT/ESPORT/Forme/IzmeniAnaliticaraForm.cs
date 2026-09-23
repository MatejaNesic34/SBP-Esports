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
            dtpdatumprvogangazovanja.Value = analiticar.DatumPrvogAngazovanja ?? DateTime.Now;
            comboBoxstatusaranzmana.SelectedItem = analiticar.StatusAngazmana;

            textBoxoblastanalize.Text = analiticar.OblastAnalize ?? "";
            textBoxalati.Text = analiticar.Alati ?? "";
            textBoxnivoiskustva.Text = analiticar.NivoIskustva ?? "";
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIme.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrezime.Text) ||
                string.IsNullOrWhiteSpace(textBoxemail.Text))

            {
                MessageBox.Show("Obavezna polja: Ime, prezime, email",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            analiticar.Ime = textBoxIme.Text.Trim();
            analiticar.Prezime = textBoxPrezime.Text.Trim();
            analiticar.DatumRodjenja = dtpdatum.Value;
            analiticar.Drzava = textBoxdrzava.Text.Trim();
            analiticar.Email = textBoxemail.Text.Trim();
            analiticar.DatumPrvogAngazovanja = dtpdatumprvogangazovanja.Value;
            analiticar.StatusAngazmana = comboBoxstatusaranzmana.SelectedItem.ToString();

            analiticar.OblastAnalize = textBoxoblastanalize.Text.Trim();
            analiticar.Alati = textBoxalati.Text.Trim();
            analiticar.NivoIskustva = textBoxnivoiskustva.Text.Trim();

            // Čuvanje u bazi
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