using System;
using System.Windows.Forms;

namespace ESPORT
{
    public partial class DodajPozajmicuForma : Form
    {
        public DodajPozajmicuForma()
        {
            InitializeComponent();
            popuniIgrace();
            popuniTimove();
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
                ComboBoxItem item1 =
                    new ComboBoxItem(tim.TimId, tim.Naziv);

                ComboBoxItem item2 =
                    new ComboBoxItem(tim.TimId, tim.Naziv);

                cmbMaticniTim.Items.Add(item1);
                cmbTimNaPozajmici.Items.Add(item2);
            }
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
                    0,
                    igrac.Id,
                    maticniTim.Id,
                    timNaPozajmici.Id,
                    dtpDatumOd.Value,
                    dtpDatumDo.Value,
                    txtFinansijskiUslovi.Text,
                    pravoOtkupa);

            if (DTOManager.dodajPozajmicu(pozajmica))
            {
                MessageBox.Show(
                    "Pozajmica je uspešno dodata.",
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

    public class ComboBoxItem
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public ComboBoxItem(int id, string text)
        {
            Id = id;
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}