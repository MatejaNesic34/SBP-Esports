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
    public partial class TimoviForma : Form
    {
        public TimoviForma()
        {
            InitializeComponent();
        }

        private void TimoviForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewTimovi.Items.Clear();

            List<TimDTO.TimPregled> podaci = DTOManager.vratiSveTimove();

            foreach (TimDTO.TimPregled t in podaci)
            {
                ListViewItem item = new ListViewItem(t.TimId.ToString());

                item.SubItems.Add(t.Naziv);
                item.SubItems.Add(t.Igra);
                item.SubItems.Add(t.DatumOsnivanja.HasValue ? t.DatumOsnivanja.Value.ToString("dd.MM.yyyy") : "");
                item.SubItems.Add(t.DrzavaRegistracije);
                item.SubItems.Add(t.StatusTima);
                item.SubItems.Add(t.NivoTakmicenja);

                listViewTimovi.Items.Add(item);
            }

            listViewTimovi.Refresh();
        }

        private void dodajtimbtn_Click(object sender, EventArgs e)
        {
            DodajTimForma forma = new DodajTimForma();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void izmenitimbtn_Click(object sender, EventArgs e)
        {
            if (listViewTimovi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo vas da izaberete tim koji želite da izmenite!",
                                "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idTima = int.Parse(listViewTimovi.SelectedItems[0].SubItems[0].Text);

            IzmeniTimForma forma = new IzmeniTimForma(idTima);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void obrisitimbtn_Click(object sender, EventArgs e)
        {
            if (listViewTimovi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo vas da izaberete tim koji želite da obrišete!",
                                "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idTima = int.Parse(listViewTimovi.SelectedItems[0].SubItems[0].Text);
            string nazivTima = listViewTimovi.SelectedItems[0].SubItems[1].Text;

            // Brisanje tima briše i sve zavisne podatke (ugovori, transferi, pozajmice, angažmani, učešća, statistike)
            DialogResult result = MessageBox.Show(
                $"Da li ste sigurni da želite da obrišete tim '{nazivTima}'?\nBiće obrisani i svi podaci vezani za ovaj tim (ugovori, transferi, pozajmice, angažmani, učešća i statistike).",
                "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (DTOManager.obrisiTim(idTima))
                {
                    MessageBox.Show("Tim je uspešno obrisan!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    popuniPodacima();
                }
            }
        }
    }
}