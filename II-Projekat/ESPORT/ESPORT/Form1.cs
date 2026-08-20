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
    }
}
