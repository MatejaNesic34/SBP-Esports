using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.FazaTakmicenjaDTO;

namespace ESPORT.Forme
{
    public partial class IzmeniFazuForma : Form
    {
        private FazaTakmicenjaBasic faza;

        public IzmeniFazuForma(
            FazaTakmicenjaBasic faza)
        {
            InitializeComponent();

            this.faza = faza;

            popuniPodacima();
            popuniNadfaze();
        }

        private void popuniPodacima()
        {
            txtFazaId.Text =
                faza.FazaId.ToString();

            txtTurnirId.Text =
                faza.TakmicenjeId.ToString();

            txtNazivFaze.Text =
                faza.NazivFaze;

            numRedniBroj.Value =
                faza.RedniBroj;
        }

        private void popuniNadfaze()
        {
            cmbNadfaza.Items.Clear();

            List<FazaTakmicenjaPregled> sveFaze =
                DTOManager.vratiSveFaze();

            foreach (FazaTakmicenjaPregled f in sveFaze)
            {
                if (f.TakmicenjeId ==
                        faza.TakmicenjeId &&
                    f.FazaId != faza.FazaId)
                {
                    cmbNadfaza.Items.Add(f);
                }
            }

            cmbNadfaza.DisplayMember = "NazivFaze";
            cmbNadfaza.ValueMember = "FazaId";

            if (!faza.NadfazaId.HasValue)
            {
                cmbNadfaza.SelectedIndex = -1;
            }
            else
            {
                for (int i = 0;
                     i < cmbNadfaza.Items.Count;
                     i++)
                {
                    FazaTakmicenjaPregled f =
                        (FazaTakmicenjaPregled)
                        cmbNadfaza.Items[i];

                    if (f.FazaId ==
                        faza.NadfazaId.Value)
                    {
                        cmbNadfaza.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void izmeniFazuBtn_Click(
            object sender,
            EventArgs e)
        {
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

            int? nadfazaId = null;

            if (cmbNadfaza.SelectedItem != null)
            {
                FazaTakmicenjaPregled izabranaNadfaza =
                    (FazaTakmicenjaPregled)
                    cmbNadfaza.SelectedItem;

                nadfazaId =
                    izabranaNadfaza.FazaId;
            }

            faza.NazivFaze =
                txtNazivFaze.Text;

            faza.RedniBroj =
                (int)numRedniBroj.Value;

            faza.NadfazaId =
                nadfazaId;

            bool uspesno =
                DTOManager.azurirajFazu(faza);

            if (uspesno)
            {
                MessageBox.Show(
                    "Faza je uspešno izmenjena!",
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