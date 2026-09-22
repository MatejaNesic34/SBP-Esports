using ESPORT.Forme;
using System;
using System.Windows.Forms;

namespace ESPORT
{
    public partial class PozajmicaForma : Form
    {
        public PozajmicaForma()
        {
            InitializeComponent();
            popuniListu();
        }

        private void popuniListu()
        {
            listViewPozajmice.Items.Clear();

            var pozajmice = DTOManager.vratiSvePozajmice();

            foreach (var p in pozajmice)
            {
                ListViewItem item = new ListViewItem(p.PozajmicaId.ToString());

                item.SubItems.Add(p.Igrac);
                item.SubItems.Add(p.MaticniTim);
                item.SubItems.Add(p.TimNaPozajmici);
                item.SubItems.Add(p.DatumOd.ToString("dd.MM.yyyy."));
                item.SubItems.Add(p.DatumDo.ToString("dd.MM.yyyy."));
                item.SubItems.Add(p.FinansijskiUslovi ?? "");
                item.SubItems.Add(p.PravoOtkupa == 1 ? "Da" : "Ne");

                listViewPozajmice.Items.Add(item);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajPozajmicuForma forma = new DodajPozajmicuForma();
            forma.ShowDialog();

            popuniListu();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listViewPozajmice.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Izaberite pozajmicu koju želite da izmenite.",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int id = int.Parse(
                listViewPozajmice.SelectedItems[0].SubItems[0].Text);

            IzmeniPozajmicuForma forma = new IzmeniPozajmicuForma(id);
            forma.ShowDialog();

            popuniListu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listViewPozajmice.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Izaberite pozajmicu koju želite da obrišete.",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int id = int.Parse(
                listViewPozajmice.SelectedItems[0].SubItems[0].Text);

            DialogResult rezultat = MessageBox.Show(
                "Da li ste sigurni da želite da obrišete izabranu pozajmicu?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rezultat == DialogResult.Yes)
            {
                if (DTOManager.obrisiPozajmicu(id))
                    popuniListu();
            }
        }
    }
}