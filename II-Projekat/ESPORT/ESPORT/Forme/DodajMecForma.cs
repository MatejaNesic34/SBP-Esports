using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.MecDTO;
using static ESPORT.TakmicenjeDTO;

namespace ESPORT.Forme
{
    public partial class DodajMecForma : Form
    {
        public DodajMecForma()
        {
            InitializeComponent();

            popuniTakmicenja();
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

            if (cmbTakmicenje.Items.Count > 0)
                cmbTakmicenje.SelectedIndex = 0;
        }

        private void dodajMecBtn_Click(object sender, EventArgs e)
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

            if (numRedniBroj.Value <= 0)
            {
                MessageBox.Show(
                    "Redni broj mora biti veći od 0!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (numBrojMapa.Value < 0)
            {
                MessageBox.Show(
                    "Broj mapa ne može biti negativan!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cmbStatusMeca.SelectedItem == null && string.IsNullOrWhiteSpace(cmbStatusMeca.Text))
            {
                MessageBox.Show(
                    "Izaberite ili unesite status meča!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!string.IsNullOrWhiteSpace(txtTrajanje.Text) &&
                !int.TryParse(txtTrajanje.Text, out int trajanje))
            {
                MessageBox.Show(
                    "Trajanje mora biti broj!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int? trajanjeVrednost = null;

            if (!string.IsNullOrWhiteSpace(txtTrajanje.Text))
                trajanjeVrednost = int.Parse(txtTrajanje.Text);

            TakmicenjePregled izabranoTakmicenje =
                (TakmicenjePregled)cmbTakmicenje.SelectedItem;

            MecBasic mec = new MecBasic
            {
                TakmicenjeId =
                    izabranoTakmicenje.TakmicenjeId,

                RedniBroj =
                    (int)numRedniBroj.Value,

                DatumVremePocetka =
                    dtpDatumVremePocetka.Value,

                FormatMeca =
                    txtFormatMeca.Text,

                BrojOdigranihMapa =
                    (int)numBrojMapa.Value,

                Rezultat =
                    txtRezultat.Text,

                Trajanje =
                    trajanjeVrednost,

                LokacijaIgranja =
                    txtLokacijaIgranja.Text,

                Sudije =
                    txtSudije.Text,

                StatusMeca =
                    cmbStatusMeca.SelectedItem?.ToString() ?? cmbStatusMeca.Text.Trim()
            };

            bool uspesno =
                DTOManager.dodajMec(mec);

            if (uspesno)
            {
                MessageBox.Show(
                    "Meč je uspešno dodat!",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}