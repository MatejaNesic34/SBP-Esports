using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ESPORT.IgracDTO.TrenerDTO;

namespace ESPORT.Forme
{
    public partial class TrenerForma : Form
    {
        public TrenerForma()
        {
            InitializeComponent();
        }

        private void TrenerForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listViewTreneri.Items.Clear();
            List<TrenerPregled> treneri = DTOManager.vratiSveTrenere();

            foreach (var t in treneri)
            {
                ListViewItem item = new ListViewItem(t.OsobaId.ToString());
                item.SubItems.Add(t.Ime);
                item.SubItems.Add(t.Prezime);
                item.SubItems.Add(t.TipUloge);
                item.SubItems.Add(t.StilRada);
                item.SubItems.Add(t.StatusAngazmana);

                listViewTreneri.Items.Add(item);
            }
        }

        private void dodajtrenerabtn_Click(object sender, EventArgs e)
        {
            DodajTreneraForma form = new DodajTreneraForma();
            form.ShowDialog();
        }

        private void izmenitrenerabtn_Click(object sender, EventArgs e)
        {
            if (listViewTreneri.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate prvo izabrati trenera iz liste da biste ga izmenili!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // Prekida metodu, forma za izmenu se NE otvara
            }

            // 2. Uzimanje ID-ja selektovanog trenera (prva kolona / SubItem[0])
            int idTrenera = int.Parse(listViewTreneri.SelectedItems[0].SubItems[0].Text);

            // 3. Učitavanje podataka i otvaranje forme
            TrenerBasic odabraniTrener = DTOManager.vratiTrenera(idTrenera);

            if (odabraniTrener != null)
            {
                IzmeniTreneraForm forma = new IzmeniTreneraForm(odabraniTrener);
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    popuniPodacima(); // Osvežava tabelu nakon uspešne izmene
                }
            }
        }
    }
}
