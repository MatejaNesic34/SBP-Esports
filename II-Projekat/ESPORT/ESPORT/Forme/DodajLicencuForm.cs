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
    public partial class DodajLicencuForm : Form
    {
        public DodajLicencuForm()
        {
            InitializeComponent();
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

            LicencaBasic l = new LicencaBasic();

            l.Naziv = textBoxnaziv.Text.Trim();
            l.InstitucijaIzdavac = textBoxinstitucija.Text.Trim();
            l.DatumSticanja = dtpdatum.Value;
            l.OsobaId = osobaId;

            DTOManager.dodajLicencu(l);

            MessageBox.Show("Licenca je uspešno dodata!",
                            "Obaveštenje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
