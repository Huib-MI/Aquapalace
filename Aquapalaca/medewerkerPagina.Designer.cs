namespace Aquapalaca
{
    partial class medewerkerPagina
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
            this.btnInloggen = new System.Windows.Forms.Button();
            this.btnAbonnementen = new System.Windows.Forms.Button();
            this.btnKlanten = new System.Windows.Forms.Button();
            this.btnInchecken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInloggen
            // 
            this.btnInloggen.Location = new System.Drawing.Point(605, 318);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(137, 91);
            this.btnInloggen.TabIndex = 0;
            this.btnInloggen.Text = "Uitloggen";
            this.btnInloggen.UseVisualStyleBackColor = true;
            this.btnInloggen.Click += new System.EventHandler(this.btnInloggen_Click);
            // 
            // btnAbonnementen
            // 
            this.btnAbonnementen.Location = new System.Drawing.Point(90, 97);
            this.btnAbonnementen.Name = "btnAbonnementen";
            this.btnAbonnementen.Size = new System.Drawing.Size(142, 56);
            this.btnAbonnementen.TabIndex = 1;
            this.btnAbonnementen.Text = "Abonnementen";
            this.btnAbonnementen.UseVisualStyleBackColor = true;
            this.btnAbonnementen.Click += new System.EventHandler(this.btnAbonnementen_Click);
            // 
            // btnKlanten
            // 
            this.btnKlanten.Location = new System.Drawing.Point(264, 97);
            this.btnKlanten.Name = "btnKlanten";
            this.btnKlanten.Size = new System.Drawing.Size(141, 56);
            this.btnKlanten.TabIndex = 2;
            this.btnKlanten.Text = "Klanten";
            this.btnKlanten.UseVisualStyleBackColor = true;
            this.btnKlanten.Click += new System.EventHandler(this.btnKlanten_Click);
            // 
            // btnInchecken
            // 
            this.btnInchecken.Location = new System.Drawing.Point(443, 97);
            this.btnInchecken.Name = "btnInchecken";
            this.btnInchecken.Size = new System.Drawing.Size(136, 56);
            this.btnInchecken.TabIndex = 3;
            this.btnInchecken.Text = "Inchecken";
            this.btnInchecken.UseVisualStyleBackColor = true;
            this.btnInchecken.Click += new System.EventHandler(this.btnInchecken_Click);
            // 
            // medewerkerPagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInchecken);
            this.Controls.Add(this.btnKlanten);
            this.Controls.Add(this.btnAbonnementen);
            this.Controls.Add(this.btnInloggen);
            this.Name = "medewerkerPagina";
            this.Text = "medewerkerPagina";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInloggen;
        private System.Windows.Forms.Button btnAbonnementen;
        private System.Windows.Forms.Button btnKlanten;
        private System.Windows.Forms.Button btnInchecken;
    }
}