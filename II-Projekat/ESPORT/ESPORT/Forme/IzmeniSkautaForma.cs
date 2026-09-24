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
    public partial class IzmeniSkautaForma : Form
    {
        private SkautBasic skaut;
        public IzmeniSkautaForma()
        {
            InitializeComponent();
        }
        public IzmeniSkautaForma(SkautBasic s)
        {
            InitializeComponent();
            this.skaut = s;
        }
        private void IzmeniSkautaForma_Load(object sender, EventArgs e)
        {
            popuniComboBoxIgre();
            popuniPoljaPodacima();
        }

        private void popuniPoljaPodacima()
        {
            if (skaut == null) return;

            textBoxIme.Text = skaut.Ime ?? "";
            textBoxPrezime.Text = skaut.Prezime ?? "";
            dtpdatum.Value = skaut.DatumRodjenja ?? DateTime.Now;
            dtpdatumprvogangazovanja.Value = skaut.DatumPrvogAngazovanja ?? DateTime.Now;
            textBoxdrzava.Text = skaut.Drzava ?? "";
            textBoxemail.Text = skaut.Email ?? "";
            comboBoxstatusaranzmana.SelectedItem = skaut.StatusAngazmana;

            if (skaut.IgraId != 0)
            {
                cmbigre.SelectedValue = skaut.IgraId;
            }
        }
        private void popuniComboBoxIgre()
        {
            try
            {
                var igre = DTOManager.vratiSveIgre();

                if (igre != null && igre.Count > 0)
                {
                    cmbigre.DataSource = igre;
                    cmbigre.DisplayMember = "Naziv";
                    cmbigre.ValueMember = "IgraId";
                    cmbigre.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju igara: {ex.Message}",
                                "Greška",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
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

            if (comboBoxstatusaranzmana.SelectedItem == null || cmbigre.SelectedItem == null)
            {
                MessageBox.Show("Molimo vas da izaberete status angažmana i igru!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Da li ste sigurni da želite da sačuvate izmene za skauta '{skaut.Ime} {skaut.Prezime}'?",
                                                  "Potvrda izmene",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                skaut.Ime = textBoxIme.Text.Trim();
                skaut.Prezime = textBoxPrezime.Text.Trim();
                skaut.DatumRodjenja = dtpdatum.Value;
                skaut.DatumPrvogAngazovanja = dtpdatumprvogangazovanja.Value;
                skaut.Drzava = textBoxdrzava.Text.Trim();
                skaut.Email = textBoxemail.Text.Trim();
                skaut.StatusAngazmana = comboBoxstatusaranzmana.SelectedItem?.ToString() ?? "";

                if (cmbigre.SelectedValue != null)
                {
                    skaut.IgraId = (int)cmbigre.SelectedValue;
                }

                DTOManager.azurirajSkauta(skaut);

                MessageBox.Show("Podaci o skautu su uspešno izmenjeni!",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnotkazi_Click(object sender, EventArgs e)
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
