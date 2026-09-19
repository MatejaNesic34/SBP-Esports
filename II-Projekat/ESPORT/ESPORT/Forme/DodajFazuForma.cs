using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.FazaTakmicenjaDTO;
using static ESPORT.TurnirDTO;

namespace ESPORT.Forme
{
    public partial class DodajFazuForma : Form
    {
        public DodajFazuForma()
        {
            InitializeComponent();

            popuniTurnire();
        }

        private void popuniTurnire()
        {
            cmbTurnir.Items.Clear();

            List<TurnirPregled> turniri =
                DTOManager.vratiSveTurnire();

            foreach (TurnirPregled turnir in turniri)
            {
                cmbTurnir.Items.Add(turnir);
            }

            cmbTurnir.DisplayMember = "NazivTakmicenja";
            cmbTurnir.ValueMember = "TakmicenjeId";

            if (cmbTurnir.Items.Count > 0)
            {
                cmbTurnir.SelectedIndex = 0;
            }
        }

        private void cmbTurnir_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            popuniNadfaze();
        }

        private void popuniNadfaze()
        {
            cmbNadfaza.Items.Clear();

            if (cmbTurnir.SelectedItem == null)
                return;

            TurnirPregled izabraniTurnir =
                (TurnirPregled)cmbTurnir.SelectedItem;

            List<FazaTakmicenjaPregled> sveFaze =
                DTOManager.vratiSveFaze();

            foreach (FazaTakmicenjaPregled faza in sveFaze)
            {
                if (faza.TakmicenjeId ==
                    izabraniTurnir.TakmicenjeId)
                {
                    cmbNadfaza.Items.Add(faza);
                }
            }

            cmbNadfaza.DisplayMember = "NazivFaze";
            cmbNadfaza.ValueMember = "FazaId";

            cmbNadfaza.SelectedIndex = -1;
        }

        private void dodajFazuBtn_Click(object sender, EventArgs e)
        {
            if (cmbTurnir.SelectedItem == null)
            {
                MessageBox.Show(
                    "Izaberite turnir!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtNazivFaze.Text))
            {
                MessageBox.Show(
                    "Unesite naziv faze!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (numRedniBroj.Value <= 0)
            {
                MessageBox.Show(
                    "Redni broj mora biti veći od 0!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            TurnirPregled izabraniTurnir =
                (TurnirPregled)cmbTurnir.SelectedItem;

            int? nadfazaId = null;

            if (cmbNadfaza.SelectedItem != null)
            {
                FazaTakmicenjaPregled izabranaNadfaza =
                    (FazaTakmicenjaPregled)cmbNadfaza.SelectedItem;

                nadfazaId = izabranaNadfaza.FazaId;
            }

            FazaTakmicenjaBasic faza =
                new FazaTakmicenjaBasic
                {
                    TakmicenjeId =
                        izabraniTurnir.TakmicenjeId,

                    NazivFaze =
                        txtNazivFaze.Text,

                    RedniBroj =
                        (int)numRedniBroj.Value,

                    NadfazaId =
                        nadfazaId
                };

            bool uspesno =
                DTOManager.dodajFazu(faza);

            if (uspesno)
            {
                MessageBox.Show(
                    "Faza je uspešno dodata!",
                    "Obaveštenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}