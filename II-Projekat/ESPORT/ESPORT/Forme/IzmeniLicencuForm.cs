using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ESPORT.LicencaDTO;

namespace ESPORT.Forme
{
    public partial class IzmeniLicencuForm : Form
    {
        private LicencaBasic licenca;

        public IzmeniLicencuForm()
        {
            InitializeComponent();
        }

        public IzmeniLicencuForm(LicencaBasic l)
        {
            InitializeComponent();
            this.licenca = l;
            popuniPoljaPodacima();
        }

        private void popuniPoljaPodacima()
        {
            if (licenca == null) return;

            textBoxnaziv.Text = licenca.Naziv ?? "";
            textBoxinstitucija.Text = licenca.InstitucijaIzdavac ?? "";
            dtpdatum.Value = licenca.DatumSticanja != DateTime.MinValue ? licenca.DatumSticanja : DateTime.Now;
            numid.Text = licenca.OsobaId.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxnaziv.Text) ||
                string.IsNullOrWhiteSpace(textBoxinstitucija.Text) ||
                string.IsNullOrWhiteSpace(numid.Text))
            {
                MessageBox.Show("Obavezna polja: Naziv, Institucija izdavanja i ID osobe!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(numid.Text.Trim(), out int osobaId))
            {
                MessageBox.Show("ID osobe mora biti broj!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Da li ste sigurni da želite da sačuvate izmene za licencu '{licenca.Naziv}'?",
                                                  "Potvrda izmene",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                licenca.Naziv = textBoxnaziv.Text.Trim();
                licenca.InstitucijaIzdavac = textBoxinstitucija.Text.Trim();
                licenca.DatumSticanja = dtpdatum.Value;
                licenca.OsobaId = osobaId;

                DTOManager.izmeniLicencu(licenca);

                MessageBox.Show("Podaci o licenci su uspešno izmenjeni!",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
