using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.FazaTakmicenjaDTO;

namespace ESPORT.Forme
{
    public partial class FazaTakmicenjaForma : Form
    {
        public FazaTakmicenjaForma()
        {
            InitializeComponent();
        }

        private void FazaTakmicenjaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewFaze.Items.Clear();

            List<FazaTakmicenjaPregled> podaci =
                DTOManager.vratiSveFaze();

            foreach (FazaTakmicenjaPregled f in podaci)
            {
                ListViewItem item =
                    new ListViewItem(f.FazaId.ToString());

                item.SubItems.Add(f.TakmicenjeId.ToString());
                item.SubItems.Add(f.NazivTakmicenja);
                item.SubItems.Add(f.NazivFaze);
                item.SubItems.Add(f.RedniBroj.ToString());

                item.SubItems.Add(
                    f.NadfazaId.HasValue
                        ? f.NadfazaId.Value.ToString()
                        : "");

                listViewFaze.Items.Add(item);
            }

            listViewFaze.Refresh();
        }

        private void dodajFazuBtn_Click(object sender, EventArgs e)
        {
            DodajFazuForma forma =
                new DodajFazuForma();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void izmeniFazuBtn_Click(object sender, EventArgs e)
        {
            if (listViewFaze.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo vas da izaberete fazu koju želite da izmenite!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idFaze =
                int.Parse(
                    listViewFaze.SelectedItems[0]
                        .SubItems[0].Text);

            FazaTakmicenjaBasic odabranaFaza =
                DTOManager.vratiFazu(idFaze);

            if (odabranaFaza == null)
                return;

            IzmeniFazuForma forma =
                new IzmeniFazuForma(odabranaFaza);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void obrisiFazuBtn_Click(object sender, EventArgs e)
        {
            if (listViewFaze.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo vas da izaberete fazu koju želite da obrišete!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idFaze =
                int.Parse(
                    listViewFaze.SelectedItems[0]
                        .SubItems[0].Text);

            string nazivFaze =
                listViewFaze.SelectedItems[0]
                    .SubItems[3].Text;

            DialogResult result = MessageBox.Show(
                $"Da li ste sigurni da želite da obrišete fazu '{nazivFaze}'?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool uspesno =
                    DTOManager.obrisiFazu(idFaze);

                if (uspesno)
                {
                    MessageBox.Show(
                        "Faza je uspešno obrisana!",
                        "Obaveštenje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    popuniPodacima();
                }
            }
        }

        private void ucescaBtn_Click(object sender, EventArgs e)
        {
            UcesceTimaUFaziForma forma =
                new UcesceTimaUFaziForma();

            forma.ShowDialog();
        }
    }
}