using System;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class IndividualniRezultatForma : Form
    {
        public IndividualniRezultatForma()
        {
            InitializeComponent();
            popuniPodatke();
        }

        private void popuniPodatke()
        {
            listViewRezultati.Items.Clear();

            var rezultati =
                DTOManager.vratiSveIndividualneRezultate();

            foreach (var r in rezultati)
            {
                ListViewItem item =
                    new ListViewItem(r.RezultatId.ToString());

                item.SubItems.Add(r.Igrac);
                item.SubItems.Add(r.NazivPriznanja);

                item.SubItems.Add(
                    r.DatumOstvarivanja.HasValue
                        ? r.DatumOstvarivanja.Value.ToString("dd.MM.yyyy")
                        : "");

                item.SubItems.Add(
                    string.IsNullOrEmpty(r.Takmicenje)
                        ? ""
                        : r.Takmicenje);

                item.SubItems.Add(r.Opis);

                item.Tag = r.RezultatId;

                listViewRezultati.Items.Add(item);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajIndividualniForma forma =
                new DodajIndividualniForma();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodatke();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listViewRezultati.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Izaberite rezultat koji želite da izmenite.",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int rezultatId =
                (int)listViewRezultati.SelectedItems[0].Tag;

            var rezultat =
                DTOManager.vratiIndividualniRezultat(rezultatId);

            if (rezultat == null)
                return;

            IzmeniIndividualniForma forma =
                new IzmeniIndividualniForma(rezultat);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodatke();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewRezultati.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Izaberite rezultat koji želite da obrišete.",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int rezultatId =
                (int)listViewRezultati.SelectedItems[0].Tag;

            DialogResult rezultat =
                MessageBox.Show(
                    "Da li ste sigurni da želite da obrišete izabrani rezultat?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (rezultat != DialogResult.Yes)
                return;

            if (DTOManager.obrisiIndividualniRezultat(rezultatId))
            {
                MessageBox.Show(
                    "Individualni rezultat je uspešno obrisan.",
                    "Uspešno",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                popuniPodatke();
            }
        }
    }
}