using System;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class IzmeniUgovorIgracaForma : Form
    {
        private int ugovorId;
        private UgovorDTO.UgovorIgracaBasic ugovor;

        public IzmeniUgovorIgracaForma(int idUgovora)
        {
            InitializeComponent();
            ugovorId = idUgovora;
        }

        private void IzmeniUgovorIgracaForma_Load(object sender, EventArgs e)
        {
            using (var s = DataLayer.GetSession())
            {
                var u = s.Get<ESPORT.Entiteti.UgovorIgraca>(ugovorId);
                if (u != null)
                {
                    ugovor = new UgovorDTO.UgovorIgracaBasic(
                        u.UgovorId,
                        u.Igrac?.OsobaId ?? 0,
                        u.Igrac != null ? $"{u.Igrac.Ime} {u.Igrac.Prezime}" : "",
                        u.Tim?.TimId ?? 0,
                        u.Tim?.Naziv ?? "",
                        u.DatumOd,
                        u.DatumDo,
                        u.TipUgovora,
                        u.Plata,
                        u.Bonusi,
                        u.KlauzulaOtkup,
                        u.ZabranaNastupa,
                        u.StatusIgraca
                    );

                    txtIgracId.Text = ugovor.IgracId.ToString();
                    txtTimId.Text = ugovor.TimId.ToString();
                    dtpDatumOd.Value = ugovor.DatumOd;
                    if (ugovor.DatumDo.HasValue)
                    {
                        dtpDatumDo.Value = ugovor.DatumDo.Value;
                        chkAktivan.Checked = false;
                        dtpDatumDo.Enabled = true;
                    }
                    else
                    {
                        chkAktivan.Checked = true;
                        dtpDatumDo.Enabled = false;
                    }
                    txtTipUgovora.Text = ugovor.TipUgovora;
                    txtPlata.Text = ugovor.Plata.ToString();
                    txtBonusi.Text = ugovor.Bonusi.ToString();
                    txtKlauzula.Text = ugovor.KlauzulaOtkup?.ToString() ?? "";
                    txtZabrana.Text = ugovor.ZabranaNastupa;
                    txtStatus.Text = ugovor.StatusIgraca;
                }
            }
        }

        private void chkAktivan_CheckedChanged(object sender, EventArgs e)
        {
            dtpDatumDo.Enabled = !chkAktivan.Checked;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIgracId.Text, out int igracId) || !int.TryParse(txtTimId.Text, out int timId))
            {
                MessageBox.Show("Unesite validne ID-jeve igrača i tima!");
                return;
            }

            if (!decimal.TryParse(txtPlata.Text, out decimal plata))
            {
                MessageBox.Show("Unesite validnu platu!");
                return;
            }

            decimal.TryParse(txtBonusi.Text, out decimal bonusi);
            decimal? klauzula = string.IsNullOrWhiteSpace(txtKlauzula.Text) ? (decimal?)null : decimal.Parse(txtKlauzula.Text);

            ugovor.IgracId = igracId;
            ugovor.TimId = timId;
            ugovor.DatumOd = dtpDatumOd.Value;
            ugovor.DatumDo = chkAktivan.Checked ? (DateTime?)null : dtpDatumDo.Value;
            ugovor.TipUgovora = txtTipUgovora.Text;
            ugovor.Plata = plata;
            ugovor.Bonusi = bonusi;
            ugovor.KlauzulaOtkup = klauzula;
            ugovor.ZabranaNastupa = txtZabrana.Text;
            ugovor.StatusIgraca = txtStatus.Text;

            if (DTOManager.azurirajUgovorIgraca(ugovor))
            {
                MessageBox.Show("Ugovor je uspešno izmenjen!");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}