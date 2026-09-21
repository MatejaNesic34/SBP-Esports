using System;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class IzmeniSponzoraForma : Form
    {
        private int sponzorId;
        private SponzorDTO.SponzorBasic sponzor;

        public IzmeniSponzoraForma(int id)
        {
            InitializeComponent();
            sponzorId = id;
        }

        private void IzmeniSponzoraForma_Load(object sender, EventArgs e)
        {
            sponzor = DTOManager.vratiSponzora(sponzorId);
            if (sponzor != null)
            {
                txtNaziv.Text = sponzor.Naziv;
                txtDrzava.Text = sponzor.Drzava;
                txtTipSponzora.Text = sponzor.TipSponzora;
                txtOblastPoslovanja.Text = sponzor.OblastPoslovanja;
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Naziv sponzora je obavezan!");
                return;
            }

            sponzor.Naziv = txtNaziv.Text;
            sponzor.Drzava = txtDrzava.Text;
            sponzor.TipSponzora = txtTipSponzora.Text;
            sponzor.OblastPoslovanja = txtOblastPoslovanja.Text;

            if (DTOManager.azurirajSponzora(sponzor))
            {
                MessageBox.Show("Sponzor je uspešno izmenjen!");
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