using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ESPORT.IgracDTO.TrenerDTO;

namespace ESPORT.Forme
{
    public partial class IzmeniTreneraForm : Form
    {
        private TrenerBasic trener;

        public IzmeniTreneraForm()
        {
            InitializeComponent();
        }

        public IzmeniTreneraForm(TrenerBasic trenerZaIzmenu) : this()
        {
            this.trener = trenerZaIzmenu;
        }

        private void IzmeniTreneraForm_Load(object sender, EventArgs e)
        {
            popuniPolja();
        }

        private void popuniPolja()
        {
            if (trener == null) return;

            // Popunjavanje kontrola na formi podacima izabranog trenera
            textBoxIme.Text = trener.Ime;
            textBoxPrezime.Text = trener.Prezime;
            dtpdatum.Value = trener.DatumRodjenja ?? DateTime.Now;
            textBoxdrzava.Text = trener.Drzava;
            textBoxemail.Text = trener.Email;

            if (!string.IsNullOrEmpty(trener.StatusAngazmana))
            {
                if (comboBoxstatusaranzmana.Items.Contains(trener.StatusAngazmana))
                    comboBoxstatusaranzmana.SelectedItem = trener.StatusAngazmana;
                else
                    comboBoxstatusaranzmana.Text = trener.StatusAngazmana;
            }

            if (!string.IsNullOrEmpty(trener.TipUloge))
            {
                if (comboBoxtipuloge.Items.Contains(trener.TipUloge))
                    comboBoxtipuloge.SelectedItem = trener.TipUloge;
                else
                    comboBoxtipuloge.Text = trener.TipUloge;
            }

            textboxstilrada.Text = trener.StilRada;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            // Validacija obaveznih polja
            if (string.IsNullOrWhiteSpace(textBoxIme.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrezime.Text))
            {
                MessageBox.Show("Polja Ime i Prezime su obavezna!", "Upozorenje",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kreiranje novog DTO objekta sa izmenjenim vrednostima sa forme
            TrenerBasic tb = new TrenerBasic
            {
                // Prosleđivanje ID-a postojećeg trenera za NHibernate ažuriranje
                OsobaId = this.trener.OsobaId,

                Ime = textBoxIme.Text.Trim(),
                Prezime = textBoxPrezime.Text.Trim(),
                DatumRodjenja = dtpdatum.Value,
                Drzava = textBoxdrzava.Text.Trim(),
                Email = textBoxemail.Text.Trim(),
                StatusAngazmana = comboBoxstatusaranzmana.SelectedItem?.ToString() ?? comboBoxstatusaranzmana.Text.Trim(),
                TipUloge = comboBoxtipuloge.SelectedItem?.ToString() ?? comboBoxtipuloge.Text.Trim(),
                StilRada = textboxstilrada.Text.Trim(),
                DatumPrvogAngazovanja = this.trener.DatumPrvogAngazovanja
            };

            // Poziv DTOManager-a za izmenu u bazi
            DTOManager.izmeniTrenera(tb);

            MessageBox.Show("Podaci o treneru su uspešno izmenjeni!", "Obaveštenje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}