using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ESPORT.AnaliticarDTO;

namespace ESPORT.Forme
{
    public partial class AnaliticarForm : Form
    {
        public AnaliticarForm()
        {
            InitializeComponent();
        }

        private void AnaliticarForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listViewAnaliticari.Items.Clear();

            List<AnaliticarPregled> podaci = DTOManager.vratiSveAnaliticare();

            foreach (AnaliticarPregled a in podaci)
            {
                ListViewItem item = new ListViewItem(a.OsobaId.ToString());
                item.SubItems.Add(a.Ime ?? "");
                item.SubItems.Add(a.Prezime ?? "");
                item.SubItems.Add(a.DatumRodjenja?.ToString("dd.MM.yyyy.") ?? "");
                item.SubItems.Add(a.Drzava ?? "");
                item.SubItems.Add(a.Email ?? "");
                item.SubItems.Add(a.DatumPrvogAngazovanja?.ToString("dd.MM.yyyy.") ?? "");
                item.SubItems.Add(a.StatusAngazmana ?? "");
                item.SubItems.Add(a.OblastAnalize ?? "");
                item.SubItems.Add(a.Alati ?? "");
                item.SubItems.Add(a.NivoIskustva ?? "");

                listViewAnaliticari.Items.Add(item);
            }

            listViewAnaliticari.Refresh();
        }

        private void dodajanaliticarabtn_Click(object sender, EventArgs e)
        {
            DodajAnaliticaraForm form = new DodajAnaliticaraForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void izmenianaliticarabtn_Click(object sender, EventArgs e)
        {
            if (listViewAnaliticari.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate prvo izabrati analitičara iz liste da biste ga izmenili!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int idAnaliticara = int.Parse(listViewAnaliticari.SelectedItems[0].SubItems[0].Text);


            AnaliticarBasic odabraniAnaliticar = DTOManager.vratiAnaliticara(idAnaliticara);

            if (odabraniAnaliticar != null)
            {
                IzmeniAnaliticaraForm form = new IzmeniAnaliticaraForm(odabraniAnaliticar);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    popuniPodacima();
                }
            }
            else
            {
                MessageBox.Show("Došlo je do greške prilikom učitavanja podataka o analitičaru.",
                                "Greška",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void obrisianaliticarabtn_Click(object sender, EventArgs e)
        {
            if (listViewAnaliticari.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate prvo izabrati analitičara iz liste kog želite da obrišete!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selektovaniItem = listViewAnaliticari.SelectedItems[0];
            int idAnaliticara = int.Parse(selektovaniItem.SubItems[0].Text);
            string imePrezime = $"{selektovaniItem.SubItems[1].Text} {selektovaniItem.SubItems[2].Text}".Trim();


            DialogResult rezultat = MessageBox.Show(
                $"Da li ste sigurni da želite da obrišete analitičara: {imePrezime} (ID: {idAnaliticara})?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rezultat == DialogResult.Yes)
            {
                DTOManager.obrisiAnaliticara(idAnaliticara);
                popuniPodacima();
            }
        }

        private void btnangazmanzaposlenih_Click(object sender, EventArgs e)
        {
            AngazmanZaposlenihForma form = new AngazmanZaposlenihForma();
            form.ShowDialog();
        }
    }
}