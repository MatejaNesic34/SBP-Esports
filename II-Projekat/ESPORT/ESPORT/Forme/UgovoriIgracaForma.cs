using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class UgovoriIgracaForma : Form
    {
        private int? filtriranIgracId = null;

        public UgovoriIgracaForma()
        {
            InitializeComponent();
        }

        public UgovoriIgracaForma(int igracId, string nazivIgraca)
        {
            InitializeComponent();
            filtriranIgracId = igracId;
            this.Text = $"Ugovori igrača: {nazivIgraca}";
        }

        private void UgovoriIgracaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewUgovori.Items.Clear();
            List<UgovorDTO.UgovorIgracaBasic> podaci = DTOManager.vratiSveUgovoreIgraca();

            // ISPRAVKA: Filtriramo podatke ukoliko je prosleđen ID igrača sa forme igrača
            if (filtriranIgracId.HasValue)
            {
                podaci = podaci.Where(u => u.IgracId == filtriranIgracId.Value).ToList();
            }

            foreach (var u in podaci)
            {
                ListViewItem item = new ListViewItem(u.UgovorId.ToString());
                item.SubItems.Add(u.ImePrezimeIgraca);
                item.SubItems.Add(u.NazivTima);
                item.SubItems.Add(u.DatumOd.ToString("dd.MM.yyyy"));
                item.SubItems.Add(u.DatumDo.HasValue ? u.DatumDo.Value.ToString("dd.MM.yyyy") : "Važeći");
                item.SubItems.Add(u.TipUgovora);
                item.SubItems.Add(u.Plata.ToString());
                item.SubItems.Add(u.StatusIgraca);
                listViewUgovori.Items.Add(item);
            }
        }

        private void btnDodajUgovor_Click(object sender, EventArgs e)
        {
            DodajUgovorIgracaForma forma = new DodajUgovorIgracaForma();
            if (forma.ShowDialog() == DialogResult.OK) popuniPodacima();
        }

        private void btnIzmeniUgovor_Click(object sender, EventArgs e)
        {
            if (listViewUgovori.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite ugovor koji želite da izmenite!");
                return;
            }

            int id = int.Parse(listViewUgovori.SelectedItems[0].SubItems[0].Text);
            IzmeniUgovorIgracaForma forma = new IzmeniUgovorIgracaForma(id);
            if (forma.ShowDialog() == DialogResult.OK) popuniPodacima();
        }

        private void btnObrisiUgovor_Click(object sender, EventArgs e)
        {
            if (listViewUgovori.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite ugovor koji želite da obrišete!");
                return;
            }

            int id = int.Parse(listViewUgovori.SelectedItems[0].SubItems[0].Text);
            if (MessageBox.Show("Da li ste sigurni?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DTOManager.obrisiUgovorIgraca(id);
                popuniPodacima();
            }
        }
    }
}