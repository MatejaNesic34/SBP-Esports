using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ESPORT.IgraDTO;

namespace ESPORT.Forme
{
    public partial class IgreForma : Form
    {
        public IgreForma()
        {
            InitializeComponent();
        }

        private void IgreForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            // Očisti prethodne stavke iz ListView kontrole
            listViewIgre.Items.Clear();

            // Učitavanje liste iz baze preko DTOManager-a
            List<IgraPregled> podaci = DTOManager.vratiSveIgre();

            foreach (IgraPregled i in podaci)
            {
                // Kreiramo stavku sa prvom kolonom (ID)
                ListViewItem item = new ListViewItem(i.IgraId.ToString());

                // Dodajemo ostale kolone
                item.SubItems.Add(i.Naziv);
                item.SubItems.Add(i.Zanr);

                // Ubacujemo red u ListView
                listViewIgre.Items.Add(item);
            }

            listViewIgre.Refresh();
        }

        private void dodajigrubtn_Click(object sender, EventArgs e)
        {
            DodajIgreForma forma = new DodajIgreForma();
            forma.ShowDialog();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void obrisiigrubtn_Click(object sender, EventArgs e)
        {
            // Provera da li je korisnik izabrao red u ListView-u
            if (listViewIgre.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo vas da izaberete igru koju želite da obrišete!",
                                "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Uzimamo ID izabranog reda (prva kolona u ListView-u)
            int idIgre = int.Parse(listViewIgre.SelectedItems[0].SubItems[0].Text);
            string nazivIgre = listViewIgre.SelectedItems[0].SubItems[1].Text;

            // Potvrda pre brisanja
            DialogResult result = MessageBox.Show($"Da li ste sigurni da želite da obrišete igru '{nazivIgre}'?",
                                                  "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Poziv DTOManager-a za brisanje
                DTOManager.obrisiIgru(idIgre);

                MessageBox.Show("Igra je uspešno obrisana!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Osvežavamo prikaz u ListView-u
                popuniPodacima();
            }
        }

        private void izmeniigrubtn_Click(object sender, EventArgs e)
        {
            if (listViewIgre.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo vas da izaberete igru koju želite da izmenite!",
                                "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Očitavanje podataka iz selektovanog reda
            int idIgre = int.Parse(listViewIgre.SelectedItems[0].SubItems[0].Text);
            string naziv = listViewIgre.SelectedItems[0].SubItems[1].Text;
            string zanr = listViewIgre.SelectedItems[0].SubItems[2].Text;

            IgraBasic odabranaIgra = new IgraBasic
            {
                IgraId = idIgre,
                Naziv = naziv,
                Zanr = zanr
            };

            // Otvaranje forme za izmenu i prosleđivanje selektovanih podataka
            IzmeniIgruForma forma = new IzmeniIgruForma(odabranaIgra);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                // Osvežavanje prikazanih podataka nakon izmene
                popuniPodacima();
            }
        }
    }
}
