using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ESPORT.IgracDTO;

namespace ESPORT.Forme
{
    public partial class IgracForma : Form
    {
        public IgracForma()
        {
            InitializeComponent();
        }

        private void IgracForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewIgraci.Items.Clear();

            List<IgracPregled> podaci = DTOManager.vratiSveIgrace();

            foreach (IgracPregled i in podaci)
            {
                ListViewItem item = new ListViewItem(i.OsobaId.ToString());
                item.SubItems.Add(i.Ime ?? "");
                item.SubItems.Add(i.Prezime ?? "");
                item.SubItems.Add(i.Nadimak ?? "");
                item.SubItems.Add(i.PrimarnaUloga ?? "");
                item.SubItems.Add(i.SekundarnaUloga ?? "");
                item.SubItems.Add(i.DominantniStil ?? "");
                item.SubItems.Add(i.Rang ?? "");
                item.SubItems.Add(i.TelefoniPrikaz ?? "");
                item.SubItems.Add(i.Drzava ?? "");
                item.SubItems.Add(i.Email ?? "");
                item.SubItems.Add(i.StatusAngazmana ?? "");

                listViewIgraci.Items.Add(item);
            }

            listViewIgraci.Refresh();
        }

        private void dodajigracabtn_Click(object sender, EventArgs e)
        {
            DodajIgracaForm form = new DodajIgracaForm();
            form.ShowDialog();
        }

        private void izmeniigracabtn_Click(object sender, EventArgs e)
        {
            if (listViewIgraci.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate prvo izabrati igrača iz liste da biste ga izmenili!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // Prekida metodu, forma za izmenu se NE otvara
            }

            // 2. Uzimanje ID-ja selektovanog igrača (prva kolona / SubItem[0])
            int idIgraca = int.Parse(listViewIgraci.SelectedItems[0].SubItems[0].Text);

            // 3. Učitavanje podataka i otvaranje forme
            IgracBasic odabraniIgrac = DTOManager.vratiIgraca(idIgraca);

            if (odabraniIgrac != null)
            {
                IzmeniIgracaForma forma = new IzmeniIgracaForma(odabraniIgrac);
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    popuniPodacima(); // Osvežava tabelu nakon uspešne izmene
                }
            }
        }

        private void obrisiigracabtn_Click(object sender, EventArgs e)
        {
            // 1. OGRANIČENJE: Provera da li je bar jedan igrač selektovan u ListView-u
            if (listViewIgraci.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo vas da izaberete igrača koga želite da obrišete!",
                                "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Preuzimanje ID-ja i nadimka selektovanog igrača iz tabele
            int idIgraca = int.Parse(listViewIgraci.SelectedItems[0].SubItems[0].Text);
            string nadimak = listViewIgraci.SelectedItems[0].SubItems[3].Text; // SubItems[3] pretpostavlja da je nadimak u 4. koloni

            // 3. Potvrda pre samog brisanja
            DialogResult potvrdio = MessageBox.Show($"Da li ste sigurni da želite da obrišete igrača '{nadimak}'?",
                                                      "Potvrda brisanja",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

            if (potvrdio == DialogResult.Yes)
            {
                // 4. Poziv DTOManager-a za brisanje iz baze
                DTOManager.obrisiIgraca(idIgraca);

                MessageBox.Show("Igrač je uspešno obrisan!", "Obaveštenje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5. Osvežavanje prikaza u ListView-u
                popuniPodacima();
            }
        }
    }
}
