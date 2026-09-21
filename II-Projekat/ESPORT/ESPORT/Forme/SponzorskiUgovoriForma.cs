using System;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class SponzorskiUgovoriForma : Form
    {
        private int sponzorId;
        private string sponzorNaziv;

        public SponzorskiUgovoriForma(int idSponzora, string naziv)
        {
            InitializeComponent();
            sponzorId = idSponzora;
            sponzorNaziv = naziv;
            this.Text = $"Sponzorski ugovori: {sponzorNaziv}";
        }

        private void SponzorskiUgovoriForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewUgovori.Items.Clear();
            SponzorDTO.SponzorBasic sponzor = DTOManager.vratiSponzora(sponzorId);

            if (sponzor != null && sponzor.Ugovori != null)
            {
                foreach (var u in sponzor.Ugovori)
                {
                    ListViewItem item = new ListViewItem(u.UgovorId.ToString());
                    item.SubItems.Add(u.DatumOd.ToString("dd.MM.yyyy"));
                    item.SubItems.Add(u.DatumDo.ToString("dd.MM.yyyy"));
                    item.SubItems.Add(u.Iznos.ToString());
                    item.SubItems.Add(u.Valuta);
                    item.SubItems.Add(u.TipPodrske);
                    item.SubItems.Add(u.MarketinskeObaveze);
                    listViewUgovori.Items.Add(item);
                }
            }
        }

        private void btnDodajUgovor_Click(object sender, EventArgs e)
        {
            DodajSponzorskiUgovorForma forma = new DodajSponzorskiUgovorForma(sponzorId);
            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void btnIzmeniUgovor_Click(object sender, EventArgs e)
        {
            if (listViewUgovori.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite ugovor koji želite da izmenite!");
                return;
            }

            int ugovorId = int.Parse(listViewUgovori.SelectedItems[0].SubItems[0].Text);
            IzmeniSponzorskiUgovorForma forma = new IzmeniSponzorskiUgovorForma(ugovorId);
            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void btnObrisiUgovor_Click(object sender, EventArgs e)
        {
            if (listViewUgovori.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite ugovor koji želite da obrišete!");
                return;
            }

            int ugovorId = int.Parse(listViewUgovori.SelectedItems[0].SubItems[0].Text);
            if (MessageBox.Show("Da li ste sigurni?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DTOManager.obrisiSponzorskiUgovor(ugovorId);
                popuniPodacima();
            }
        }
    }
}