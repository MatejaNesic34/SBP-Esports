using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.IgracDTO;
using static ESPORT.OsobaDTO;

namespace ESPORT.Forme
{
    public partial class AngazmanZaposlenihForma : Form
    {
        public AngazmanZaposlenihForma()
        {
            InitializeComponent();
        }

        private void AngazmanZaposlenihForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewAngazmaniZaposlenih.Items.Clear();

            List<AngazmanZaposlenihDTO.AngazmanZaposlenihPregled> podaci =
                DTOManager.vratiSveAngazmaneZaposlenih();

            foreach (AngazmanZaposlenihDTO.AngazmanZaposlenihPregled a in podaci)
            {
                ListViewItem item = new ListViewItem(
                    a.AngazmanOsobljaId.ToString());

                item.SubItems.Add(a.Osoba);
                item.SubItems.Add(a.Tim);
                item.SubItems.Add(a.NazivUloge);
                item.SubItems.Add(a.DatumOd.ToString("dd.MM.yyyy"));
                item.SubItems.Add(
                    a.DatumDo.HasValue
                        ? a.DatumDo.Value.ToString("dd.MM.yyyy")
                        : "");

                item.SubItems.Add(
                    a.Plata.HasValue
                        ? a.Plata.Value.ToString("0.00")
                        : "");

                listViewAngazmaniZaposlenih.Items.Add(item);
            }

            listViewAngazmaniZaposlenih.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajAngazmanZaposlenihForma forma =
                new DodajAngazmanZaposlenihForma();

            forma.ShowDialog();

            popuniPodacima();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listViewAngazmaniZaposlenih.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite angažman koji želite da izmenite.");
                return;
            }

            int id = int.Parse(
                listViewAngazmaniZaposlenih.SelectedItems[0].Text);

            IzmeniAngazmanZaposlenihForma forma =
                new IzmeniAngazmanZaposlenihForma(id);

            forma.ShowDialog();

            popuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewAngazmaniZaposlenih.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite angažman koji želite da obrišete.");
                return;
            }

            int id = int.Parse(
                listViewAngazmaniZaposlenih.SelectedItems[0].Text);

            DialogResult rezultat = MessageBox.Show(
                "Da li ste sigurni da želite da obrišete izabrani angažman?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rezultat != DialogResult.Yes)
                return;

            bool uspesno = DTOManager.obrisiAngazmanZaposlenih(id);

            if (uspesno)
            {
                MessageBox.Show(
                    "Angažman zaposlenog je uspešno obrisan.",
                    "Uspeh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                popuniPodacima();
            }
        }
    }
}