using System;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class DodajSponzorKontaktForma : Form
    {
        private int sponzorId;

        public DodajSponzorKontaktForma(int idSponzora)
        {
            InitializeComponent();
            sponzorId = idSponzora;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text) || string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                MessageBox.Show("Ime i prezime kontakta su obavezni!");
                return;
            }

            SponzorDTO.SponzorKontaktBasic noviKontakt = new SponzorDTO.SponzorKontaktBasic
            {
                SponzorId = sponzorId,
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Telefon = txtTelefon.Text,
                Email = txtEmail.Text
            };

            if (DTOManager.dodajSponzorKontakt(noviKontakt))
            {
                MessageBox.Show("Kontakt je uspešno dodat!");
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