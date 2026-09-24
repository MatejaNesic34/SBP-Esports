namespace ESPORT.Forme
{
    partial class IgreForma
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
            listViewIgre = new ListView();
            ID = new ColumnHeader();
            Naziv = new ColumnHeader();
            Zanr = new ColumnHeader();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            obrisiigrubtn = new Button();
            izmeniigrubtn = new Button();
            dodajigrubtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listViewIgre
            // 
            listViewIgre.Columns.AddRange(new ColumnHeader[] { ID, Naziv, Zanr });
            listViewIgre.FullRowSelect = true;
            listViewIgre.Location = new Point(23, 55);
            listViewIgre.Margin = new Padding(2, 2, 2, 2);
            listViewIgre.MultiSelect = false;
            listViewIgre.Name = "listViewIgre";
            listViewIgre.Size = new Size(884, 660);
            listViewIgre.TabIndex = 0;
            listViewIgre.UseCompatibleStateImageBehavior = false;
            listViewIgre.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 70;
            // 
            // Naziv
            // 
            Naziv.Text = "Naziv";
            Naziv.Width = 250;
            // 
            // Zanr
            // 
            Zanr.Text = "Zanr";
            Zanr.Width = 250;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listViewIgre);
            groupBox1.Location = new Point(94, 64);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(939, 744);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prikaz igra";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(obrisiigrubtn);
            groupBox2.Controls.Add(izmeniigrubtn);
            groupBox2.Controls.Add(dodajigrubtn);
            groupBox2.Location = new Point(1120, 80);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(351, 494);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Igre akcije";
            // 
            // obrisiigrubtn
            // 
            obrisiigrubtn.Location = new Point(62, 320);
            obrisiigrubtn.Margin = new Padding(2, 2, 2, 2);
            obrisiigrubtn.Name = "obrisiigrubtn";
            obrisiigrubtn.Size = new Size(242, 78);
            obrisiigrubtn.TabIndex = 2;
            obrisiigrubtn.Text = "Obrisi igru";
            obrisiigrubtn.UseVisualStyleBackColor = true;
            obrisiigrubtn.Click += obrisiigrubtn_Click;
            // 
            // izmeniigrubtn
            // 
            izmeniigrubtn.Location = new Point(62, 201);
            izmeniigrubtn.Margin = new Padding(2, 2, 2, 2);
            izmeniigrubtn.Name = "izmeniigrubtn";
            izmeniigrubtn.Size = new Size(242, 76);
            izmeniigrubtn.TabIndex = 1;
            izmeniigrubtn.Text = "Izmeni igru";
            izmeniigrubtn.UseVisualStyleBackColor = true;
            izmeniigrubtn.Click += izmeniigrubtn_Click;
            // 
            // dodajigrubtn
            // 
            dodajigrubtn.Location = new Point(62, 76);
            dodajigrubtn.Margin = new Padding(2, 2, 2, 2);
            dodajigrubtn.Name = "dodajigrubtn";
            dodajigrubtn.Size = new Size(242, 76);
            dodajigrubtn.TabIndex = 0;
            dodajigrubtn.Text = "Dodaj igru";
            dodajigrubtn.UseVisualStyleBackColor = true;
            dodajigrubtn.Click += dodajigrubtn_Click;
            // 
            // IgreForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1677, 1060);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "IgreForma";
            Text = "IgreForma";
            Load += IgreForma_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewIgre;
        private ColumnHeader ID;
        private ColumnHeader Naziv;
        private ColumnHeader Zanr;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button obrisiigrubtn;
        private Button izmeniigrubtn;
        private Button dodajigrubtn;
    }
}