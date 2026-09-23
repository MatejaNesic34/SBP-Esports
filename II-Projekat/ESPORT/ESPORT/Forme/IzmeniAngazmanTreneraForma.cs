using System;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class IzmeniAngazmanTreneraForma : Form
    {
        private int angazmanTreneraId;

        public IzmeniAngazmanTreneraForma(
            AngazmanTreneraDTO.AngazmanTreneraBasic angazman)
        {
            InitializeComponent();

            angazmanTreneraId = angazman.AngazmanTreneraId;

            popuniTrenere();
            popuniTimove();

            popuniPodatke(angazman);
        }

        private void popuniTrenere()
        {
            cmbTrener.Items.Clear();

            var treneri = DTOManager.vratiSveTrenere();

            foreach (var trener in treneri)
            {
                cmbTrener.Items.Add(
                    new ComboBoxItem(
                        trener.OsobaId,
                        trener.Ime + " " + trener.Prezime));
            }
        }

        private void popuniTimove()
        {
            cmbTim.Items.Clear();

            var timovi = DTOManager.vratiSveTimove();

            foreach (var tim in timovi)
            {
                cmbTim.Items.Add(
                    new ComboBoxItem(
                        tim.TimId,
                        tim.Naziv));
            }
        }

        private void popuniPodatke(
            AngazmanTreneraDTO.AngazmanTreneraBasic angazman)
        {
            for (int i = 0; i < cmbTrener.Items.Count; i++)
            {
                ComboBoxItem item =
                    (ComboBoxItem)cmbTrener.Items[i];

                if (item.Id == angazman.TrenerId)
                {
                    cmbTrener.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbTim.Items.Count; i++)
            {
                ComboBoxItem item =
                    (ComboBoxItem)cmbTim.Items[i];

                if (item.Id == angazman.TimId)
                {
                    cmbTim.SelectedIndex = i;
                    break;
                }
            }

            txtTipUloge.Text = angazman.TipUloge ?? "";

            dtpDatumOd.Value = angazman.DatumOd;

            if (angazman.DatumDo.HasValue)
            {
                chkDatumDo.Checked = true;
                dtpDatumDo.Value = angazman.DatumDo.Value;
            }
            else
            {
                chkDatumDo.Checked = false;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (cmbTrener.SelectedItem == null)
            {
                MessageBox.Show(
                    "Morate izabrati trenera.",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cmbTim.SelectedItem == null)
            {
                MessageBox.Show(
                    "Morate izabrati tim.",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtTipUloge.Text))
            {
                MessageBox.Show(
                    "Morate uneti tip uloge.",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DateTime datumOd =
                dtpDatumOd.Value.Date;

            DateTime? datumDo = null;

            if (chkDatumDo.Checked)
            {
                datumDo =
                    dtpDatumDo.Value.Date;

                if (datumDo.Value < datumOd)
                {
                    MessageBox.Show(
                        "Datum završetka angažmana ne može biti pre datuma početka.",
                        "Upozorenje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            }

            ComboBoxItem trener =
                (ComboBoxItem)cmbTrener.SelectedItem;

            ComboBoxItem tim =
                (ComboBoxItem)cmbTim.SelectedItem;

            AngazmanTreneraDTO.AngazmanTreneraBasic angazman =
                new AngazmanTreneraDTO.AngazmanTreneraBasic(
                    angazmanTreneraId,
                    trener.Id,
                    tim.Id,
                    txtTipUloge.Text.Trim(),
                    datumOd,
                    datumDo);

            if (DTOManager.azurirajAngazmanTrenera(angazman))
            {
                MessageBox.Show(
                    "Angažman trenera je uspešno izmenjen.",
                    "Uspešno",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void chkDatumDo_CheckedChanged(
            object sender,
            EventArgs e)
        {
            dtpDatumDo.Enabled =
                chkDatumDo.Checked;
        }

        private void btnOdustani_Click(
            object sender,
            EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}