namespace ESPORT.Forme
{
    partial class UgovoriIgracaForma
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            listViewUgovori = new ListView();
            columnHeaderId = new ColumnHeader();
            columnHeaderIgrac = new ColumnHeader();
            columnHeaderTim = new ColumnHeader();
            columnHeaderDatumOd = new ColumnHeader();
            columnHeaderDatumDo = new ColumnHeader();
            columnHeaderTip = new ColumnHeader();
            columnHeaderPlata = new ColumnHeader();
            columnHeaderStatus = new ColumnHeader();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnObrisiUgovor = new Button();
            btnIzmeniUgovor = new Button();
            btnDodajUgovor = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();

            listViewUgovori.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderIgrac, columnHeaderTim, columnHeaderDatumOd, columnHeaderDatumDo, columnHeaderTip, columnHeaderPlata, columnHeaderStatus });
            listViewUgovori.FullRowSelect = true;
            listViewUgovori.Location = new Point(24, 56);
            listViewUgovori.MultiSelect = false;
            listViewUgovori.Size = new Size(1250, 659);
            listViewUgovori.View = View.Details;

            columnHeaderId.Text = "ID"; columnHeaderId.Width = 70;
            columnHeaderIgrac.Text = "Igrač"; columnHeaderIgrac.Width = 220;
            columnHeaderTim.Text = "Tim"; columnHeaderTim.Width = 220;
            columnHeaderDatumOd.Text = "Datum od"; columnHeaderDatumOd.Width = 150;
            columnHeaderDatumDo.Text = "Datum do"; columnHeaderDatumDo.Width = 150;
            columnHeaderTip.Text = "Tip ugovora"; columnHeaderTip.Width = 150;
            columnHeaderPlata.Text = "Plata"; columnHeaderPlata.Width = 120;
            columnHeaderStatus.Text = "Status"; columnHeaderStatus.Width = 150;

            groupBox1.Controls.Add(listViewUgovori);
            groupBox1.Location = new Point(40, 64);
            groupBox1.Size = new Size(1300, 745);
            groupBox1.Text = "Ugovori igrača";

            groupBox2.Controls.Add(btnObrisiUgovor);
            groupBox2.Controls.Add(btnIzmeniUgovor);
            groupBox2.Controls.Add(btnDodajUgovor);
            groupBox2.Location = new Point(1380, 80);
            groupBox2.Size = new Size(350, 494);
            groupBox2.Text = "Akcije";

            btnObrisiUgovor.Location = new Point(54, 320); btnObrisiUgovor.Size = new Size(243, 77); btnObrisiUgovor.Text = "Obriši ugovor"; btnObrisiUgovor.UseVisualStyleBackColor = true; btnObrisiUgovor.Click += btnObrisiUgovor_Click;
            btnIzmeniUgovor.Location = new Point(54, 200); btnIzmeniUgovor.Size = new Size(243, 76); btnIzmeniUgovor.Text = "Izmeni ugovor"; btnIzmeniUgovor.UseVisualStyleBackColor = true; btnIzmeniUgovor.Click += btnIzmeniUgovor_Click;
            btnDodajUgovor.Location = new Point(54, 76); btnDodajUgovor.Size = new Size(243, 76); btnDodajUgovor.Text = "Dodaj ugovor"; btnDodajUgovor.UseVisualStyleBackColor = true; btnDodajUgovor.Click += btnDodajUgovor_Click;

            ClientSize = new Size(1780, 900);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "UgovoriIgracaForma";
            Text = "Ugovori Igrača";
            Load += UgovoriIgracaForma_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private ListView listViewUgovori;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderIgrac;
        private ColumnHeader columnHeaderTim;
        private ColumnHeader columnHeaderDatumOd;
        private ColumnHeader columnHeaderDatumDo;
        private ColumnHeader columnHeaderTip;
        private ColumnHeader columnHeaderPlata;
        private ColumnHeader columnHeaderStatus;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnObrisiUgovor;
        private Button btnIzmeniUgovor;
        private Button btnDodajUgovor;
    }
}