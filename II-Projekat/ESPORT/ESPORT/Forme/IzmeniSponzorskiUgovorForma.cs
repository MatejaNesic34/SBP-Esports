using System;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class IzmeniSponzorskiUgovorForma : Form
    {
        private int ugovorId;
        private SponzorDTO.SponzorskiUgovorBasic ugovor;

        public IzmeniSponzorskiUgovorForma(int idUgovora)
        {
            InitializeComponent();
            ugovorId = idUgovora;
        }

        private void IzmeniSponzorskiUgovorForma_Load(object sender, EventArgs e)
        {
            using (var s = DataLayer.GetSession())
            {
                var u = s.Get<ESPORT.Entiteti.SponzorskiUgovor>(ugovorId);
                if (u != null)
                {
                    ugovor = new SponzorDTO.SponzorskiUgovorBasic(u.UgovorId, u.Sponzor.SponzorId, u.DatumOd, u.DatumDo, u.Iznos, u.Valuta, u.TipPodrske, u.MarketinskeObaveze);

                    dtpDatumOd.Value = ugovor.DatumOd;
                    dtpDatumDo.Value = ugovor.DatumDo;
                    txtIznos.Text = ugovor.Iznos.ToString();
                    txtValuta.Text = ugovor.Valuta;
                    txtTipPodrske.Text = ugovor.TipPodrske;
                    txtMarketinskeObaveze.Text = ugovor.MarketinskeObaveze;
                }
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtIznos.Text, out decimal iznos))
            {
                MessageBox.Show("Unesite validan numerički iznos ugovora!");
                return;
            }

            ugovor.DatumOd = dtpDatumOd.Value;
            ugovor.DatumDo = dtpDatumDo.Value;
            ugovor.Iznos = iznos;
            ugovor.Valuta = txtValuta.Text;
            ugovor.TipPodrske = txtTipPodrske.Text;
            ugovor.MarketinskeObaveze = txtMarketinskeObaveze.Text;

            if (DTOManager.azurirajSponzorskiUgovor(ugovor))
            {
                MessageBox.Show("Ugovor je uspešno izmenjen!");
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