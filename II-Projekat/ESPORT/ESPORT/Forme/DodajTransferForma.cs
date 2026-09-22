using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.IgracDTO;

namespace ESPORT.Forme
{
    public partial class DodajTransferForma : Form
    {
        public DodajTransferForma()
        {
            InitializeComponent();
        }

        private void DodajTransferForma_Load(object sender, EventArgs e)
        {
            popuniIgrace();
            popuniTimove();

            datumPrelaskaDTP.Value = DateTime.Now;
        }

        private void popuniIgrace()
        {
            List<IgracPregled> igraci =
                DTOManager.vratiSveIgrace();

            igracCB.DataSource = igraci;
            igracCB.DisplayMember = "Ime";
            igracCB.ValueMember = "OsobaId";
        }

        private void popuniTimove()
        {
            List<TimDTO.TimPregled> timovi =
                DTOManager.vratiSveTimove();

            prethodniTimCB.DataSource = new List<TimDTO.TimPregled>(timovi);
            prethodniTimCB.DisplayMember = "Naziv";
            prethodniTimCB.ValueMember = "TimId";

            noviTimCB.DataSource = new List<TimDTO.TimPregled>(timovi);
            noviTimCB.DisplayMember = "Naziv";
            noviTimCB.ValueMember = "TimId";

            prethodniTimCB.SelectedIndex = -1;
        }

        private void sacuvajBtn_Click(object sender, EventArgs e)
        {
            if (igracCB.SelectedValue == null)
            {
                MessageBox.Show(
                    "Morate izabrati igrača!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (noviTimCB.SelectedValue == null)
            {
                MessageBox.Show(
                    "Morate izabrati novi tim!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!decimal.TryParse(
                iznosTransferaTB.Text,
                out decimal iznos))
            {
                MessageBox.Show(
                    "Iznos transfera mora biti broj!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (iznos < 0)
            {
                MessageBox.Show(
                    "Iznos transfera ne može biti negativan!",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int? prethodniTimId = null;

            if (prethodniTimCB.SelectedValue != null)
            {
                prethodniTimId =
                    Convert.ToInt32(prethodniTimCB.SelectedValue);
            }

            int? trajanje = null;

            if (!string.IsNullOrWhiteSpace(trajanjeUgovoraTB.Text))
            {
                if (!int.TryParse(
                    trajanjeUgovoraTB.Text,
                    out int brojMeseci))
                {
                    MessageBox.Show(
                        "Trajanje ugovora mora biti ceo broj!",
                        "Upozorenje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (brojMeseci < 0)
                {
                    MessageBox.Show(
                        "Trajanje ugovora ne može biti negativno!",
                        "Upozorenje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                trajanje = brojMeseci;
            }

            TransferDTO.TransferBasic transfer =
                new TransferDTO.TransferBasic(
                    0,
                    Convert.ToInt32(igracCB.SelectedValue),
                    prethodniTimId,
                    Convert.ToInt32(noviTimCB.SelectedValue),
                    datumPrelaskaDTP.Value,
                    iznos,
                    valutaTB.Text,
                    trajanje,
                    posebneKlauzuleTB.Text);

            bool uspesno =
                DTOManager.dodajTransfer(transfer);

            if (uspesno)
            {
                MessageBox.Show(
                    "Transfer je uspešno dodat!",
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