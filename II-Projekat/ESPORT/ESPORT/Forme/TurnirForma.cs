using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.TurnirDTO;

namespace ESPORT.Forme
{
    public partial class TurnirForma : Form
    {
        public TurnirForma()
        {
            InitializeComponent();
        }

        private void TurnirForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewTurniri.Items.Clear();

            List<TurnirPregled> podaci =
                DTOManager.vratiSveTurnire();

            foreach (TurnirPregled t in podaci)
            {
                ListViewItem item =
                    new ListViewItem(t.TakmicenjeId.ToString());

                item.SubItems.Add(t.NazivTakmicenja);
                item.SubItems.Add(t.Organizator);
                item.SubItems.Add(t.Igra);
                item.SubItems.Add(t.Region);
                item.SubItems.Add(t.Lokacija);
                item.SubItems.Add(t.FormatTakmicenja);
                item.SubItems.Add(
                    t.DatumPocetka.ToString("dd.MM.yyyy"));
                item.SubItems.Add(
                    t.DatumZavrsetka.ToString("dd.MM.yyyy"));
                item.SubItems.Add(t.NagradniFond.ToString());
                item.SubItems.Add(t.ValutaNagrade);
                item.SubItems.Add(t.Status);
                item.SubItems.Add(t.TipKostura);
                item.SubItems.Add(t.PravilaNapredovanja);
                item.SubItems.Add(t.BrojMecevaPoRundi);

                listViewTurniri.Items.Add(item);
            }

            listViewTurniri.Refresh();
        }

        private void dodajTurnirBtn_Click(object sender, EventArgs e)
        {
            DodajTurnirForma forma =
                new DodajTurnirForma();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void izmeniTurnirBtn_Click(object sender, EventArgs e)
        {
            if (listViewTurniri.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo vas da izaberete turnir koji želite da izmenite!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idTurnira =
                int.Parse(
                    listViewTurniri.SelectedItems[0]
                        .SubItems[0].Text);

            TurnirBasic odabraniTurnir =
                DTOManager.vratiTurnir(idTurnira);

            IzmeniTurnirForma forma =
                new IzmeniTurnirForma(odabraniTurnir);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void obrisiTurnirBtn_Click(object sender, EventArgs e)
        {
            if (listViewTurniri.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo vas da izaberete turnir koji želite da obrišete!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idTurnira =
                int.Parse(
                    listViewTurniri.SelectedItems[0]
                        .SubItems[0].Text);

            string nazivTurnira =
                listViewTurniri.SelectedItems[0]
                    .SubItems[1].Text;

            DialogResult result = MessageBox.Show(
                $"Da li ste sigurni da želite da obrišete turnir '{nazivTurnira}'?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiTurnir(idTurnira);

                MessageBox.Show(
                    "Turnir je uspešno obrisan!",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                popuniPodacima();
            }
        }

        private void fazeBtn_Click(object sender, EventArgs e)
        {
            FazaTakmicenjaForma forma =
                new FazaTakmicenjaForma();

            forma.ShowDialog();
        }
    }
}