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

        private void popuniPodacima()
        {
            listViewIgre.Items.Clear();
            List<IgraPregled> podaci = DTOManager.vratiSveIgre();

            foreach (IgraPregled i in podaci)
            {
                ListViewItem item = new ListViewItem(i.IgraId.ToString());
                item.SubItems.Add(i.Naziv ?? "");
                item.SubItems.Add(i.Zanr ?? "");

                listViewIgre.Items.Add(item);
            }

            listViewIgre.Refresh();
        }

        private void dodajigrubtn_Click(object sender, EventArgs e)
        {
            DodajIgreForma forma = new DodajIgreForma();
            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima(); 
            }
        }

        private void izmeniigrubtn_Click(object sender, EventArgs e)
        {
            if (listViewIgre.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate prvo izabrati igru iz liste da biste je izmenili!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; 
            }

            int idIgre = int.Parse(listViewIgre.SelectedItems[0].SubItems[0].Text);

            IgraBasic odabranaIgra = DTOManager.vratiIgru(idIgre);

            if (odabranaIgra != null)
            {
                IzmeniIgruForma forma = new IzmeniIgruForma(odabranaIgra);
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    popuniPodacima(); 
                }
            }
        }

        private void obrisiigrubtn_Click(object sender, EventArgs e)
        {
            if (listViewIgre.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate prvo izabrati igru iz liste za brisanje!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int idIgre = int.Parse(listViewIgre.SelectedItems[0].SubItems[0].Text);
            string nazivIgre = listViewIgre.SelectedItems[0].SubItems[1].Text;

            DialogResult result = MessageBox.Show($"Da li ste sigurni da želite da obrišete igru '{nazivIgre}'?",
                                                  "Potvrda brisanja",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiIgru(idIgre);
                popuniPodacima(); 
            }
        }
    }
}