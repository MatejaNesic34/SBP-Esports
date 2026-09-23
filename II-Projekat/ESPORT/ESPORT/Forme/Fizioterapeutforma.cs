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
    public partial class Fizioterapeutforma : Form
    {
        public Fizioterapeutforma()
        {
            InitializeComponent();
        }

        private void Fizioterapeutforma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        private void popuniPodacima()
        {
            listViewfizio.Items.Clear();
            List<FizioterapeutPregled> fizioterapeuti = DTOManager.vratiSveFizioterapeute();

            foreach (var f in fizioterapeuti)
            {
                ListViewItem item = new ListViewItem(f.OsobaId.ToString());
                item.SubItems.Add(f.Ime ?? "");
                item.SubItems.Add(f.Prezime ?? "");
                item.SubItems.Add(f.DatumRodjenja.HasValue ? f.DatumRodjenja.Value.ToString("dd.MM.yyyy.") : "");
                item.SubItems.Add(f.Drzava ?? "");
                item.SubItems.Add(f.Email ?? "");
                item.SubItems.Add(f.StatusAngazmana ?? "");
                item.SubItems.Add(f.OblastRada ?? "");
                item.SubItems.Add(f.PeriodiDostupnosti ?? "");

                listViewfizio.Items.Add(item);
            }

        }

        private void btndodajfizio_Click(object sender, EventArgs e)
        {
            DodajFizioForma form = new DodajFizioForma();
            if (form.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void btnizmenifizio_Click(object sender, EventArgs e)
        {
            if (listViewfizio.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate prvo izabrati fizioterapeuta iz liste da biste ga izmenili!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int idFizioterapeuta = int.Parse(listViewfizio.SelectedItems[0].SubItems[0].Text);
            FizioterapeutBasic odabraniFizioterapeut = DTOManager.vratiFizioterapeuta(idFizioterapeuta);

            if (odabraniFizioterapeut != null)
            {
                IzmeniFizioForma forma = new IzmeniFizioForma(odabraniFizioterapeut);
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    popuniPodacima();
                }
            }
        }

        private void btnobrisifizio_Click(object sender, EventArgs e)
        {
            if (listViewfizio.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate prvo izabrati fizioterapeuta iz liste za brisanje!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int idFizioterapeuta = int.Parse(listViewfizio.SelectedItems[0].SubItems[0].Text);
            string imeIPrezime = $"{listViewfizio.SelectedItems[0].SubItems[1].Text} {listViewfizio.SelectedItems[0].SubItems[2].Text}";

            DialogResult result = MessageBox.Show($"Da li ste sigurni da želite da obrišete fizioterapeuta {imeIPrezime}?",
                                                  "Potvrda brisanja",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiFizioterapeuta(idFizioterapeuta);
                popuniPodacima();
            }
        }

        private void btnlicenca_Click(object sender, EventArgs e)
        {
            LicencaForma forma=new LicencaForma();
            forma.ShowDialog();
        }
    }
}
