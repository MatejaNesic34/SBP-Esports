using ESPORT.Entiteti;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ESPORT.Forme
{
    public partial class IzmeniIgracaForma : Form
    {
        private IgracBasic igrac;
        public IzmeniIgracaForma()
        {
            InitializeComponent();
        }

        public IzmeniIgracaForma(IgracBasic igracZaIzmenu) : this()
        {
            this.igrac = igracZaIzmenu;
        }

        private void IzmeniIgracaForma_Load(object sender, EventArgs e)
        {
            popuniPolja();
        }

        private void popuniPolja()
        {
            if (igrac == null) return;

            // Popunjavanje kontrola na formi podacima izabranog igrača
            textBoxIme.Text = igrac.Ime;
            textBoxPrezime.Text = igrac.Prezime;
            textBoxnadimak.Text = igrac.Nadimak;
            textBoxprimarnauloga.Text = igrac.PrimarnaUloga;
            textBoxsekundarnauloga.Text = igrac.SekundarnaUloga;
            textBoxdominantanstiligre.Text = igrac.DominantniStil;
            textBoxrang.Text = igrac.Rang;
            dtpdatum.Value = igrac.DatumRodjenja ?? DateTime.Now;
            textBoxdrzava.Text = igrac.Drzava;
            textBoxemail.Text = igrac.Email;

            if (!string.IsNullOrEmpty(igrac.StatusAngazmana))
            {
                comboBoxstatusaranzmana.SelectedItem = igrac.StatusAngazmana;
            }

            // Prikaz broja telefona u TextBoxu (ako postoji)
            if (igrac.Telefoni != null && igrac.Telefoni.Count > 0)
            {
                textBoxtelefon.Text = igrac.Telefoni.FirstOrDefault();
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIme.Text) ||
        string.IsNullOrWhiteSpace(textBoxPrezime.Text) ||
        string.IsNullOrWhiteSpace(textBoxnadimak.Text))
            {
                MessageBox.Show("Polja Ime, Prezime i Nadimak su obavezna!",
                                "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kreiramo DTO objekat sa svim podacima SA FORME
            IgracBasic ib = new IgracBasic
            {
                // 1. KLJUČNA IZMENA: Moraš proslediti ID starog igrača da bi NHibernate znao KOGA menja u bazi!
                OsobaId = this.igrac.OsobaId,

                Ime = textBoxIme.Text.Trim(),
                Prezime = textBoxPrezime.Text.Trim(),
                Nadimak = textBoxnadimak.Text.Trim(),
                PrimarnaUloga = textBoxprimarnauloga.Text.Trim(),
                SekundarnaUloga = textBoxsekundarnauloga.Text.Trim(),
                DominantniStil = textBoxdominantanstiligre.Text.Trim(),
                Rang = textBoxrang.Text.Trim(),
                DatumRodjenja = dtpdatum.Value,
                Drzava = textBoxdrzava.Text.Trim(),
                Email = textBoxemail.Text.Trim(),
                StatusAngazmana = comboBoxstatusaranzmana.SelectedItem?.ToString() ?? ""
            };

            string brojTelefona = textBoxtelefon.Text.Trim();
            if (!string.IsNullOrEmpty(brojTelefona))
            {
                ib.Telefoni.Add(brojTelefona);
            }

            // 2. KLJUČNA IZMENA: Šaljemo 'ib' (novi DTO sa izmenama), a NE stari 'igrac'!
            DTOManager.izmeniIgraca(ib);

            MessageBox.Show("Podaci o igraču su uspešno ažurirani!", "Obaveštenje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void otkazibtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Da li ste sigurni da želite da odustanete?",
                "Potvrda otkazivanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
