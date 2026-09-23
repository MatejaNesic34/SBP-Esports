using ESPORT.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ESPORT.IgraDTO;

namespace ESPORT.Forme
{
    public partial class DodajSkautaForma : Form
    {
        public DodajSkautaForma()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
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

            if (comboBoxstatusaranzmana.SelectedItem == null || cmbigre.SelectedItem == null)
            {
                MessageBox.Show("Molimo vas da izaberete status angažmana i igru!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            SkautBasic s = new SkautBasic();

            s.Ime = textBoxIme.Text.Trim();
            s.Prezime = textBoxPrezime.Text.Trim();
            s.DatumRodjenja = dtpdatum.Value;
            s.Drzava = textBoxdrzava.Text.Trim();
            s.Email = textBoxemail.Text.Trim();
            s.DatumPrvogAngazovanja = dtpdatumprvogangazovanja.Value;
            s.StatusAngazmana = comboBoxstatusaranzmana.SelectedItem.ToString();

            if (cmbigre.SelectedValue != null)
            {
                s.IgraId = (int)cmbigre.SelectedValue;
            }

            DTOManager.dodajSkauta(s);

            MessageBox.Show("Skaut je uspešno dodat!",
                            "Obaveštenje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
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
                MessageBox.Show($"Greška pri učitavanju igara u ComboBox: {ex.Message}",
                                "Greška",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void DodajSkautaForma_Load(object sender, EventArgs e)
        {
            popuniComboBoxIgre();
        }
    }
}
