using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.UcesceTimaUFaziDTO;
using static ESPORT.FazaTakmicenjaDTO;
using static ESPORT.TimDTO;

namespace ESPORT.Forme
{
    public partial class DodajUcesceForma : Form
    {
        public DodajUcesceForma()
        {
            InitializeComponent();

            popuniFaze();
            popuniTimove();
        }

        private void popuniFaze()
        {
            cmbFaza.Items.Clear();

            List<FazaTakmicenjaPregled> faze =
                DTOManager.vratiSveFaze();

            foreach (FazaTakmicenjaPregled faza in faze)
            {
                cmbFaza.Items.Add(faza);
            }

            cmbFaza.DisplayMember = "Prikaz";
            cmbFaza.ValueMember = "FazaId";

            if (cmbFaza.Items.Count > 0)
                cmbFaza.SelectedIndex = 0;
        }

        private void popuniTimove()
        {
            cmbTim.Items.Clear();

            List<TimPregled> timovi =
                DTOManager.vratiSveTimove();

            foreach (TimPregled tim in timovi)
            {
                cmbTim.Items.Add(tim);
            }

            cmbTim.DisplayMember = "Naziv";
            cmbTim.ValueMember = "TimId";

            if (cmbTim.Items.Count > 0)
                cmbTim.SelectedIndex = 0;
        }

        private void dodajUcesceBtn_Click(
            object sender,
            EventArgs e)
        {
            if (cmbFaza.SelectedItem == null)
            {
                MessageBox.Show(
                    "Izaberite fazu!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cmbTim.SelectedItem == null)
            {
                MessageBox.Show(
                    "Izaberite tim!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!int.TryParse(
                txtPobede.Text,
                out int pobede) ||
                pobede < 0)
            {
                MessageBox.Show(
                    "Broj pobeda mora biti ceo broj veći ili jednak nuli!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!int.TryParse(
                txtPorazi.Text,
                out int porazi) ||
                porazi < 0)
            {
                MessageBox.Show(
                    "Broj poraza mora biti ceo broj veći ili jednak nuli!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!int.TryParse(
                txtBodovi.Text,
                out int bodovi) ||
                bodovi < 0)
            {
                MessageBox.Show(
                    "Broj bodova mora biti ceo broj veći ili jednak nuli!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int? plasman = null;

            if (!string.IsNullOrWhiteSpace(txtPlasman.Text))
            {
                if (!int.TryParse(
                    txtPlasman.Text,
                    out int plasmanVrednost) ||
                    plasmanVrednost <= 0)
                {
                    MessageBox.Show(
                        "Konačan plasman mora biti pozitivan ceo broj!",
                        "Upozorenje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                plasman = plasmanVrednost;
            }

            FazaTakmicenjaPregled izabranaFaza =
                (FazaTakmicenjaPregled)cmbFaza.SelectedItem;

            TimPregled izabraniTim =
                (TimPregled)cmbTim.SelectedItem;

            UcesceBasic ucesce =
                new UcesceBasic(
                    izabranaFaza.FazaId,
                    izabraniTim.TimId,
                    txtStatus.Text,
                    txtRezultat.Text,
                    pobede,
                    porazi,
                    bodovi,
                    plasman);

            bool uspesno =
                DTOManager.dodajUcesce(ucesce);

            if (uspesno)
            {
                MessageBox.Show(
                    "Učešće je uspešno dodato!",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void odustaniBtn_Click(
            object sender,
            EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}