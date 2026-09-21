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
    public partial class SponzoriForma : Form
    {
        public SponzoriForma()
        {
            InitializeComponent();
        }

        private void SponzoriForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewSponzori.Items.Clear();

            List<SponzorDTO.Sponzor> podaci = DTOManager.vratiSveSponzore();

            foreach (SponzorDTO.Sponzor sp in podaci)
            {
                ListViewItem item = new ListViewItem(sp.SponzorId.ToString());

                item.SubItems.Add(sp.Naziv);
                item.SubItems.Add(sp.Drzava);
                item.SubItems.Add(sp.TipSponzora);
                item.SubItems.Add(sp.OblastPoslovanja);

                listViewSponzori.Items.Add(item);
            }

            listViewSponzori.Refresh();
        }

        private void dodajSponzorbtn_Click(object sender, EventArgs e)
        {
            DodajSponzoraForma forma = new DodajSponzoraForma();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void izmeniSponzorbtn_Click(object sender, EventArgs e)
        {
            if (listViewSponzori.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo vas da izaberete sponzora kojeg želite da izmenite!",
                                "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSponzora = int.Parse(listViewSponzori.SelectedItems[0].SubItems[0].Text);

            IzmeniSponzoraForma forma = new IzmeniSponzoraForma(idSponzora);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void obrisiSponzorbtn_Click(object sender, EventArgs e)
        {
            if (listViewSponzori.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo vas da izaberete sponzora kojeg želite da obrišete!",
                                "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSponzora = int.Parse(listViewSponzori.SelectedItems[0].SubItems[0].Text);
            string nazivSponzora = listViewSponzori.SelectedItems[0].SubItems[1].Text;

            DialogResult result = MessageBox.Show(
                $"Da li ste sigurni da želite da obrišete sponzora '{nazivSponzora}'?\nBiće obrisani i svi podaci vezani za ovog sponzora (kontakti i ugovori).",
                "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiSponzora(idSponzora);
                MessageBox.Show("Sponzor je uspešno obrisan!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                popuniPodacima();
            }
        }

        private void btnKontakti_Click(object sender, EventArgs e)
        {
            if (listViewSponzori.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo vas da izaberete sponzora čije kontakte želite da pogledate!",
                                "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSponzora = int.Parse(listViewSponzori.SelectedItems[0].SubItems[0].Text);
            string nazivSponzora = listViewSponzori.SelectedItems[0].SubItems[1].Text;

            // Otvaranje forme za kontakte izabranog sponzora
            SponzorKontaktiForma forma = new SponzorKontaktiForma(idSponzora, nazivSponzora);
            forma.ShowDialog();
        }

        private void btnUgovori_Click(object sender, EventArgs e)
        {
            if (listViewSponzori.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo vas da izaberete sponzora čije ugovore želite da pogledate!",
                                "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSponzora = int.Parse(listViewSponzori.SelectedItems[0].SubItems[0].Text);
            string nazivSponzora = listViewSponzori.SelectedItems[0].SubItems[1].Text;

            // Otvaranje forme za ugovore izabranog sponzora
            SponzorskiUgovoriForma forma = new SponzorskiUgovoriForma(idSponzora, nazivSponzora);
            forma.ShowDialog();
        }
    }
}