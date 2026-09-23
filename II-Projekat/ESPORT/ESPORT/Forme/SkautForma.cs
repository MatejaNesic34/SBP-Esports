using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class SkautForma : Form
    {
        public SkautForma()
        {
            InitializeComponent();
        }

        private void SkautForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        private void popuniPodacima()
        {
            listViewskaut.Items.Clear();

            List<SkautPregled> skauti = DTOManager.vratiSveSkaute()
                                                  .OrderBy(s => s.OsobaId)
                                                  .ToList();

            foreach (var s in skauti)
            {
                ListViewItem item = new ListViewItem(s.OsobaId.ToString());
                item.SubItems.Add(s.Ime ?? "");
                item.SubItems.Add(s.Prezime ?? "");
                item.SubItems.Add(s.DatumRodjenja?.ToString("dd.MM.yyyy.") ?? "");
                item.SubItems.Add(s.Drzava ?? "");
                item.SubItems.Add(s.Email ?? "");
                item.SubItems.Add(s.StatusAngazmana ?? "");
                item.SubItems.Add(s.DatumPrvogAngazovanja?.ToString("dd.MM.yyyy.") ?? "");
                item.SubItems.Add(s.NazivIgre ?? "");


                listViewskaut.Items.Add(item);
            }

            listViewskaut.Refresh();
        }

        private void btndodajskauta_Click(object sender, EventArgs e)
        {
            DodajSkautaForma form = new DodajSkautaForma();
            if (form.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void btnizmeniskauta_Click(object sender, EventArgs e)
        {
            if (listViewskaut.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate prvo izabrati skauta iz liste da biste ga izmenili!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; 
            }

            int idSkauta = int.Parse(listViewskaut.SelectedItems[0].SubItems[0].Text);

            SkautBasic odabraniSkaut = DTOManager.vratiSkauta(idSkauta);

            if (odabraniSkaut != null)
            {
                IzmeniSkautaForma forma = new IzmeniSkautaForma(odabraniSkaut);
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    popuniPodacima();
                }
            }
        }

        private void btnobrisiskauta_Click(object sender, EventArgs e)
        {
            if (listViewskaut.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate prvo izabrati skauta iz liste za brisanje!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int idSkauta = int.Parse(listViewskaut.SelectedItems[0].SubItems[0].Text);
            string imeIPrezime = $"{listViewskaut.SelectedItems[0].SubItems[1].Text} {listViewskaut.SelectedItems[0].SubItems[2].Text}";

            DialogResult result = MessageBox.Show($"Da li ste sigurni da želite da obrišete skauta {imeIPrezime}?",
                                                  "Potvrda brisanja",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiSkauta(idSkauta);
                popuniPodacima();
            }
        }
    }
}
