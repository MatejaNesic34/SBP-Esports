namespace ESPORT.Forme
{
    partial class DodajIgreForma
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
            nazivlbl = new Label();
            zanrlbl = new Label();
            nazivtextBox = new TextBox();
            zanrtextBox = new TextBox();
            otkazibtn = new Button();
            dodajbtn = new Button();
            SuspendLayout();
            // 
            // nazivlbl
            // 
            nazivlbl.AutoSize = true;
            nazivlbl.Location = new Point(60, 120);
            nazivlbl.Name = "nazivlbl";
            nazivlbl.Size = new Size(97, 41);
            nazivlbl.TabIndex = 0;
            nazivlbl.Text = "Naziv:";
            // 
            // zanrlbl
            // 
            zanrlbl.AutoSize = true;
            zanrlbl.Location = new Point(73, 231);
            zanrlbl.Name = "zanrlbl";
            zanrlbl.Size = new Size(84, 41);
            zanrlbl.TabIndex = 1;
            zanrlbl.Text = "Zanr:";
            // 
            // nazivtextBox
            // 
            nazivtextBox.Location = new Point(188, 117);
            nazivtextBox.Name = "nazivtextBox";
            nazivtextBox.Size = new Size(488, 47);
            nazivtextBox.TabIndex = 2;
            // 
            // zanrtextBox
            // 
            zanrtextBox.Location = new Point(188, 228);
            zanrtextBox.Name = "zanrtextBox";
            zanrtextBox.Size = new Size(488, 47);
            zanrtextBox.TabIndex = 3;
            // 
            // otkazibtn
            // 
            otkazibtn.Location = new Point(281, 633);
            otkazibtn.Name = "otkazibtn";
            otkazibtn.Size = new Size(188, 58);
            otkazibtn.TabIndex = 4;
            otkazibtn.Text = "Otkazi";
            otkazibtn.UseVisualStyleBackColor = true;
            // 
            // dodajbtn
            // 
            dodajbtn.Location = new Point(508, 633);
            dodajbtn.Name = "dodajbtn";
            dodajbtn.Size = new Size(188, 58);
            dodajbtn.TabIndex = 5;
            dodajbtn.Text = "Dodaj";
            dodajbtn.UseVisualStyleBackColor = true;
            dodajbtn.Click += dodajbtn_Click;
            // 
            // DodajIgreForma
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 740);
            Controls.Add(dodajbtn);
            Controls.Add(otkazibtn);
            Controls.Add(zanrtextBox);
            Controls.Add(nazivtextBox);
            Controls.Add(zanrlbl);
            Controls.Add(nazivlbl);
            Name = "DodajIgreForma";
            Text = "DodajIgreForma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nazivlbl;
        private Label zanrlbl;
        private TextBox nazivtextBox;
        private TextBox zanrtextBox;
        private Button otkazibtn;
        private Button dodajbtn;
    }
}