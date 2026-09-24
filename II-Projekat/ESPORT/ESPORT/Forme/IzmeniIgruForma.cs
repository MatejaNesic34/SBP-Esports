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
        private IgraBasic igra;

        public IzmeniIgruForma()
        {
            InitializeComponent();
        }

        public IzmeniIgruForma(IgraBasic i)
        {
            InitializeComponent();
            this.igra = i;
        }

        private void IzmeniIgruForma_Load(object sender, EventArgs e)
        {
            popuniPoljaPodacima();
        }

        private void popuniPoljaPodacima()
        {
            if (igra == null) return;

            nazivtextBox.Text = igra.Naziv ?? "";
            zanrtextBox.Text = igra.Zanr ?? "";
        }



        private void dodajbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nazivtextBox.Text) || string.IsNullOrWhiteSpace(zanrtextBox.Text))
            {
                MessageBox.Show("Naziv i žanr su obavezni!",
                                "Upozorenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Da li ste sigurni da želite da sačuvate izmene za igru '{igra.Naziv}'?",
                                                  "Potvrda izmene",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                igra.Naziv = nazivtextBox.Text.Trim();
                igra.Zanr = zanrtextBox.Text.Trim();

                DTOManager.azurirajIgru(igra);

                MessageBox.Show("Podaci o igri su uspešno izmenjeni!",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
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
