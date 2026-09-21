using ESPORT.Forme;

namespace ESPORT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void igrebtn_Click(object sender, EventArgs e)
        {
            IgreForma forma = new IgreForma();
            forma.ShowDialog();
        }

        private void osobebtn_Click(object sender, EventArgs e)
        {
            OsobaForma forma = new OsobaForma();
            forma.ShowDialog();
        }

        private void takmicenjebtn_Click(object sender, EventArgs e)
        {
            TakmicenjeForma forma = new TakmicenjeForma();
            forma.ShowDialog();
        }

        private void Mecbtn_Click(object sender, EventArgs e)
        {
            MecForma forma = new MecForma();
            forma.ShowDialog();
        }

        private void timbtn_Click(object sender, EventArgs e)
        {
            TimoviForma forma = new TimoviForma();
            forma.ShowDialog();
        }

        private void sponzorbtn_Click(object sender, EventArgs e)
        {
            SponzoriForma forma = new SponzoriForma();
            forma.ShowDialog();
        }
    }
}
