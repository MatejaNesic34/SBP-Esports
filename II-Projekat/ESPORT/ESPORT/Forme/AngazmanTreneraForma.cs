using System;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class AngazmanTreneraForma : Form
    {
        public AngazmanTreneraForma()
        {
            InitializeComponent();
            popuniPodatke();
        }

        private void popuniPodatke()
        {
            listViewAngazmani.Items.Clear();

            var angazmani =
                DTOManager.vratiSveAngazmaneTrenera();

            foreach (var a in angazmani)
            {
                ListViewItem item =
                    new ListViewItem(a.AngazmanTreneraId.ToString());

                item.SubItems.Add(a.Trener ?? "");
                item.SubItems.Add(a.Tim ?? "");
                item.SubItems.Add(a.TipUloge ?? "");

                item.SubItems.Add(
                    a.DatumOd.ToString("dd.MM.yyyy"));

                item.SubItems.Add(
                    a.DatumDo.HasValue
                        ? a.DatumDo.Value.ToString("dd.MM.yyyy")
                        : "");

                item.Tag = a.AngazmanTreneraId;

                listViewAngazmani.Items.Add(item);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajAngazmanTreneraForma forma =
                new DodajAngazmanTreneraForma();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodatke();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listViewAngazmani.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Izaberite angažman koji želite da izmenite.",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int angazmanId =
                (int)listViewAngazmani.SelectedItems[0].Tag;

            var angazman =
                DTOManager.vratiAngazmanTrenera(angazmanId);

            if (angazman == null)
                return;

            IzmeniAngazmanTreneraForma forma =
                new IzmeniAngazmanTreneraForma(angazman);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodatke();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewAngazmani.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Izaberite angažman koji želite da obrišete.",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int angazmanId =
                (int)listViewAngazmani.SelectedItems[0].Tag;

            DialogResult rezultat =
                MessageBox.Show(
                    "Da li ste sigurni da želite da obrišete izabrani angažman?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (rezultat != DialogResult.Yes)
                return;

            if (DTOManager.obrisiAngazmanTrenera(angazmanId))
            {
                MessageBox.Show(
                    "Angažman trenera je uspešno obrisan.",
                    "Uspešno",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                popuniPodatke();
            }
        }
    }
}