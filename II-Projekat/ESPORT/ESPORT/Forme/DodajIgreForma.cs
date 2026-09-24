using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ESPORT.IgraDTO;

namespace ESPORT.Forme
{
    public partial class DodajIgreForma : Form
    {
        public DodajIgreForma()
        {
            InitializeComponent();
        }

        private void dodajbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nazivtextBox.Text) ||
                string.IsNullOrWhiteSpace(zanrtextBox.Text))
            {
                MessageBox.Show("Molimo vas da popunite sva tekstualna polja!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            IgraBasic igra = new IgraBasic();

            igra.Naziv = nazivtextBox.Text.Trim();
            igra.Zanr = zanrtextBox.Text.Trim();

            DTOManager.dodajIgru(igra);

            MessageBox.Show("Igra je uspešno dodata!",
                            "Obaveštenje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void otkazibtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Da li ste sigurni da želite da odustanete?",
                "Potvrda otkazivanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}