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
                ListViewItem item =
                    new ListViewItem(i.OsobaId.ToString());

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
            if (form.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void izmeniigracabtn_Click(object sender, EventArgs e)
        {
            if (listViewIgraci.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Morate prvo izabrati igrača iz liste da biste ga izmenili!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idIgraca = int.Parse(
                listViewIgraci.SelectedItems[0].SubItems[0].Text);

            IgracBasic odabraniIgrac =
                DTOManager.vratiIgraca(idIgraca);

            if (odabraniIgrac != null)
            {
                IzmeniIgracaForma forma =
                    new IzmeniIgracaForma(odabraniIgrac);

                if (forma.ShowDialog() == DialogResult.OK)
                {
                    popuniPodacima();
                }
            }
        }

        private void obrisiigracabtn_Click(object sender, EventArgs e)
        {
            if (listViewIgraci.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo vas da izaberete igrača koga želite da obrišete!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idIgraca = int.Parse(
                listViewIgraci.SelectedItems[0].SubItems[0].Text);

            string nadimak =
                listViewIgraci.SelectedItems[0].SubItems[3].Text;

            DialogResult potvrdio =
                MessageBox.Show(
                    $"Da li ste sigurni da želite da obrišete igrača '{nadimak}'?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (potvrdio == DialogResult.Yes)
            {
                DTOManager.obrisiIgraca(idIgraca);

                MessageBox.Show(
                    "Igrač je uspešno obrisan!",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                popuniPodacima();
            }
        }

        private void btnUgovoriIgraca_Click(object sender, EventArgs e)
        {
            if (listViewIgraci.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo vas da izaberete igrača čije ugovore želite da pogledate!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idIgraca =
                int.Parse(
                    listViewIgraci.SelectedItems[0].SubItems[0].Text);

            string imeIgraca =
                listViewIgraci.SelectedItems[0].SubItems[1].Text;

            string prezimeIgraca =
                listViewIgraci.SelectedItems[0].SubItems[2].Text;

            UgovoriIgracaForma forma =
                new UgovoriIgracaForma(
                    idIgraca,
                    $"{imeIgraca} {prezimeIgraca}");

            forma.ShowDialog();
        }

        private void btnTransferi_Click(object sender, EventArgs e)
        {
            TransferForma forma =
                new TransferForma();

            forma.ShowDialog();
        }

        private void btnPozajmice_Click(object sender, EventArgs e)
        {
            PozajmicaForma forma =
                new PozajmicaForma();

            forma.ShowDialog();
        }

        private void btnIndividualniRezultati_Click(object sender, EventArgs e)
        {
            IndividualniRezultatForma forma =
                new IndividualniRezultatForma();

            forma.ShowDialog();
        }

        
    }
}