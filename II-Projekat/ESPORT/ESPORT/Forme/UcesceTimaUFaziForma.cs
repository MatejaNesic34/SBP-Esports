using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.UcesceTimaUFaziDTO;

namespace ESPORT.Forme
{
    public partial class UcesceTimaUFaziForma : Form
    {
        public UcesceTimaUFaziForma()
        {
            InitializeComponent();
        }

        private void UcesceTimaUFaziForma_Load(
            object sender,
            EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewUcesca.Items.Clear();

            List<UcescePregled> podaci =
                DTOManager.vratiSvaUcesca();

            foreach (UcescePregled u in podaci)
            {
                ListViewItem item =
                    new ListViewItem(
                        u.FazaId.ToString());

                item.SubItems.Add(
                    u.TimId.ToString());

                item.SubItems.Add(
                    u.NazivFaze);

                item.SubItems.Add(
                    u.NazivTima);

                item.SubItems.Add(
                    u.Status);

                item.SubItems.Add(
                    u.OstvareniRezultat);

                item.SubItems.Add(
                    u.BrojPobeda.ToString());

                item.SubItems.Add(
                    u.BrojPoraza.ToString());

                item.SubItems.Add(
                    u.OsvojeniBodovi.ToString());

                item.SubItems.Add(
                    u.KonacanPlasman.HasValue
                        ? u.KonacanPlasman.Value.ToString()
                        : "");

                listViewUcesca.Items.Add(item);
            }

            listViewUcesca.Refresh();
        }

        private void dodajUcesceBtn_Click(
            object sender,
            EventArgs e)
        {
            DodajUcesceForma forma =
                new DodajUcesceForma();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void izmeniUcesceBtn_Click(
            object sender,
            EventArgs e)
        {
            if (listViewUcesca.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo vas da izaberete učešće koje želite da izmenite!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int fazaId =
                int.Parse(
                    listViewUcesca.SelectedItems[0]
                        .SubItems[0].Text);

            int timId =
                int.Parse(
                    listViewUcesca.SelectedItems[0]
                        .SubItems[1].Text);

            UcesceBasic odabranoUcesce =
                DTOManager.vratiUcesce(
                    fazaId,
                    timId);

            if (odabranoUcesce == null)
                return;

            IzmeniUcesceForma forma =
                new IzmeniUcesceForma(
                    odabranoUcesce);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void obrisiUcesceBtn_Click(
            object sender,
            EventArgs e)
        {
            if (listViewUcesca.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo vas da izaberete učešće koje želite da obrišete!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int fazaId =
                int.Parse(
                    listViewUcesca.SelectedItems[0]
                        .SubItems[0].Text);

            int timId =
                int.Parse(
                    listViewUcesca.SelectedItems[0]
                        .SubItems[1].Text);

            DialogResult rezultat =
                MessageBox.Show(
                    "Da li ste sigurni da želite da obrišete izabrano učešće?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (rezultat != DialogResult.Yes)
                return;

            bool uspesno =
                DTOManager.obrisiUcesce(
                    fazaId,
                    timId);

            if (uspesno)
            {
                MessageBox.Show(
                    "Učešće je uspešno obrisano!",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                popuniPodacima();
            }
        }
    }
}