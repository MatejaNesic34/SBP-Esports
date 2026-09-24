namespace ESPORT.Forme
{
    partial class UgovorSubjekatForma
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewUgovorSubjekat;
        private System.Windows.Forms.Button btnDodajUgovorSubjekat;
        private System.Windows.Forms.Button btnIzmeniUgovorSubjekat;
        private System.Windows.Forms.Button btnObrisiUgovorSubjekat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listViewUgovorSubjekat = new System.Windows.Forms.ListView();
            this.btnDodajUgovorSubjekat = new System.Windows.Forms.Button();
            this.btnIzmeniUgovorSubjekat = new System.Windows.Forms.Button();
            this.btnObrisiUgovorSubjekat = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.listViewUgovorSubjekat.FullRowSelect = true;
            this.listViewUgovorSubjekat.GridLines = true;
            this.listViewUgovorSubjekat.HideSelection = false;
            this.listViewUgovorSubjekat.Location = new System.Drawing.Point(12, 12);
            this.listViewUgovorSubjekat.Name = "listViewUgovorSubjekat";
            this.listViewUgovorSubjekat.Size = new System.Drawing.Size(650, 320);
            this.listViewUgovorSubjekat.TabIndex = 0;
            this.listViewUgovorSubjekat.UseCompatibleStateImageBehavior = false;
            this.listViewUgovorSubjekat.View = System.Windows.Forms.View.Details;

            this.btnDodajUgovorSubjekat.Location = new System.Drawing.Point(12, 350);
            this.btnDodajUgovorSubjekat.Name = "btnDodajUgovorSubjekat";
            this.btnDodajUgovorSubjekat.Size = new System.Drawing.Size(100, 30);
            this.btnDodajUgovorSubjekat.TabIndex = 1;
            this.btnDodajUgovorSubjekat.Text = "Dodaj";
            this.btnDodajUgovorSubjekat.UseVisualStyleBackColor = true;
            this.btnDodajUgovorSubjekat.Click += new System.EventHandler(this.btnDodajUgovorSubjekat_Click);

            this.btnIzmeniUgovorSubjekat.Location = new System.Drawing.Point(130, 350);
            this.btnIzmeniUgovorSubjekat.Name = "btnIzmeniUgovorSubjekat";
            this.btnIzmeniUgovorSubjekat.Size = new System.Drawing.Size(100, 30);
            this.btnIzmeniUgovorSubjekat.TabIndex = 2;
            this.btnIzmeniUgovorSubjekat.Text = "Izmeni";
            this.btnIzmeniUgovorSubjekat.UseVisualStyleBackColor = true;
            this.btnIzmeniUgovorSubjekat.Click += new System.EventHandler(this.btnIzmeniUgovorSubjekat_Click);

            this.btnObrisiUgovorSubjekat.Location = new System.Drawing.Point(248, 350);
            this.btnObrisiUgovorSubjekat.Name = "btnObrisiUgovorSubjekat";
            this.btnObrisiUgovorSubjekat.Size = new System.Drawing.Size(100, 30);
            this.btnObrisiUgovorSubjekat.TabIndex = 3;
            this.btnObrisiUgovorSubjekat.Text = "Obriši";
            this.btnObrisiUgovorSubjekat.UseVisualStyleBackColor = true;
            this.btnObrisiUgovorSubjekat.Click += new System.EventHandler(this.btnObrisiUgovorSubjekat_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 401);
            this.Controls.Add(this.btnObrisiUgovorSubjekat);
            this.Controls.Add(this.btnIzmeniUgovorSubjekat);
            this.Controls.Add(this.btnDodajUgovorSubjekat);
            this.Controls.Add(this.listViewUgovorSubjekat);
            this.Name = "UgovorSubjekatForma";
            this.Text = "Pregled Ugovor - Subjekat";
            this.Load += new System.EventHandler(this.UgovorSubjekatForma_Load);
            this.ResumeLayout(false);
        }
    }
}