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
    public partial class IzmeniIgruForma : Form
    {
        public IzmeniIgruForma()
        {
            InitializeComponent();
        }

        public IgraBasic Igra { get; set; }
        // Konstruktor koji prima odabranu igru
        public IzmeniIgruForma(IgraBasic i) : this()
        {
            this.Igra = i;
            PopuniPolja();
        }

        private void PopuniPolja()
        {
            if (Igra != null)
            {
                nazivtextBox.Text = Igra.Naziv;
                zanrtextBox.Text = Igra.Zanr;
            }
        }
        private void dodajbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nazivtextBox.Text))
            {
                MessageBox.Show("Naziv ne sme biti prazan!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ažuriramo vrednosti u DTO objektu
            Igra.Naziv = nazivtextBox.Text.Trim();
            Igra.Zanr = zanrtextBox.Text.Trim();

            // Pozivamo DTOManager
            DTOManager.azurirajIgru(Igra);

            MessageBox.Show("Izmene su uspešno sačuvane!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
