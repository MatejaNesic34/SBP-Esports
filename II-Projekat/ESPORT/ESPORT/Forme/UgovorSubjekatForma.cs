using System;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class UgovorSubjekatForma : Form
    {
        private readonly int ugovorId;
        private readonly string nazivUgovoraZaPrikaz;

        public UgovorSubjekatForma(int ugovorId, string nazivUgovoraZaPrikaz)
        {
            InitializeComponent();
            this.ugovorId = ugovorId;
            this.nazivUgovoraZaPrikaz = nazivUgovoraZaPrikaz;
        }

        private void UgovorSubjekatForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewUgovorSubjekat.Items.Clear();

            UgovorDTO.UgovorSubjekatBasic zapis = DTOManager.vratiUgovorSubjekat(ugovorId);

            if (zapis != null)
            {
                string tipSubjekta =
                    zapis.IgracId.HasValue ? "Igrač" :
                    zapis.TimId.HasValue ? "Tim" :
                    zapis.TakmicenjeId.HasValue ? "Takmičenje" : "";

                string nazivSubjekta =
                    zapis.ImePrezimeIgraca ?? zapis.NazivTima ?? zapis.NazivTakmicenja ?? "";

                ListViewItem item = new ListViewItem(nazivUgovoraZaPrikaz);
                item.SubItems.Add(tipSubjekta);
                item.SubItems.Add(nazivSubjekta);

                listViewUgovorSubjekat.Items.Add(item);
            }

            listViewUgovorSubjekat.Refresh();
        }

        private void btnDodajUgovorSubjekat_Click(object sender, EventArgs e)
        {
            if (DTOManager.vratiUgovorSubjekat(ugovorId) != null)
            {
                MessageBox.Show(
                    "Ovaj ugovor već ima dodeljen subjekat. Koristite \"Izmeni\" da ga promenite.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DodajUgovorSubjekatForma forma = new DodajUgovorSubjekatForma(ugovorId, nazivUgovoraZaPrikaz);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void btnIzmeniUgovorSubjekat_Click(object sender, EventArgs e)
        {
            if (listViewUgovorSubjekat.Items.Count == 0)
            {
                MessageBox.Show("Ovaj ugovor još uvek nema dodeljen subjekat. Koristite \"Dodaj\".",
                                "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IzmeniUgovorSubjekatForma forma = new IzmeniUgovorSubjekatForma(ugovorId, nazivUgovoraZaPrikaz);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void btnObrisiUgovorSubjekat_Click(object sender, EventArgs e)
        {
            if (listViewUgovorSubjekat.Items.Count == 0)
            {
                MessageBox.Show("Ovaj ugovor nema dodeljen subjekat koji bi se obrisao!",
                                "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Da li ste sigurni da želite da obrišete subjekat ovog ugovora?",
                                "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DTOManager.obrisiUgovorSubjekat(ugovorId))
                {
                    MessageBox.Show("Subjekat ugovora je uspešno obrisan!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    popuniPodacima();
                }
            }
        }
    }
}