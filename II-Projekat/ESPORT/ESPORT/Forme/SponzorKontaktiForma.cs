using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class SponzorKontaktiForma : Form
    {
        private int sponzorId;
        private string sponzorNaziv;

        public SponzorKontaktiForma(int idSponzora, string naziv)
        {
            InitializeComponent();
            sponzorId = idSponzora;
            sponzorNaziv = naziv;
            this.Text = $"Kontakti sponzora: {sponzorNaziv}";
        }

        private void SponzorKontaktiForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewKontakti.Items.Clear();
            SponzorDTO.SponzorBasic sponzor = DTOManager.vratiSponzora(sponzorId);

            if (sponzor != null && sponzor.Kontakti != null)
            {
                foreach (var k in sponzor.Kontakti)
                {
                    ListViewItem item = new ListViewItem(k.KontaktId.ToString());
                    item.SubItems.Add(k.Ime);
                    item.SubItems.Add(k.Prezime);
                    item.SubItems.Add(k.Telefon);
                    item.SubItems.Add(k.Email);
                    listViewKontakti.Items.Add(item);
                }
            }
        }

        private void btnDodajKontakt_Click(object sender, EventArgs e)
        {
            DodajSponzorKontaktForma forma = new DodajSponzorKontaktForma(sponzorId);
            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void btnIzmeniKontakt_Click(object sender, EventArgs e)
        {
            if (listViewKontakti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite kontakt koji želite da izmenite!");
                return;
            }

            int kontaktId = int.Parse(listViewKontakti.SelectedItems[0].SubItems[0].Text);
            IzmeniSponzorKontaktForma forma = new IzmeniSponzorKontaktForma(kontaktId);
            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void btnObrisiKontakt_Click(object sender, EventArgs e)
        {
            if (listViewKontakti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite kontakt koji želite da obrišete!");
                return;
            }

            int kontaktId = int.Parse(listViewKontakti.SelectedItems[0].SubItems[0].Text);
            if (MessageBox.Show("Da li ste sigurni?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DTOManager.obrisiSponzorKontakt(kontaktId);
                popuniPodacima();
            }
        }
    }
}