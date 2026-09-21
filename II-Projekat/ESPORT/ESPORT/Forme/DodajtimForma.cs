using ESPORT.Mapiranje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESPORT.Forme
{
    public partial class DodajTimForma : Form
    {
        public DodajTimForma()
        {
            InitializeComponent();
        }

        private void DodajTimForma_Load(object sender, EventArgs e)
        {
            igracmb.DataSource = DTOManager.vratiSveIgre();
            igracmb.DisplayMember = "Naziv";
            igracmb.ValueMember = "IgraId";

            statuscmb.SelectedIndex = 0;
            datumosnivanjadtp.Checked = false;
        }

        private void sacuvajbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nazivtxt.Text))
            {
                MessageBox.Show("Naziv tima je obavezan!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (igracmb.SelectedValue == null)
            {
                MessageBox.Show("Molimo vas da izaberete igru!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TimDTO.TimBasic tim = new TimDTO.TimBasic
            {
                Naziv = nazivtxt.Text.Trim(),
                IgraId = (int)igracmb.SelectedValue,
                DatumOsnivanja = datumosnivanjadtp.Checked ? datumosnivanjadtp.Value.Date : (DateTime?)null,
                DrzavaRegistracije = string.IsNullOrWhiteSpace(drzavatxt.Text) ? null : drzavatxt.Text.Trim(),
                StatusTima = statuscmb.SelectedItem?.ToString(),
                NivoTakmicenja = nivocmb.SelectedItem?.ToString()
            };

            if (DTOManager.dodajTim(tim))
            {
                MessageBox.Show("Tim je uspešno dodat!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}