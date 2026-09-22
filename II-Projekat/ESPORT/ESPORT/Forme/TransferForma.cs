using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.TransferDTO;

namespace ESPORT.Forme
{
    public partial class TransferForma : Form
    {
        public TransferForma()
        {
            InitializeComponent();
        }

        private void TransferForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewTransferi.Items.Clear();

            List<TransferPregled> podaci =
                DTOManager.vratiSveTransfere();

            foreach (TransferPregled t in podaci)
            {
                ListViewItem item =
                    new ListViewItem(t.TransferId.ToString());

                item.SubItems.Add(t.IgracId.ToString());
                item.SubItems.Add(t.Igrac);

                item.SubItems.Add(
                    t.PrethodniTimId.HasValue
                        ? t.PrethodniTimId.Value.ToString()
                        : "");

                item.SubItems.Add(t.PrethodniTim);

                item.SubItems.Add(t.NoviTimId.ToString());
                item.SubItems.Add(t.NoviTim);

                item.SubItems.Add(
                    t.DatumPrelaska.ToString("dd.MM.yyyy"));

                item.SubItems.Add(
                    t.IznosTransfera.ToString());

                item.SubItems.Add(t.Valuta);

                item.SubItems.Add(
                    t.TrajanjeUgovoraMeseci.HasValue
                        ? t.TrajanjeUgovoraMeseci.Value.ToString()
                        : "");

                item.SubItems.Add(t.PosebneKlauzule);

                listViewTransferi.Items.Add(item);
            }

            listViewTransferi.Refresh();
        }

        private void dodajTransferBtn_Click(object sender, EventArgs e)
        {
            DodajTransferForma forma =
                new DodajTransferForma();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void izmeniTransferBtn_Click(object sender, EventArgs e)
        {
            if (listViewTransferi.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo vas da izaberete transfer koji želite da izmenite!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idTransfera =
                int.Parse(
                    listViewTransferi.SelectedItems[0]
                        .SubItems[0].Text);

            TransferBasic odabraniTransfer =
                DTOManager.vratiTransfer(idTransfera);

            if (odabraniTransfer == null)
                return;

            IzmeniTransferForma forma =
                new IzmeniTransferForma(odabraniTransfer);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void obrisiTransferBtn_Click(object sender, EventArgs e)
        {
            if (listViewTransferi.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo vas da izaberete transfer koji želite da obrišete!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idTransfera =
                int.Parse(
                    listViewTransferi.SelectedItems[0]
                        .SubItems[0].Text);

            DialogResult rezultat =
                MessageBox.Show(
                    "Da li ste sigurni da želite da obrišete izabrani transfer?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (rezultat != DialogResult.Yes)
                return;

            bool uspesno =
                DTOManager.obrisiTransfer(idTransfera);

            if (uspesno)
            {
                MessageBox.Show(
                    "Transfer je uspešno obrisan!",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                popuniPodacima();
            }
        }
    }
}