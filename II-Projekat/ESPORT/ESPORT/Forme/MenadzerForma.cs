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
    public partial class MenadzerForma : Form
    {
        public MenadzerForma()
        {
            InitializeComponent();
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            listViewMenazer.Items.Clear();
            List<MenadzerPregled> menadzeri = DTOManager.vratiSveMenadzere();

            foreach (var m in menadzeri)
            {
                ListViewItem item = new ListViewItem(m.OsobaId.ToString());
                item.SubItems.Add(m.Ime ?? "");
                item.SubItems.Add(m.Prezime ?? "");
                item.SubItems.Add(m.DatumRodjenja.HasValue ? m.DatumRodjenja.Value.ToString("dd.MM.yyyy.") : "");
                item.SubItems.Add(m.Drzava ?? "");
                item.SubItems.Add(m.Email ?? "");
                item.SubItems.Add(m.StatusAngazmana ?? "");
                item.SubItems.Add(m.OblastOdgovornosti ?? "");

                listViewMenazer.Items.Add(item);
            }
        }

        private void MenadzerForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btndodajmenadzera_Click(object sender, EventArgs e)
        {
            DodajMenadzeraForma form = new DodajMenadzeraForma();
            if (form.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void btnizmenimenadzera_Click(object sender, EventArgs e)
        {
            if (listViewMenazer.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate prvo izabrati menadžera iz liste da biste ga izmenili!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int idMenadzera = int.Parse(listViewMenazer.SelectedItems[0].SubItems[0].Text);
            MenadzerBasic odabraniMenadzer = DTOManager.vratiMenadzera(idMenadzera);

            if (odabraniMenadzer != null)
            {
                IzmeniMenadzerForma forma = new IzmeniMenadzerForma(odabraniMenadzer);
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    popuniPodacima();
                }
            }
        }

        private void btnizbrisimenadzera_Click(object sender, EventArgs e)
        {
            if (listViewMenazer.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate prvo izabrati menadžera iz liste za brisanje!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int idMenadzera = int.Parse(listViewMenazer.SelectedItems[0].SubItems[0].Text);
            string imeIPrezime = $"{listViewMenazer.SelectedItems[0].SubItems[1].Text} {listViewMenazer.SelectedItems[0].SubItems[2].Text}";

            DialogResult result = MessageBox.Show($"Da li ste sigurni da želite da obrišete menadžera {imeIPrezime}?",
                                                "Potvrda brisanja",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiMenadzera(idMenadzera);
                popuniPodacima();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AngazmanZaposlenihForma form=new AngazmanZaposlenihForma();
            form.ShowDialog();
        }
    }
}
