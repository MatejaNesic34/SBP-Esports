using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.LigaDTO;

namespace ESPORT.Forme
{
    public partial class LigaForma : Form
    {
        public LigaForma()
        {
            InitializeComponent();
        }

        private void LigaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewLige.Items.Clear();

            List<LigaPregled> podaci =
                DTOManager.vratiSveLige();

            foreach (LigaPregled l in podaci)
            {
                ListViewItem item =
                    new ListViewItem(l.TakmicenjeId.ToString());

                item.SubItems.Add(l.NazivTakmicenja);
                item.SubItems.Add(l.Organizator);
                item.SubItems.Add(l.Igra);
                item.SubItems.Add(l.Region);
                item.SubItems.Add(l.Lokacija);
                item.SubItems.Add(l.FormatTakmicenja);
                item.SubItems.Add(l.DatumPocetka.ToString("dd.MM.yyyy"));
                item.SubItems.Add(l.DatumZavrsetka.ToString("dd.MM.yyyy"));
                item.SubItems.Add(l.NagradniFond.ToString());
                item.SubItems.Add(l.ValutaNagrade);
                item.SubItems.Add(l.Status);
                item.SubItems.Add(l.SistemBodovanja);

                listViewLige.Items.Add(item);
            }

            listViewLige.Refresh();
        }

        private void dodajLiguBtn_Click(object sender, EventArgs e)
        {
            DodajLiguForma forma =
                new DodajLiguForma();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void izmeniLiguBtn_Click(object sender, EventArgs e)
        {
            if (listViewLige.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo vas da izaberete ligu koju želite da izmenite!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idLige =
                int.Parse(
                    listViewLige.SelectedItems[0].SubItems[0].Text);

            LigaBasic odabranaLiga =
                DTOManager.vratiLigu(idLige);

            IzmeniLiguForma forma =
                new IzmeniLiguForma(odabranaLiga);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void obrisiLiguBtn_Click(object sender, EventArgs e)
        {
            if (listViewLige.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo vas da izaberete ligu koju želite da obrišete!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idLige =
                int.Parse(
                    listViewLige.SelectedItems[0].SubItems[0].Text);

            string nazivLige =
                listViewLige.SelectedItems[0].SubItems[1].Text;

            DialogResult result = MessageBox.Show(
                $"Da li ste sigurni da želite da obrišete ligu '{nazivLige}'?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiLigu(idLige);

                MessageBox.Show(
                    "Liga je uspešno obrisana!",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                popuniPodacima();
            }
        }
    }
}