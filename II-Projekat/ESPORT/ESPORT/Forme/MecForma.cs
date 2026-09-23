using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.MecDTO;

namespace ESPORT.Forme
{
    public partial class MecForma : Form
    {
        public MecForma()
        {
            InitializeComponent();
        }

        private void MecForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewMecevi.Items.Clear();

            List<MecPregled> podaci =
                DTOManager.vratiSveMeceve();

            foreach (MecPregled m in podaci)
            {
                ListViewItem item =
                    new ListViewItem(m.MecId.ToString());

                item.SubItems.Add(m.TakmicenjeId.ToString());
                item.SubItems.Add(m.NazivTakmicenja);
                item.SubItems.Add(m.RedniBroj.ToString());
                item.SubItems.Add(
                    m.DatumVremePocetka.ToString("dd.MM.yyyy HH:mm"));
                item.SubItems.Add(m.FormatMeca);
                item.SubItems.Add(m.BrojOdigranihMapa.ToString());
                item.SubItems.Add(m.Rezultat);
                item.SubItems.Add(
                    m.Trajanje.HasValue
                        ? m.Trajanje.Value.ToString()
                        : "");
                item.SubItems.Add(m.LokacijaIgranja);
                item.SubItems.Add(m.Sudije);
                item.SubItems.Add(m.StatusMeca);

                listViewMecevi.Items.Add(item);
            }

            listViewMecevi.Refresh();
        }

        private void dodajMecBtn_Click(object sender, EventArgs e)
        {
            DodajMecForma forma =
                new DodajMecForma();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void izmeniMecBtn_Click(object sender, EventArgs e)
        {
            if (listViewMecevi.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo vas da izaberete meč koji želite da izmenite!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idMeca =
                int.Parse(
                    listViewMecevi.SelectedItems[0]
                        .SubItems[0].Text);

            MecBasic odabraniMec =
                DTOManager.vratiMec(idMeca);

            if (odabraniMec == null)
                return;

            IzmeniMecForma forma =
                new IzmeniMecForma(odabraniMec);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void obrisiMecBtn_Click(object sender, EventArgs e)
        {
            if (listViewMecevi.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo vas da izaberete meč koji želite da obrišete!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idMeca =
                int.Parse(
                    listViewMecevi.SelectedItems[0]
                        .SubItems[0].Text);

            DialogResult rezultat =
                MessageBox.Show(
                    "Da li ste sigurni da želite da obrišete izabrani meč?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (rezultat != DialogResult.Yes)
                return;

            bool uspesno =
                DTOManager.obrisiMec(idMeca);

            if (uspesno)
            {
                MessageBox.Show(
                    "Meč je uspešno obrisan!",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                popuniPodacima();
            }
        }

        private void dogadjajiBtn_Click(object sender, EventArgs e)
        {
            DogadjajNaMecuForma forma =
                new DogadjajNaMecuForma();

            forma.ShowDialog();
        }

        private void statistikaBtn_Click(object sender, EventArgs e)
        {
            StatistikaForma forma =
                new StatistikaForma();

            forma.ShowDialog();
        }
    }
}