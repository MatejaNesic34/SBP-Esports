using System;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class DodajSponzorskiUgovorForma : Form
    {
        private int sponzorId;

        public DodajSponzorskiUgovorForma(int idSponzora)
        {
            InitializeComponent();
            sponzorId = idSponzora;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtIznos.Text, out decimal iznos))
            {
                MessageBox.Show("Unesite validan numerički iznos ugovora!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTipPodrske.Text))
            {
                MessageBox.Show("Tip podrške je obavezan!");
                return;
            }

            SponzorDTO.SponzorskiUgovorBasic noviUgovor = new SponzorDTO.SponzorskiUgovorBasic
            {
                SponzorId = sponzorId,
                DatumOd = dtpDatumOd.Value,
                DatumDo = dtpDatumDo.Value,
                Iznos = iznos,
                Valuta = txtValuta.Text,
                TipPodrske = txtTipPodrske.Text,
                MarketinskeObaveze = txtMarketinskeObaveze.Text
            };

            if (DTOManager.dodajSponzorskiUgovor(noviUgovor))
            {
                MessageBox.Show("Ugovor je uspešno dodat!");
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