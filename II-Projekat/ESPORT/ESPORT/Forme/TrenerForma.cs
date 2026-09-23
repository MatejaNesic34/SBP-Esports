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
                item.SubItems.Add(t.Ime ?? "");
                item.SubItems.Add(t.Prezime ?? "");
                item.SubItems.Add(t.DatumRodjenja?.ToString("dd.MM.yyyy.") ?? "");
                item.SubItems.Add(t.DatumPrvogAngazovanja?.ToString("dd.MM.yyyy.") ?? "");
                item.SubItems.Add(t.Drzava ?? "");
                item.SubItems.Add(t.Email ?? "");
                item.SubItems.Add(t.StatusAngazmana ?? "");
                item.SubItems.Add(t.TipUloge ?? "");
                item.SubItems.Add(t.StilRada ?? "");
                //item.SubItems.Add(t.Telefoni.Count > 0 ? string.Join(", ", t.Telefoni) : ""); 

                listViewTreneri.Items.Add(item);
            }
        }

        private void dodajtrenerabtn_Click(object sender, EventArgs e)
        {
            DodajTreneraForma form = new DodajTreneraForma();
            if (form.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void izmenitrenerabtn_Click(object sender, EventArgs e)
        {
            if (listViewTreneri.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate prvo izabrati trenera iz liste da biste ga izmenili!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; 
            }

            int idTrenera = int.Parse(listViewTreneri.SelectedItems[0].SubItems[0].Text);

            TrenerBasic odabraniTrener = DTOManager.vratiTrenera(idTrenera);

            if (odabraniTrener != null)
            {
                IzmeniTreneraForm forma = new IzmeniTreneraForm(odabraniTrener);
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    popuniPodacima(); 
                }
            }
        }

        private void obrisitrenerabtn_Click(object sender, EventArgs e)
        {
            if (listViewTreneri.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate prvo izabrati trenera iz liste za brisanje!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int idTrenera = int.Parse(listViewTreneri.SelectedItems[0].SubItems[0].Text);
            string imeIPrezime = $"{listViewTreneri.SelectedItems[0].SubItems[1].Text} {listViewTreneri.SelectedItems[0].SubItems[2].Text}";

            DialogResult result = MessageBox.Show($"Da li ste sigurni da želite da obrišete trenera {imeIPrezime}?",
                                                  "Potvrda brisanja",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiTrenera(idTrenera);
                popuniPodacima(); 
            }
        }
    }
}
