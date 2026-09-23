using System;
using System.Windows.Forms;

namespace ESPORT
{
    public partial class IzmeniStatistikuForma : Form
    {
        private int mecId;
        private int timId;

        public IzmeniStatistikuForma(int mecId, int timId)
        {
            InitializeComponent();

            this.mecId = mecId;
            this.timId = timId;

            popuniPodatke();
        }

        private void popuniPodatke()
        {
            StatistikaTimaNaMecuDTO.StatistikaTimaNaMecuBasic statistika =
                DTOManager.vratiStatistikuTimaNaMecu(mecId, timId);

            if (statistika == null)
            {
                MessageBox.Show(
                    "Statistika ne postoji.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();
                return;
            }

            lblMecVrednost.Text = mecId.ToString();
            lblTimVrednost.Text = timId.ToString();

            txtKills.Text = statistika.Kills.ToString();
            txtDeaths.Text = statistika.Deaths.ToString();
            txtAssists.Text = statistika.Assists.ToString();
            txtDamage.Text = statistika.Damage.ToString();
            txtObjectiveScore.Text = statistika.ObjectiveScore.ToString();
            txtGold.Text = statistika.Gold.ToString();
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
                    "Assists mora biti pozitivan broj.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtDamage.Text, out int damage) || damage < 0)
            {
                MessageBox.Show(
                    "Damage mora biti pozitivan broj.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtObjectiveScore.Text, out int objectiveScore) ||
                objectiveScore < 0)
            {
                MessageBox.Show(
                    "Objective Score mora biti pozitivan broj.",
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
            if (!validirajBrojeve())
                return;

            StatistikaTimaNaMecuDTO.StatistikaTimaNaMecuBasic statistika =
                new StatistikaTimaNaMecuDTO.StatistikaTimaNaMecuBasic(
                    mecId,
                    timId,
                    int.Parse(txtKills.Text),
                    int.Parse(txtDeaths.Text),
                    int.Parse(txtAssists.Text),
                    int.Parse(txtDamage.Text),
                    int.Parse(txtObjectiveScore.Text),
                    int.Parse(txtGold.Text));

            if (DTOManager.azurirajStatistikuTimaNaMecu(statistika))
            {
                MessageBox.Show(
                    "Statistika je uspešno izmenjena.",
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