using System;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class DodajSponzoraForma : Form
    {
        public DodajSponzoraForma()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Naziv sponzora je obavezan!");
                return;
            }

            SponzorDTO.SponzorBasic novi = new SponzorDTO.SponzorBasic
            {
                Naziv = txtNaziv.Text,
                Drzava = txtDrzava.Text,
                TipSponzora = txtTipSponzora.Text,
                OblastPoslovanja = txtOblastPoslovanja.Text
            };

            if (DTOManager.dodajSponzora(novi))
            {
                MessageBox.Show("Sponzor je uspešno dodat!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}