using ESPORT.Entiteti;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ESPORT.IgracDTO;

namespace ESPORT.Forme
{
    public partial class IzmeniTransferForma : Form
    {
        private TransferDTO.TransferBasic transfer;

        public IzmeniTransferForma(TransferDTO.TransferBasic t)
        {
            InitializeComponent();

            transfer = t;
        }

        private void IzmeniTransferForma_Load(object sender, EventArgs e)
        {
            popuniIgrace();
            popuniTimove();
            popuniPodacima();
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

            prethodniTimCB.DataSource =
                new List<TimDTO.TimPregled>(timovi);

            prethodniTimCB.DisplayMember = "Naziv";
            prethodniTimCB.ValueMember = "TimId";

            noviTimCB.DataSource =
                new List<TimDTO.TimPregled>(timovi);

            noviTimCB.DisplayMember = "Naziv";
            noviTimCB.ValueMember = "TimId";
        }

        private void popuniPodacima()
        {
            if (transfer == null)
                return;

            igracCB.SelectedValue = transfer.IgracId;

            if (transfer.PrethodniTimId.HasValue)
                prethodniTimCB.SelectedValue =
                    transfer.PrethodniTimId.Value;
            else
                prethodniTimCB.SelectedIndex = -1;

            noviTimCB.SelectedValue = transfer.NoviTimId;

            datumPrelaskaDTP.Value =
                transfer.DatumPrelaska;

            iznosTransferaTB.Text =
                transfer.IznosTransfera.ToString();

            valutaTB.Text =
                transfer.Valuta ?? "";

            trajanjeUgovoraTB.Text =
                transfer.TrajanjeUgovoraMeseci.HasValue
                    ? transfer.TrajanjeUgovoraMeseci.Value.ToString()
                    : "";

            posebneKlauzuleTB.Text =
                transfer.PosebneKlauzule ?? "";
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

            transfer.IgracId =
                Convert.ToInt32(igracCB.SelectedValue);

            transfer.PrethodniTimId =
                prethodniTimId;

            transfer.NoviTimId =
                Convert.ToInt32(noviTimCB.SelectedValue);

            transfer.DatumPrelaska =
                datumPrelaskaDTP.Value;

            transfer.IznosTransfera =
                iznos;

            transfer.Valuta =
                valutaTB.Text;

            transfer.TrajanjeUgovoraMeseci =
                trajanje;

            transfer.PosebneKlauzule =
                posebneKlauzuleTB.Text;

            bool uspesno =
                DTOManager.azurirajTransfer(transfer);

            if (uspesno)
            {
                MessageBox.Show(
                    "Transfer je uspešno izmenjen!",
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