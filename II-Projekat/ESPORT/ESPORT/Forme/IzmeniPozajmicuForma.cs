using System;
using System.Windows.Forms;

namespace ESPORT
{
    public partial class IzmeniPozajmicuForma : Form
    {
        private int pozajmicaId;

        public IzmeniPozajmicuForma(int id)
        {
            InitializeComponent();

            pozajmicaId = id;

            popuniIgrace();
            popuniTimove();
            popuniPodatke();
        }

        private void popuniIgrace()
        {
            cmbIgrac.Items.Clear();

            var igraci = DTOManager.vratiSveIgrace();

            foreach (var igrac in igraci)
            {
                cmbIgrac.Items.Add(
                    new ComboBoxItem(
                        igrac.OsobaId,
                        igrac.Ime + " " + igrac.Prezime));
            }
        }

        private void popuniTimove()
        {
            cmbMaticniTim.Items.Clear();
            cmbTimNaPozajmici.Items.Clear();

            var timovi = DTOManager.vratiSveTimove();

            foreach (var tim in timovi)
            {
                cmbMaticniTim.Items.Add(
                    new ComboBoxItem(tim.TimId, tim.Naziv));

                cmbTimNaPozajmici.Items.Add(
                    new ComboBoxItem(tim.TimId, tim.Naziv));
            }
        }

        private void popuniPodatke()
        {
            PozajmicaDTO.PozajmicaBasic p =
                DTOManager.vratiPozajmicu(pozajmicaId);

            if (p == null)
            {
                MessageBox.Show(
                    "Pozajmica ne postoji.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();
                return;
            }

            for (int i = 0; i < cmbIgrac.Items.Count; i++)
            {
                ComboBoxItem item =
                    (ComboBoxItem)cmbIgrac.Items[i];

                if (item.Id == p.IgracId)
                {
                    cmbIgrac.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbMaticniTim.Items.Count; i++)
            {
                ComboBoxItem item =
                    (ComboBoxItem)cmbMaticniTim.Items[i];

                if (item.Id == p.MaticniTimId)
                {
                    cmbMaticniTim.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbTimNaPozajmici.Items.Count; i++)
            {
                ComboBoxItem item =
                    (ComboBoxItem)cmbTimNaPozajmici.Items[i];

                if (item.Id == p.TimNaPozajmiciId)
                {
                    cmbTimNaPozajmici.SelectedIndex = i;
                    break;
                }
            }

            dtpDatumOd.Value = p.DatumOd;
            dtpDatumDo.Value = p.DatumDo;

            txtFinansijskiUslovi.Text =
                p.FinansijskiUslovi ?? "";

            cmbPravoOtkupa.SelectedIndex =
                p.PravoOtkupa == 1 ? 0 : 1;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (cmbIgrac.SelectedItem == null)
            {
                MessageBox.Show(
                    "Izaberite igrača.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cmbMaticniTim.SelectedItem == null)
            {
                MessageBox.Show(
                    "Izaberite matični tim.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cmbTimNaPozajmici.SelectedItem == null)
            {
                MessageBox.Show(
                    "Izaberite tim na pozajmici.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (dtpDatumDo.Value < dtpDatumOd.Value)
            {
                MessageBox.Show(
                    "Datum završetka pozajmice ne može biti pre datuma početka.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            ComboBoxItem igrac =
                (ComboBoxItem)cmbIgrac.SelectedItem;

            ComboBoxItem maticniTim =
                (ComboBoxItem)cmbMaticniTim.SelectedItem;

            ComboBoxItem timNaPozajmici =
                (ComboBoxItem)cmbTimNaPozajmici.SelectedItem;

            int pravoOtkupa =
                cmbPravoOtkupa.SelectedIndex == 0 ? 1 : 0;

            PozajmicaDTO.PozajmicaBasic pozajmica =
                new PozajmicaDTO.PozajmicaBasic(
                    pozajmicaId,
                    igrac.Id,
                    maticniTim.Id,
                    timNaPozajmici.Id,
                    dtpDatumOd.Value,
                    dtpDatumDo.Value,
                    txtFinansijskiUslovi.Text,
                    pravoOtkupa);

            if (DTOManager.azurirajPozajmicu(pozajmica))
            {
                MessageBox.Show(
                    "Pozajmica je uspešno izmenjena.",
                    "Uspešno",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}