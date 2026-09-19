using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.MecDTO;
using static ESPORT.TakmicenjeDTO;

namespace ESPORT.Forme
{
    public partial class IzmeniMecForma : Form
    {
        private MecBasic mec;

        public IzmeniMecForma(MecBasic mec)
        {
            InitializeComponent();

            this.mec = mec;

            popuniTakmicenja();
            popuniPodacima();
        }

        private void popuniTakmicenja()
        {
            cmbTakmicenje.Items.Clear();

            List<TakmicenjePregled> takmicenja =
                DTOManager.vratiSvaTakmicenja();

            foreach (TakmicenjePregled takmicenje in takmicenja)
            {
                cmbTakmicenje.Items.Add(takmicenje);
            }

            cmbTakmicenje.DisplayMember = "Naziv";
            cmbTakmicenje.ValueMember = "TakmicenjeId";
        }

        private void popuniPodacima()
        {
            txtMecId.Text =
                mec.MecId.ToString();

            txtRedniBroj.Text =
                mec.RedniBroj.ToString();

            dtpDatumVremePocetka.Value =
                mec.DatumVremePocetka;

            txtFormatMeca.Text =
                mec.FormatMeca;

            txtBrojMapa.Text =
                mec.BrojOdigranihMapa.ToString();

            txtRezultat.Text =
                mec.Rezultat;

            txtTrajanje.Text =
                mec.Trajanje.HasValue
                    ? mec.Trajanje.Value.ToString()
                    : "";

            txtLokacijaIgranja.Text =
                mec.LokacijaIgranja;

            txtSudije.Text =
                mec.Sudije;

            txtStatusMeca.Text =
                mec.StatusMeca;

            for (int i = 0; i < cmbTakmicenje.Items.Count; i++)
            {
                TakmicenjePregled takmicenje =
                    (TakmicenjePregled)cmbTakmicenje.Items[i];

                if (takmicenje.TakmicenjeId ==
                    mec.TakmicenjeId)
                {
                    cmbTakmicenje.SelectedIndex = i;
                    break;
                }
            }
        }

        private void izmeniMecBtn_Click(
            object sender,
            EventArgs e)
        {
            if (cmbTakmicenje.SelectedItem == null)
            {
                MessageBox.Show(
                    "Izaberite takmičenje!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!int.TryParse(
                txtRedniBroj.Text,
                out int redniBroj) ||
                redniBroj <= 0)
            {
                MessageBox.Show(
                    "Redni broj mora biti pozitivan broj!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!int.TryParse(
                txtBrojMapa.Text,
                out int brojMapa) ||
                brojMapa < 0)
            {
                MessageBox.Show(
                    "Broj mapa mora biti pozitivan broj ili nula!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int? trajanje = null;

            if (!string.IsNullOrWhiteSpace(txtTrajanje.Text))
            {
                if (!int.TryParse(
                    txtTrajanje.Text,
                    out int trajanjeVrednost) ||
                    trajanjeVrednost < 0)
                {
                    MessageBox.Show(
                        "Trajanje mora biti pozitivan broj!",
                        "Upozorenje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                trajanje = trajanjeVrednost;
            }

            TakmicenjePregled izabranoTakmicenje =
                (TakmicenjePregled)cmbTakmicenje.SelectedItem;

            mec.TakmicenjeId =
                izabranoTakmicenje.TakmicenjeId;

            mec.RedniBroj =
                redniBroj;

            mec.DatumVremePocetka =
                dtpDatumVremePocetka.Value;

            mec.FormatMeca =
                txtFormatMeca.Text;

            mec.BrojOdigranihMapa =
                brojMapa;

            mec.Rezultat =
                txtRezultat.Text;

            mec.Trajanje =
                trajanje;

            mec.LokacijaIgranja =
                txtLokacijaIgranja.Text;

            mec.Sudije =
                txtSudije.Text;

            mec.StatusMeca =
                txtStatusMeca.Text;

            bool uspesno =
                DTOManager.azurirajMec(mec);

            if (uspesno)
            {
                MessageBox.Show(
                    "Meč je uspešno izmenjen!",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void odustaniBtn_Click(
            object sender,
            EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}