namespace EsaldiakLotu
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
            Esaldi1 = new Button();
            Esaldi2 = new Button();
            Esaldi3 = new Button();
            Esaldi4 = new Button();
            Esaldi5 = new Button();
            Lotu = new Button();
            tbEsaldiak = new TextBox();
            Garbitu = new Button();
            SuspendLayout();
            // 
            // Esaldi1
            // 
            Esaldi1.Location = new Point(60, 261);
            Esaldi1.Name = "Esaldi1";
            Esaldi1.Size = new Size(125, 49);
            Esaldi1.TabIndex = 0;
            Esaldi1.Text = "Esaldi 1";
            Esaldi1.UseVisualStyleBackColor = true;
            Esaldi1.Click += Esaldi1Click;
            // 
            // Esaldi2
            // 
            Esaldi2.Enabled = false;
            Esaldi2.Location = new Point(325, 261);
            Esaldi2.Name = "Esaldi2";
            Esaldi2.Size = new Size(130, 49);
            Esaldi2.TabIndex = 1;
            Esaldi2.Text = "Esaldi 2";
            Esaldi2.UseVisualStyleBackColor = true;
            Esaldi2.Click += Esaldi2Click;
            // 
            // Esaldi3
            // 
            Esaldi3.Enabled = false;
            Esaldi3.Location = new Point(591, 261);
            Esaldi3.Name = "Esaldi3";
            Esaldi3.Size = new Size(141, 49);
            Esaldi3.TabIndex = 2;
            Esaldi3.Text = "Esaldi 3";
            Esaldi3.UseVisualStyleBackColor = true;
            Esaldi3.Click += Esaldi3Click;
            // 
            // Esaldi4
            // 
            Esaldi4.Enabled = false;
            Esaldi4.Location = new Point(60, 341);
            Esaldi4.Name = "Esaldi4";
            Esaldi4.Size = new Size(125, 49);
            Esaldi4.TabIndex = 3;
            Esaldi4.Text = "Esaldi 4";
            Esaldi4.UseVisualStyleBackColor = true;
            Esaldi4.Click += Esaldi4Click;
            // 
            // Esaldi5
            // 
            Esaldi5.Enabled = false;
            Esaldi5.Location = new Point(325, 341);
            Esaldi5.Name = "Esaldi5";
            Esaldi5.Size = new Size(130, 49);
            Esaldi5.TabIndex = 4;
            Esaldi5.Text = "Esaldi 5";
            Esaldi5.UseVisualStyleBackColor = true;
            Esaldi5.Click += Esaldi5Click;
            // 
            // Lotu
            // 
            Lotu.Enabled = false;
            Lotu.Location = new Point(591, 341);
            Lotu.Name = "Lotu";
            Lotu.Size = new Size(141, 49);
            Lotu.TabIndex = 5;
            Lotu.Text = "Lotu";
            Lotu.UseVisualStyleBackColor = true;
            Lotu.Click += Lotubtn;
            // 
            // tbEsaldiak
            // 
            tbEsaldiak.Location = new Point(195, 81);
            tbEsaldiak.Multiline = true;
            tbEsaldiak.Name = "tbEsaldiak";
            tbEsaldiak.Size = new Size(387, 130);
            tbEsaldiak.TabIndex = 6;
            // 
            // Garbitu
            // 
            Garbitu.Location = new Point(340, 46);
            Garbitu.Name = "Garbitu";
            Garbitu.Size = new Size(94, 29);
            Garbitu.TabIndex = 7;
            Garbitu.Text = "Garbitu";
            Garbitu.UseVisualStyleBackColor = true;
            Garbitu.Click += GarbituClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Garbitu);
            Controls.Add(tbEsaldiak);
            Controls.Add(Lotu);
            Controls.Add(Esaldi5);
            Controls.Add(Esaldi4);
            Controls.Add(Esaldi3);
            Controls.Add(Esaldi2);
            Controls.Add(Esaldi1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Esaldi1;
        private Button Esaldi2;
        private Button Esaldi3;
        private Button Esaldi4;
        private Button Esaldi5;
        private Button Lotu;
        private TextBox tbEsaldiak;
        private Button Garbitu;
    }
}
