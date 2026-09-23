using System;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class IzmeniIndividualniForma : Form
    {
        private int rezultatId;

        public IzmeniIndividualniForma(
            IndividualniRezultatDTO.IndividualniRezultatBasic rezultat)
        {
            InitializeComponent();

            rezultatId = rezultat.RezultatId;

            popuniIgrace();
            popuniTakmicenja();
            popuniPodatke(rezultat);
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

        private void popuniPodatke(
            IndividualniRezultatDTO.IndividualniRezultatBasic rezultat)
        {
            for (int i = 0; i < cmbIgrac.Items.Count; i++)
            {
                ComboBoxItem item =
                    (ComboBoxItem)cmbIgrac.Items[i];

                if (item.Id == rezultat.IgracId)
                {
                    cmbIgrac.SelectedIndex = i;
                    break;
                }
            }

            txtNazivPriznanja.Text =
                rezultat.NazivPriznanja;

            if (rezultat.DatumOstvarivanja.HasValue)
            {
                chkDatum.Checked = true;
                dtpDatum.Value =
                    rezultat.DatumOstvarivanja.Value;
            }
            else
            {
                chkDatum.Checked = false;
            }

            if (rezultat.TakmicenjeId.HasValue)
            {
                for (int i = 0; i < cmbTakmicenje.Items.Count; i++)
                {
                    ComboBoxItem item =
                        (ComboBoxItem)cmbTakmicenje.Items[i];

                    if (item.Id == rezultat.TakmicenjeId.Value)
                    {
                        cmbTakmicenje.SelectedIndex = i;
                        break;
                    }
                }
            }
            else
            {
                cmbTakmicenje.SelectedIndex = -1;
            }

            txtOpis.Text =
                rezultat.Opis ?? "";
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
                    rezultatId,
                    igrac.Id,
                    txtNazivPriznanja.Text.Trim(),
                    datumOstvarivanja,
                    takmicenjeId,
                    txtOpis.Text.Trim());

            if (DTOManager.azurirajIndividualniRezultat(rezultat))
            {
                MessageBox.Show(
                    "Individualni rezultat je uspešno izmenjen.",
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