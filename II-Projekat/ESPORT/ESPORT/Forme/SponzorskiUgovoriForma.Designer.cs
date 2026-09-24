namespace ESPORT.Forme
{
    partial class SponzorskiUgovoriForma
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            listViewUgovori = new ListView();
            columnHeaderId = new ColumnHeader();
            columnHeaderDatumOd = new ColumnHeader();
            columnHeaderDatumDo = new ColumnHeader();
            columnHeaderIznos = new ColumnHeader();
            columnHeaderValuta = new ColumnHeader();
            columnHeaderTipPodrske = new ColumnHeader();
            columnHeaderMarketinskeObaveze = new ColumnHeader();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnObrisiUgovor = new Button();
            btnIzmeniUgovor = new Button();
            btnDodajUgovor = new Button();
            btnSubjekatUgovor = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();

            listViewUgovori.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderDatumOd, columnHeaderDatumDo, columnHeaderIznos, columnHeaderValuta, columnHeaderTipPodrske, columnHeaderMarketinskeObaveze });
            listViewUgovori.FullRowSelect = true;
            listViewUgovori.Location = new Point(11, 27);
            listViewUgovori.Margin = new Padding(1);
            listViewUgovori.MultiSelect = false;
            listViewUgovori.Name = "listViewUgovori";
            listViewUgovori.Size = new Size(590, 324);
            listViewUgovori.TabIndex = 0;
            listViewUgovori.UseCompatibleStateImageBehavior = false;
            listViewUgovori.View = View.Details;

            columnHeaderId.Text = "ID";
            columnHeaderId.Width = 80;

            columnHeaderDatumOd.Text = "Datum od";
            columnHeaderDatumOd.Width = 170;

            columnHeaderDatumDo.Text = "Datum do";
            columnHeaderDatumDo.Width = 170;

            columnHeaderIznos.Text = "Iznos";
            columnHeaderIznos.Width = 150;

            columnHeaderValuta.Text = "Valuta";
            columnHeaderValuta.Width = 120;

            columnHeaderTipPodrske.Text = "Tip podrške";
            columnHeaderTipPodrske.Width = 220;

            columnHeaderMarketinskeObaveze.Text = "Marketinške obaveze";
            columnHeaderMarketinskeObaveze.Width = 300;

            groupBox1.Controls.Add(listViewUgovori);
            groupBox1.Location = new Point(19, 31);
            groupBox1.Margin = new Padding(1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1);
            groupBox1.Size = new Size(612, 363);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista sponzorskih ugovora";

            groupBox2.Controls.Add(btnSubjekatUgovor);
            groupBox2.Controls.Add(btnObrisiUgovor);
            groupBox2.Controls.Add(btnIzmeniUgovor);
            groupBox2.Controls.Add(btnDodajUgovor);
            groupBox2.Location = new Point(649, 39);
            groupBox2.Margin = new Padding(1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(1);
            groupBox2.Size = new Size(165, 343);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Akcije sa ugovorima";

            btnObrisiUgovor.Location = new Point(25, 156);
            btnObrisiUgovor.Margin = new Padding(1);
            btnObrisiUgovor.Name = "btnObrisiUgovor";
            btnObrisiUgovor.Size = new Size(114, 38);
            btnObrisiUgovor.TabIndex = 2;
            btnObrisiUgovor.Text = "Obriši ugovor";
            btnObrisiUgovor.UseVisualStyleBackColor = true;
            btnObrisiUgovor.Click += btnObrisiUgovor_Click;

            btnIzmeniUgovor.Location = new Point(25, 98);
            btnIzmeniUgovor.Margin = new Padding(1);
            btnIzmeniUgovor.Name = "btnIzmeniUgovor";
            btnIzmeniUgovor.Size = new Size(114, 37);
            btnIzmeniUgovor.TabIndex = 1;
            btnIzmeniUgovor.Text = "Izmeni ugovor";
            btnIzmeniUgovor.UseVisualStyleBackColor = true;
            btnIzmeniUgovor.Click += btnIzmeniUgovor_Click;

            btnDodajUgovor.Location = new Point(25, 37);
            btnDodajUgovor.Margin = new Padding(1);
            btnDodajUgovor.Name = "btnDodajUgovor";
            btnDodajUgovor.Size = new Size(114, 37);
            btnDodajUgovor.TabIndex = 0;
            btnDodajUgovor.Text = "Dodaj ugovor";
            btnDodajUgovor.UseVisualStyleBackColor = true;
            btnDodajUgovor.Click += btnDodajUgovor_Click;

            btnSubjekatUgovor.Location = new Point(25, 221);
            btnSubjekatUgovor.Margin = new Padding(1);
            btnSubjekatUgovor.Name = "btnSubjekatUgovor";
            btnSubjekatUgovor.Size = new Size(114, 63);
            btnSubjekatUgovor.TabIndex = 3;
            btnSubjekatUgovor.Text = "Subjekat Ugovora";
            btnSubjekatUgovor.UseVisualStyleBackColor = true;
            btnSubjekatUgovor.Click += btnSubjekatUgovor_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 439);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(1);
            Name = "SponzorskiUgovoriForma";
            Text = "Sponzorski Ugovori";
            Load += SponzorskiUgovoriForma_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewUgovori;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderDatumOd;
        private ColumnHeader columnHeaderDatumDo;
        private ColumnHeader columnHeaderIznos;
        private ColumnHeader columnHeaderValuta;
        private ColumnHeader columnHeaderTipPodrske;
        private ColumnHeader columnHeaderMarketinskeObaveze;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnObrisiUgovor;
        private Button btnIzmeniUgovor;
        private Button btnDodajUgovor;
        private Button btnSubjekatUgovor;
    }
}