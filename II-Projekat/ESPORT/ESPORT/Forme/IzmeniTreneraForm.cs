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

        public IzmeniTreneraForm(TrenerBasic trenerZaIzmenu)
        {
            InitializeComponent();
            this.trener = trenerZaIzmenu;
            popuniPoljaPodacima();
        }

        private void popuniPoljaPodacima()
        {
            if (trener == null) return;

            // Popunjavanje kontrola na formi podacima izabranog trenera
            textBoxIme.Text = trener.Ime ?? "";
            textBoxPrezime.Text = trener.Prezime ?? "";
            dtpdatum.Value = trener.DatumRodjenja ?? DateTime.Now;
            dtpdatumprvogangazovanja.Value = trener.DatumPrvogAngazovanja ?? DateTime.Now;
            textBoxdrzava.Text = trener.Drzava ?? "";
            textBoxemail.Text = trener.Email ?? "";

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

            textboxstilrada.Text = trener.StilRada ?? "";
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            // Validacija obaveznih polja
            if (string.IsNullOrWhiteSpace(textBoxIme.Text) || string.IsNullOrWhiteSpace(textBoxPrezime.Text))
            {
                MessageBox.Show("Ime i prezime su obavezni!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Provera da li je objekat spreman za izmenu
            if (trener == null)
            {
                MessageBox.Show("Došlo je do greške: podaci o treneru nisu učitani!",
                                "Greška",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Direktno ažuriranje vrednosti na postojećem objektu
            trener.Ime = textBoxIme.Text.Trim();
            trener.Prezime = textBoxPrezime.Text.Trim();
            trener.DatumRodjenja = dtpdatum.Value;
            trener.DatumPrvogAngazovanja = dtpdatumprvogangazovanja.Value;
            trener.Drzava = textBoxdrzava.Text.Trim();
            trener.Email = textBoxemail.Text.Trim();
            trener.StatusAngazmana = comboBoxstatusaranzmana.SelectedItem?.ToString() ?? comboBoxstatusaranzmana.Text.Trim();

            // Specifična polja za Trenera
            trener.TipUloge = comboBoxtipuloge.SelectedItem?.ToString() ?? comboBoxtipuloge.Text.Trim();
            trener.StilRada = textboxstilrada.Text.Trim();

            // Poziv DTOManager-a za izmenu u bazi
            DTOManager.izmeniTrenera(trener);

            MessageBox.Show("Podaci o treneru su uspešno izmenjeni!",
                            "Obaveštenje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}