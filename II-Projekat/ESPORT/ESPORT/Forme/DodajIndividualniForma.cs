using System;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class DodajIndividualniForma : Form
    {
        public DodajIndividualniForma()
        {
            InitializeComponent();

            popuniIgrace();
            popuniTakmicenja();

            cmbIgrac.SelectedIndex = -1;
            cmbTakmicenje.SelectedIndex = -1;
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
                        igrac.Nadimak));
            }
        }

        private void popuniTakmicenja()
        {
            cmbTakmicenje.Items.Clear();

            var takmicenja = DTOManager.vratiSvaTakmicenja();

            foreach (var takmicenje in takmicenja)
            {
                cmbTakmicenje.Items.Add(
                    new ComboBoxItem(
                        takmicenje.TakmicenjeId,
                        takmicenje.Naziv));
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

            if (string.IsNullOrWhiteSpace(txtNazivPriznanja.Text))
            {
                MessageBox.Show(
                    "Unesite naziv priznanja.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            ComboBoxItem igrac =
                (ComboBoxItem)cmbIgrac.SelectedItem;

            int? takmicenjeId = null;

            if (cmbTakmicenje.SelectedItem != null)
            {
                ComboBoxItem takmicenje =
                    (ComboBoxItem)cmbTakmicenje.SelectedItem;

                takmicenjeId = takmicenje.Id;
            }

            DateTime? datumOstvarivanja = null;

            if (chkDatum.Checked)
            {
                datumOstvarivanja = dtpDatum.Value.Date;
            }

            IndividualniRezultatDTO.IndividualniRezultatBasic rezultat =
                new IndividualniRezultatDTO.IndividualniRezultatBasic(
                    0,
                    igrac.Id,
                    txtNazivPriznanja.Text.Trim(),
                    datumOstvarivanja,
                    takmicenjeId,
                    txtOpis.Text.Trim());

            if (DTOManager.dodajIndividualniRezultat(rezultat))
            {
                MessageBox.Show(
                    "Individualni rezultat je uspešno dodat.",
                    "Uspešno",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}