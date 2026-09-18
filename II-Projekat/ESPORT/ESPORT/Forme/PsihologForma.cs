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
    public partial class PsihologForma : Form
    {
        public PsihologForma()
        {
            InitializeComponent();
        }

        private void PsihologForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listViewpsiholog.Items.Clear();
            List<PsihologPregled> psiholozi = DTOManager.vratiSvePsihologe();

            foreach (var p in psiholozi)
            {
                ListViewItem item = new ListViewItem(p.OsobaId.ToString());
                item.SubItems.Add(p.Ime ?? "");
                item.SubItems.Add(p.Prezime ?? "");
                item.SubItems.Add(p.DatumRodjenja.HasValue ? p.DatumRodjenja.Value.ToString("dd.MM.yyyy.") : "");
                item.SubItems.Add(p.Drzava ?? "");
                item.SubItems.Add(p.Email ?? "");
                item.SubItems.Add(p.StatusAngazmana ?? "");
                item.SubItems.Add(p.OblastRada ?? "");
                item.SubItems.Add(p.PeriodiDostupnosti ?? "");

                listViewpsiholog.Items.Add(item);
            }
        }
        private void btndodajpshiloga_Click(object sender, EventArgs e)
        {
            DodajPsihologaForma form = new DodajPsihologaForma();
            if (form.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void btnizmenipsihologa_Click(object sender, EventArgs e)
        {
            if (listViewpsiholog.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate prvo izabrati psihologa iz liste da biste ga izmenili!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int idPsihologa = int.Parse(listViewpsiholog.SelectedItems[0].SubItems[0].Text);
            PsihologBasic odabraniPsiholog = DTOManager.vratiPsihologa(idPsihologa);

            if (odabraniPsiholog != null)
            {
                IzmeniPsihologaForma forma = new IzmeniPsihologaForma(odabraniPsiholog);
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    popuniPodacima();
                }
            }
        }

        private void btnobrisipsihologa_Click(object sender, EventArgs e)
        {
            if (listViewpsiholog.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate prvo izabrati psihologa iz liste za brisanje!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int idPsihologa = int.Parse(listViewpsiholog.SelectedItems[0].SubItems[0].Text);
            string imeIPrezime = $"{listViewpsiholog.SelectedItems[0].SubItems[1].Text} {listViewpsiholog.SelectedItems[0].SubItems[2].Text}";

            DialogResult result = MessageBox.Show($"Da li ste sigurni da želite da obrišete psihologa {imeIPrezime}?",
                                                  "Potvrda brisanja",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiPsihologa(idPsihologa);
                popuniPodacima();
            }
        }
    }
}
