namespace ESPORT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            osobebtn = new Button();
            timbtn = new Button();
            takmicenjebtn = new Button();
            Mecbtn = new Button();
            sponzorbtn = new Button();
            igrebtn = new Button();
            SuspendLayout();
            // 
            // osobebtn
            // 
            osobebtn.Location = new Point(74, 51);
            osobebtn.Margin = new Padding(1);
            osobebtn.Name = "osobebtn";
            osobebtn.Size = new Size(115, 28);
            osobebtn.TabIndex = 0;
            osobebtn.Text = "Osobe";
            osobebtn.UseVisualStyleBackColor = true;
            osobebtn.Click += osobebtn_Click;
            // 
            // timbtn
            // 
            timbtn.Location = new Point(74, 103);
            timbtn.Margin = new Padding(1);
            timbtn.Name = "timbtn";
            timbtn.Size = new Size(115, 28);
            timbtn.TabIndex = 1;
            timbtn.Text = "Tim";
            timbtn.UseVisualStyleBackColor = true;
            // 
            // takmicenjebtn
            // 
            takmicenjebtn.Location = new Point(74, 156);
            takmicenjebtn.Margin = new Padding(1);
            takmicenjebtn.Name = "takmicenjebtn";
            takmicenjebtn.Size = new Size(115, 28);
            takmicenjebtn.TabIndex = 2;
            takmicenjebtn.Text = "Takmicenje";
            takmicenjebtn.UseVisualStyleBackColor = true;
            takmicenjebtn.Click += takmicenjebtn_Click;
            // 
            // Mecbtn
            // 
            Mecbtn.Location = new Point(74, 206);
            Mecbtn.Margin = new Padding(1);
            Mecbtn.Name = "Mecbtn";
            Mecbtn.Size = new Size(115, 28);
            Mecbtn.TabIndex = 3;
            Mecbtn.Text = "Mec";
            Mecbtn.UseVisualStyleBackColor = true;
            Mecbtn.Click += Mecbtn_Click;
            // 
            // sponzorbtn
            // 
            sponzorbtn.Location = new Point(75, 256);
            sponzorbtn.Margin = new Padding(1);
            sponzorbtn.Name = "sponzorbtn";
            sponzorbtn.Size = new Size(114, 28);
            sponzorbtn.TabIndex = 4;
            sponzorbtn.Text = "Sponzor";
            sponzorbtn.UseVisualStyleBackColor = true;
            // 
            // igrebtn
            // 
            igrebtn.Location = new Point(76, 303);
            igrebtn.Margin = new Padding(1);
            igrebtn.Name = "igrebtn";
            igrebtn.Size = new Size(113, 28);
            igrebtn.TabIndex = 5;
            igrebtn.Text = "Igre";
            igrebtn.UseVisualStyleBackColor = true;
            igrebtn.Click += igrebtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 376);
            Controls.Add(igrebtn);
            Controls.Add(sponzorbtn);
            Controls.Add(Mecbtn);
            Controls.Add(takmicenjebtn);
            Controls.Add(timbtn);
            Controls.Add(osobebtn);
            Margin = new Padding(1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button osobebtn;
        private Button timbtn;
        private Button takmicenjebtn;
        private Button Mecbtn;
        private Button sponzorbtn;
        private Button igrebtn;
    }
}
