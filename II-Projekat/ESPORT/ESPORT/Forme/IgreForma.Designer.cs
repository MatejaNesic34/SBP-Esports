namespace ESPORT.Forme
{
    partial class IgreForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            listViewIgre.Location = new Point(11, 27);
            listViewIgre.Margin = new Padding(1);
            listViewIgre.MultiSelect = false;
            listViewIgre.Name = "listViewIgre";
            listViewIgre.Size = new Size(418, 324);
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
            Naziv.Width = 150;
            // 
            // Zanr
            // 
            Zanr.Text = "Zanr";
            Zanr.Width = 150;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listViewIgre);
            groupBox1.Location = new Point(44, 31);
            groupBox1.Margin = new Padding(1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1);
            groupBox1.Size = new Size(442, 363);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prikaz igra";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(obrisiigrubtn);
            groupBox2.Controls.Add(izmeniigrubtn);
            groupBox2.Controls.Add(dodajigrubtn);
            groupBox2.Location = new Point(527, 39);
            groupBox2.Margin = new Padding(1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(1);
            groupBox2.Size = new Size(165, 241);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Igre akcije";
            // 
            // obrisiigrubtn
            // 
            obrisiigrubtn.Location = new Point(29, 156);
            obrisiigrubtn.Margin = new Padding(1);
            obrisiigrubtn.Name = "obrisiigrubtn";
            obrisiigrubtn.Size = new Size(114, 38);
            obrisiigrubtn.TabIndex = 2;
            obrisiigrubtn.Text = "Obrisi igru";
            obrisiigrubtn.UseVisualStyleBackColor = true;
            obrisiigrubtn.Click += obrisiigrubtn_Click;
            // 
            // izmeniigrubtn
            // 
            izmeniigrubtn.Location = new Point(29, 98);
            izmeniigrubtn.Margin = new Padding(1);
            izmeniigrubtn.Name = "izmeniigrubtn";
            izmeniigrubtn.Size = new Size(114, 37);
            izmeniigrubtn.TabIndex = 1;
            izmeniigrubtn.Text = "Izmeni igru";
            izmeniigrubtn.UseVisualStyleBackColor = true;
            izmeniigrubtn.Click += izmeniigrubtn_Click;
            // 
            // dodajigrubtn
            // 
            dodajigrubtn.Location = new Point(29, 37);
            dodajigrubtn.Margin = new Padding(1);
            dodajigrubtn.Name = "dodajigrubtn";
            dodajigrubtn.Size = new Size(114, 37);
            dodajigrubtn.TabIndex = 0;
            dodajigrubtn.Text = "Dodaj igru";
            dodajigrubtn.UseVisualStyleBackColor = true;
            dodajigrubtn.Click += dodajigrubtn_Click;
            // 
            // IgreForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 517);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(1);
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