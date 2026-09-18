using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ESPORT.OsobaDTO;

namespace ESPORT.Forme
{
    public partial class OsobaForma : Form
    {
        public OsobaForma()
        {
            InitializeComponent();
        }

        private void OsobaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            // Očisti prethodne stavke iz ListView kontrole
            listViewOsobe.Items.Clear();

            // Učitavanje liste osoba iz baze preko DTOManager-a
            List<OsobaPregled> podaci = DTOManager.vratiSveOsobe();

            foreach (OsobaPregled o in podaci)
            {
                // Kreiramo stavku sa prvom kolonom (ID)
                ListViewItem item = new ListViewItem(o.OsobaId.ToString());

                // Dodajemo ostale kolone
                item.SubItems.Add(o.Ime);
                item.SubItems.Add(o.Prezime);
                item.SubItems.Add(o.DatumRodjenja.HasValue ? o.DatumRodjenja.Value.ToString("dd.MM.yyyy.") : "");
                item.SubItems.Add(o.Drzava ?? "");
                item.SubItems.Add(o.Email ?? "");
                item.SubItems.Add(o.StatusAngazmana ?? "");

                // Ubacujemo red u ListView
                listViewOsobe.Items.Add(item);
            }

            listViewOsobe.Refresh();
        }

        private void igracibtn_Click(object sender, EventArgs e)
        {
            IgracForma forma = new IgracForma();
            forma.ShowDialog();
        }

        private void trenerbtn_Click(object sender, EventArgs e)
        {
            TrenerForma forma = new TrenerForma();
            forma.ShowDialog();
        }

        private void analiticarbtn_Click(object sender, EventArgs e)
        {
            AnaliticarForm form = new AnaliticarForm();
            form.ShowDialog();
        }

        private void menadzerbtn_Click(object sender, EventArgs e)
        {
            MenadzerForma forma = new MenadzerForma();
            forma.ShowDialog();
        }

        private void psihologbtn_Click(object sender, EventArgs e)
        {
            PsihologForma forma = new PsihologForma();
            forma.ShowDialog();
        }

        private void fizioterapeutbtn_Click(object sender, EventArgs e)
        {
            Fizioterapeutforma form = new Fizioterapeutforma();
            form.ShowDialog();
        }

        private void skautbtn_Click(object sender, EventArgs e)
        {
            SkautForma forma = new SkautForma();
            forma.ShowDialog();
        }
    }
}
