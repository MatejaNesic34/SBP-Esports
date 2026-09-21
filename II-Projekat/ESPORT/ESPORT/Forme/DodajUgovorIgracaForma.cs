using System;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class DodajUgovorIgracaForma : Form
    {
        public DodajUgovorIgracaForma()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
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

            var novi = new UgovorDTO.UgovorIgracaBasic
            {
                IgracId = igracId,
                TimId = timId,
                DatumOd = dtpDatumOd.Value,
                DatumDo = chkAktivan.Checked ? (DateTime?)null : dtpDatumDo.Value,
                TipUgovora = txtTipUgovora.Text,
                Plata = plata,
                Bonusi = bonusi,
                KlauzulaOtkup = klauzula,
                ZabranaNastupa = txtZabrana.Text,
                StatusIgraca = txtStatus.Text
            };

            if (DTOManager.dodajUgovorIgraca(novi))
            {
                MessageBox.Show("Ugovor je uspešno dodat!");
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