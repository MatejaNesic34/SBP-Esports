using ESPORT.Forme;
using System;
using System.Windows.Forms;

namespace ESPORT
{
    public partial class StatistikaForma : Form
    {
        public StatistikaForma()
        {
            InitializeComponent();
            popuniListu();
        }

        private void popuniListu()
        {
            listViewStatistike.Items.Clear();

            var statistike =
                DTOManager.vratiSveStatistikeTimaNaMecu();

            foreach (var s in statistike)
            {
                ListViewItem item = new ListViewItem(s.Mec);

                item.SubItems.Add(s.Tim);
                item.SubItems.Add(s.Kills.ToString());
                item.SubItems.Add(s.Deaths.ToString());
                item.SubItems.Add(s.Assists.ToString());
                item.SubItems.Add(s.Damage.ToString());
                item.SubItems.Add(s.ObjectiveScore.ToString());
                item.SubItems.Add(s.Gold.ToString());

                // Kompozitni ključ: MEC_ID + TIM_ID
                item.Tag = new int[] { s.MecId, s.TimId };

                listViewStatistike.Items.Add(item);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajStatistikuForma forma =
                new DodajStatistikuForma();

            forma.ShowDialog();

            popuniListu();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listViewStatistike.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Izaberite statistiku koju želite da izmenite.",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int[] kljuc =
                (int[])listViewStatistike.SelectedItems[0].Tag;

            int mecId = kljuc[0];
            int timId = kljuc[1];

            IzmeniStatistikuForma forma =
                new IzmeniStatistikuForma(mecId, timId);

            forma.ShowDialog();

            popuniListu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewStatistike.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Izaberite statistiku koju želite da obrišete.",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int[] kljuc =
                (int[])listViewStatistike.SelectedItems[0].Tag;

            int mecId = kljuc[0];
            int timId = kljuc[1];

            DialogResult rezultat = MessageBox.Show(
                "Da li ste sigurni da želite da obrišete izabranu statistiku?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rezultat == DialogResult.Yes)
            {
                if (DTOManager.obrisiStatistikuTimaNaMecu(
                    mecId,
                    timId))
                {
                    popuniListu();
                }
            }
        }
    }
}