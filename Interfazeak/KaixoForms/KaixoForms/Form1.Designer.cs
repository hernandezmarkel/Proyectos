namespace KaixoForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.kaixobtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kaixobtn
            // 
            this.kaixobtn.Location = new System.Drawing.Point(247, 143);
            this.kaixobtn.Name = "kaixobtn";
            this.kaixobtn.Size = new System.Drawing.Size(252, 121);
            this.kaixobtn.TabIndex = 0;
            this.kaixobtn.Text = "Kaixo";
            this.kaixobtn.UseVisualStyleBackColor = true;
            this.kaixobtn.Click += new System.EventHandler(this.kaixobtn_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kaixobtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kaixobtn;
    }
}

