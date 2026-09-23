using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ESPORT.LicencaDTO;

namespace ESPORT.Forme
{
    public partial class LicencaForma : Form
    {
        public LicencaForma()
        {
            InitializeComponent();
        }
        public void popuniPodacima()
        {
            listViewlicenca.Items.Clear();

            List<LicencaPregled> podaci = DTOManager.vratiSveLicence();

            foreach (LicencaPregled l in podaci)
            {
                ListViewItem item = new ListViewItem(l.LicencaId.ToString());
                item.SubItems.Add(l.OsobaId.ToString());
                item.SubItems.Add(l.Naziv ?? "");
                item.SubItems.Add(l.InstitucijaIzdavac ?? "");
                item.SubItems.Add(l.DatumSticanja.ToString("dd.MM.yyyy."));
                item.SubItems.Add(l.OsobaImePrezime ?? "");

                listViewlicenca.Items.Add(item);
            }

            listViewlicenca.Refresh();
        }

        private void LicencaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btndodaj_Click(object sender, EventArgs e)
        {
            DodajLicencuForm form = new DodajLicencuForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void btnizmeni_Click(object sender, EventArgs e)
        {
            if (listViewlicenca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate prvo izabrati licencu iz liste da biste je izmenili!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int idLicence = int.Parse(listViewlicenca.SelectedItems[0].SubItems[0].Text);

            LicencaBasic odabranaLicenca = DTOManager.vratiLicencu(idLicence);

            if (odabranaLicenca != null)
            {
                IzmeniLicencuForm form = new IzmeniLicencuForm(odabranaLicenca);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    popuniPodacima();
                }
            }
            else
            {
                MessageBox.Show("Došlo je do greške prilikom učitavanja podataka o licenci.",
                                "Greška",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnobrisi_Click(object sender, EventArgs e)
        {
            if (listViewlicenca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate prvo izabrati licencu iz liste koju želite da obrišete!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selektovaniItem = listViewlicenca.SelectedItems[0];
            int idLicence = int.Parse(selektovaniItem.SubItems[0].Text);
            string nazivLicence = selektovaniItem.SubItems[1].Text;

            DialogResult rezultat = MessageBox.Show(
                $"Da li ste sigurni da želite da obrišete licencu: {nazivLicence} (ID: {idLicence})?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rezultat == DialogResult.Yes)
            {
                DTOManager.obrisiLicencu(idLicence);
                popuniPodacima();
            }
        }
    }
}
