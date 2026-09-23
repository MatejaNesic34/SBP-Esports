using System;
using System.Windows.Forms;

namespace ESPORT
{
    public partial class DodajStatistikuForma : Form
    {
        public DodajStatistikuForma()
        {
            InitializeComponent();

            popuniMeceve();
            popuniTimove();

            cmbMec.SelectedIndex = -1;
            cmbTim.SelectedIndex = -1;
        }

        private void popuniMeceve()
        {
            cmbMec.Items.Clear();

            var mecevi = DTOManager.vratiSveMeceve();

            foreach (var mec in mecevi)
            {
                cmbMec.Items.Add(
                    new ComboBoxItem(
                        mec.MecId,
                        mec.MecId.ToString()));
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

        private bool validirajBrojeve()
        {
            if (!int.TryParse(txtKills.Text, out int kills) || kills < 0)
            {
                MessageBox.Show(
                    "Kills mora biti pozitivan broj.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtDeaths.Text, out int deaths) || deaths < 0)
            {
                MessageBox.Show(
                    "Deaths mora biti pozitivan broj.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtAssists.Text, out int assists) || assists < 0)
            {
                MessageBox.Show(
                    "Assists mora biti pozitivan broj",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtDamage.Text, out int damage) || damage < 0)
            {
                MessageBox.Show(
                    "Damage mora biti pozitivan broj",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtObjectiveScore.Text, out int objectiveScore) ||
                objectiveScore < 0)
            {
                MessageBox.Show(
                    "Objective Score mora biti pozitivan broj",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtGold.Text, out int gold) || gold < 0)
            {
                MessageBox.Show(
                    "Gold mora biti pozitivan broj.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (cmbMec.SelectedItem == null)
            {
                MessageBox.Show(
                    "Izaberite meč.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cmbTim.SelectedItem == null)
            {
                MessageBox.Show(
                    "Izaberite tim.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!validirajBrojeve())
                return;

            ComboBoxItem mec =
                (ComboBoxItem)cmbMec.SelectedItem;

            ComboBoxItem tim =
                (ComboBoxItem)cmbTim.SelectedItem;

            StatistikaTimaNaMecuDTO.StatistikaTimaNaMecuBasic statistika =
                new StatistikaTimaNaMecuDTO.StatistikaTimaNaMecuBasic(
                    mec.Id,
                    tim.Id,
                    int.Parse(txtKills.Text),
                    int.Parse(txtDeaths.Text),
                    int.Parse(txtAssists.Text),
                    int.Parse(txtDamage.Text),
                    int.Parse(txtObjectiveScore.Text),
                    int.Parse(txtGold.Text));

            if (DTOManager.dodajStatistikuTimaNaMecu(statistika))
            {
                MessageBox.Show(
                    "Statistika je uspešno dodata.",
                    "Uspešno",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}