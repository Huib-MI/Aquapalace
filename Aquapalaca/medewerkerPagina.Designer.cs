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
            this.btnUitloggen = new System.Windows.Forms.Button();
            this.btnAbonnementen = new System.Windows.Forms.Button();
            this.btnKlanten = new System.Windows.Forms.Button();
            this.btnInchecken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUitloggen
            // 
            this.btnUitloggen.Location = new System.Drawing.Point(605, 318);
            this.btnUitloggen.Name = "btnUitloggen";
            this.btnUitloggen.Size = new System.Drawing.Size(137, 91);
            this.btnUitloggen.TabIndex = 0;
            this.btnUitloggen.Text = "Uitloggen";
            this.btnUitloggen.UseVisualStyleBackColor = true;
            this.btnUitloggen.Click += new System.EventHandler(this.btnInloggen_Click);
            // 
            // btnAbonnementen
            // 
            this.btnAbonnementen.Location = new System.Drawing.Point(37, 42);
            this.btnAbonnementen.Name = "btnAbonnementen";
            this.btnAbonnementen.Size = new System.Drawing.Size(169, 58);
            this.btnAbonnementen.TabIndex = 1;
            this.btnAbonnementen.Text = "Abonnementen";
            this.btnAbonnementen.UseVisualStyleBackColor = true;
            this.btnAbonnementen.Click += new System.EventHandler(this.btnAbonnementen_Click);
            // 
            // btnKlanten
            // 
            this.btnKlanten.Location = new System.Drawing.Point(37, 118);
            this.btnKlanten.Name = "btnKlanten";
            this.btnKlanten.Size = new System.Drawing.Size(169, 56);
            this.btnKlanten.TabIndex = 2;
            this.btnKlanten.Text = "Klanten";
            this.btnKlanten.UseVisualStyleBackColor = true;
            this.btnKlanten.Click += new System.EventHandler(this.btnKlanten_Click);
            // 
            // btnInchecken
            // 
            this.btnInchecken.Location = new System.Drawing.Point(37, 203);
            this.btnInchecken.Name = "btnInchecken";
            this.btnInchecken.Size = new System.Drawing.Size(169, 56);
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
            this.Controls.Add(this.btnUitloggen);
            this.Name = "medewerkerPagina";
            this.Text = "medewerkerPagina";
            this.Load += new System.EventHandler(this.medewerkerPagina_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUitloggen;
        private System.Windows.Forms.Button btnAbonnementen;
        private System.Windows.Forms.Button btnKlanten;
        private System.Windows.Forms.Button btnInchecken;
    }
}