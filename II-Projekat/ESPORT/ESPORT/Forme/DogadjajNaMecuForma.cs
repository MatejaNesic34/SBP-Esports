using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.DogadjajNaMecuDTO;

namespace ESPORT.Forme
{
    public partial class DogadjajNaMecuForma : Form
    {
        public DogadjajNaMecuForma()
        {
            InitializeComponent();
        }

        private void DogadjajNaMecuForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewDogadjaji.Items.Clear();

            List<DogadjajNaMecuPregled> podaci =
                DTOManager.vratiSveDogadjajeNaMecu();

            foreach (DogadjajNaMecuPregled d in podaci)
            {
                ListViewItem item =
                    new ListViewItem(d.DogadjajId.ToString());

                item.SubItems.Add(d.MecId.ToString());
                item.SubItems.Add(d.RedniBrojMeca.ToString());
                item.SubItems.Add(d.TipDogadjaja);
                item.SubItems.Add(
                    d.VremeDogadjaja.ToString("dd.MM.yyyy HH:mm"));
                item.SubItems.Add(d.Opis);
                item.SubItems.Add(d.OdlukaSudije);

                listViewDogadjaji.Items.Add(item);
            }

            listViewDogadjaji.Refresh();
        }

        private void dodajDogadjajBtn_Click(object sender, EventArgs e)
        {
            DodajDogadjajForma forma =
                new DodajDogadjajForma();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void izmeniDogadjajBtn_Click(object sender, EventArgs e)
        {
            if (listViewDogadjaji.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo vas da izaberete događaj koji želite da izmenite!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idDogadjaja =
                int.Parse(
                    listViewDogadjaji.SelectedItems[0]
                        .SubItems[0].Text);

            DogadjajNaMecuBasic odabraniDogadjaj =
                DTOManager.vratiDogadjajNaMecu(idDogadjaja);

            if (odabraniDogadjaj == null)
                return;

            IzmeniDogadjajForma forma =
                new IzmeniDogadjajForma(odabraniDogadjaj);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void obrisiDogadjajBtn_Click(object sender, EventArgs e)
        {
            if (listViewDogadjaji.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo vas da izaberete događaj koji želite da obrišete!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idDogadjaja =
                int.Parse(
                    listViewDogadjaji.SelectedItems[0]
                        .SubItems[0].Text);

            DialogResult rezultat =
                MessageBox.Show(
                    "Da li ste sigurni da želite da obrišete izabrani događaj?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (rezultat != DialogResult.Yes)
                return;

            bool uspesno =
                DTOManager.obrisiDogadjajNaMecu(idDogadjaja);

            if (uspesno)
            {
                MessageBox.Show(
                    "Događaj je uspešno obrisan!",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                popuniPodacima();
            }
        }
    }
}