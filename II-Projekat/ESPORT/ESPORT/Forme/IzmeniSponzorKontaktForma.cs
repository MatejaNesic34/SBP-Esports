using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ESPORT.Forme
{
    public partial class IzmeniSponzorKontaktForma : Form
    {
        private int kontaktId;
        private SponzorDTO.SponzorKontaktBasic kontakt;

        public IzmeniSponzorKontaktForma(int idKontakta)
        {
            InitializeComponent();
            kontaktId = idKontakta;
        }

        private void IzmeniSponzorKontaktForma_Load(object sender, EventArgs e)
        {
            // Pošto nemamo direktan select jednog kontakta, nalazimo ga preko baze ili ga prosleđujemo. 
            // Ovde dohvatamo kroz sesiju preko DTOManager-a (može se implementirati ili mapirati upit po ID-u).
            using (var s = DataLayer.GetSession())
            {
                var k = s.Get<ESPORT.Entiteti.SponzorKontakt>(kontaktId);
                if (k != null)
                {
                    kontakt = new SponzorDTO.SponzorKontaktBasic(k.KontaktId, k.Sponzor.SponzorId, k.Ime, k.Prezime, k.Telefon, k.Email);
                    txtIme.Text = kontakt.Ime;
                    txtPrezime.Text = kontakt.Prezime;
                    txtTelefon.Text = kontakt.Telefon;
                    txtEmail.Text = kontakt.Email;
                }
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text) || string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                MessageBox.Show("Ime i prezime kontakta su obavezni!");
                return;
            }

            kontakt.Ime = txtIme.Text;
            kontakt.Prezime = txtPrezime.Text;
            kontakt.Telefon = txtTelefon.Text;
            kontakt.Email = txtEmail.Text;

            if (DTOManager.azurirajSponzorKontakt(kontakt))
            {
                MessageBox.Show("Kontakt je uspešno izmenjen!");
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