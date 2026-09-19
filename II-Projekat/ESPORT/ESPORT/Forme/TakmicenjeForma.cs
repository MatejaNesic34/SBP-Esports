using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.TakmicenjeDTO;

namespace ESPORT.Forme
{
    public partial class TakmicenjeForma : Form
    {
        public TakmicenjeForma()
        {
            InitializeComponent();
        }

        private void TakmicenjeForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewTakmicenja.Items.Clear();

            List<TakmicenjePregled> podaci =
                DTOManager.vratiSvaTakmicenja();

            foreach (TakmicenjePregled t in podaci)
            {
                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                        t.TakmicenjeId.ToString(),
                        t.Naziv,
                        t.Organizator,
                        t.TipTakmicenja,
                        t.Igra,
                        t.Region,
                        t.Lokacija,
                        t.FormatTakmicenja,
                        t.DatumPocetka.ToString("dd.MM.yyyy"),
                        t.DatumZavrsetka.ToString("dd.MM.yyyy"),
                        t.NagradniFond.ToString(),
                        t.ValutaNagrade,
                        t.Status
                    });

                listViewTakmicenja.Items.Add(item);
            }

            listViewTakmicenja.Refresh();
        }

        private void dodajTakmicenjeBtn_Click(object sender, EventArgs e)
        {
            DodajTakmicenjeForma formaDodaj =
                new DodajTakmicenjeForma();

            formaDodaj.ShowDialog();

            this.popuniPodacima();
        }

        private void izmeniTakmicenjeBtn_Click(object sender, EventArgs e)
        {
            if (listViewTakmicenja.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Izaberite takmicenje cije podatke zelite da izmenite!");

                return;
            }

            int idTakmicenja =
                Int32.Parse(
                    listViewTakmicenja.SelectedItems[0]
                    .SubItems[0].Text);

            TakmicenjeBasic takmicenje =
                DTOManager.vratiTakmicenje(idTakmicenja);

            IzmeniTakmicenjeForma formaUpdate =
                new IzmeniTakmicenjeForma(takmicenje);

            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void obrisiTakmicenjeBtn_Click(object sender, EventArgs e)
        {
            if (listViewTakmicenja.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Izaberite takmicenje koje zelite da obrisete!");

                return;
            }

            int idTakmicenja =
                Int32.Parse(
                    listViewTakmicenja.SelectedItems[0]
                    .SubItems[0].Text);

            string poruka =
                "Da li zelite da obrisete izabrano takmicenje?";

            string title = "Pitanje";

            MessageBoxButtons buttons =
                MessageBoxButtons.OKCancel;

            DialogResult result =
                MessageBox.Show(
                    poruka,
                    title,
                    buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiTakmicenje(idTakmicenja);

                MessageBox.Show(
                    "Brisanje takmicenja je uspesno obavljeno!");

                this.popuniPodacima();
            }
        }

        private void ligeBtn_Click(object sender, EventArgs e)
        {
            LigaForma forma = new LigaForma();
            forma.ShowDialog();
        }

        private void turniriBtn_Click(object sender, EventArgs e)
        {
            TurnirForma forma = new TurnirForma();
            forma.ShowDialog();
        }
    }
}