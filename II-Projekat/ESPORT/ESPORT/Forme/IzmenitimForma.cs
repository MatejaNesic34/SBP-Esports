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
    public partial class IzmeniTimForma : Form
    {
        private readonly int timId;

        public IzmeniTimForma(int timId)
        {
            InitializeComponent();
            this.timId = timId;
        }

        private void IzmeniTimForma_Load(object sender, EventArgs e)
        {
            TimDTO.TimBasic tim = DTOManager.vratiTim(timId);

            if (tim == null)
            {
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            igracmb.DataSource = DTOManager.vratiSveIgre();
            igracmb.DisplayMember = "Naziv";
            igracmb.ValueMember = "IgraId";

            nazivtxt.Text = tim.Naziv;
            igracmb.SelectedValue = tim.IgraId;

            if (tim.DatumOsnivanja.HasValue)
            {
                datumosnivanjadtp.Value = tim.DatumOsnivanja.Value;
                datumosnivanjadtp.Checked = true;
            }
            else
            {
                datumosnivanjadtp.Checked = false;
            }

            drzavatxt.Text = tim.DrzavaRegistracije;
            statuscmb.SelectedItem = tim.StatusTima;
            nivocmb.SelectedItem = tim.NivoTakmicenja;
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
                TimId = timId,
                Naziv = nazivtxt.Text.Trim(),
                IgraId = (int)igracmb.SelectedValue,
                DatumOsnivanja = datumosnivanjadtp.Checked ? datumosnivanjadtp.Value.Date : (DateTime?)null,
                DrzavaRegistracije = string.IsNullOrWhiteSpace(drzavatxt.Text) ? null : drzavatxt.Text.Trim(),
                StatusTima = statuscmb.SelectedItem?.ToString(),
                NivoTakmicenja = nivocmb.SelectedItem?.ToString()
            };

            if (DTOManager.azurirajTim(tim))
            {
                MessageBox.Show("Tim je uspešno izmenjen!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}