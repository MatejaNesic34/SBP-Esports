namespace ESPORT.Forme
{
    partial class IzmeniIgruForma
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
            dodajbtn = new Button();
            otkazibtn = new Button();
            zanrtextBox = new TextBox();
            nazivtextBox = new TextBox();
            zanrlbl = new Label();
            nazivlbl = new Label();
            SuspendLayout();

            dodajbtn.Location = new Point(493, 632);
            dodajbtn.Name = "dodajbtn";
            dodajbtn.Size = new Size(188, 58);
            dodajbtn.TabIndex = 11;
            dodajbtn.Text = "Izmeni";
            dodajbtn.UseVisualStyleBackColor = true;
            dodajbtn.Click += dodajbtn_Click;

            otkazibtn.Location = new Point(266, 632);
            otkazibtn.Name = "otkazibtn";
            otkazibtn.Size = new Size(188, 58);
            otkazibtn.TabIndex = 10;
            otkazibtn.Text = "Otkazi";
            otkazibtn.UseVisualStyleBackColor = true;

            zanrtextBox.Location = new Point(173, 227);
            zanrtextBox.Name = "zanrtextBox";
            zanrtextBox.Size = new Size(488, 47);
            zanrtextBox.TabIndex = 9;

            nazivtextBox.Location = new Point(173, 116);
            nazivtextBox.Name = "nazivtextBox";
            nazivtextBox.Size = new Size(488, 47);
            nazivtextBox.TabIndex = 8;

            zanrlbl.AutoSize = true;
            zanrlbl.Location = new Point(58, 230);
            zanrlbl.Name = "zanrlbl";
            zanrlbl.Size = new Size(84, 41);
            zanrlbl.TabIndex = 7;
            zanrlbl.Text = "Zanr:";

            nazivlbl.AutoSize = true;
            nazivlbl.Location = new Point(45, 119);
            nazivlbl.Name = "nazivlbl";
            nazivlbl.Size = new Size(97, 41);
            nazivlbl.TabIndex = 6;
            nazivlbl.Text = "Naziv:";

            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 809);
            Controls.Add(dodajbtn);
            Controls.Add(otkazibtn);
            Controls.Add(zanrtextBox);
            Controls.Add(nazivtextBox);
            Controls.Add(zanrlbl);
            Controls.Add(nazivlbl);
            Name = "IzmeniIgruForma";
            Text = "IzmeniIgruForma";
            Load += IzmeniIgruForma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button dodajbtn;
        private Button otkazibtn;
        private TextBox zanrtextBox;
        private TextBox nazivtextBox;
        private Label zanrlbl;
        private Label nazivlbl;
    }
}