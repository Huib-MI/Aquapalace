namespace Aquapalaca
{
    partial class Abonnementsoverzicht
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
            this.BtnAbonnementen = new System.Windows.Forms.Button();
            this.BtnKlanten = new System.Windows.Forms.Button();
            this.BtnInchecken = new System.Windows.Forms.Button();
            this.BtnUitloggen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAbonnementen
            // 
            this.BtnAbonnementen.Location = new System.Drawing.Point(135, 149);
            this.BtnAbonnementen.Name = "BtnAbonnementen";
            this.BtnAbonnementen.Size = new System.Drawing.Size(144, 52);
            this.BtnAbonnementen.TabIndex = 0;
            this.BtnAbonnementen.Text = "Abonnementen";
            this.BtnAbonnementen.UseVisualStyleBackColor = true;
            // 
            // BtnKlanten
            // 
            this.BtnKlanten.Location = new System.Drawing.Point(334, 149);
            this.BtnKlanten.Name = "BtnKlanten";
            this.BtnKlanten.Size = new System.Drawing.Size(144, 52);
            this.BtnKlanten.TabIndex = 1;
            this.BtnKlanten.Text = "Klanten";
            this.BtnKlanten.UseVisualStyleBackColor = true;
            // 
            // BtnInchecken
            // 
            this.BtnInchecken.Location = new System.Drawing.Point(534, 149);
            this.BtnInchecken.Name = "BtnInchecken";
            this.BtnInchecken.Size = new System.Drawing.Size(144, 52);
            this.BtnInchecken.TabIndex = 2;
            this.BtnInchecken.Text = "Inchecken";
            this.BtnInchecken.UseVisualStyleBackColor = true;
            // 
            // BtnUitloggen
            // 
            this.BtnUitloggen.Location = new System.Drawing.Point(644, 369);
            this.BtnUitloggen.Name = "BtnUitloggen";
            this.BtnUitloggen.Size = new System.Drawing.Size(144, 52);
            this.BtnUitloggen.TabIndex = 3;
            this.BtnUitloggen.Text = "Terug";
            this.BtnUitloggen.UseVisualStyleBackColor = true;
            this.BtnUitloggen.Click += new System.EventHandler(this.BtnUitloggen_Click);
            // 
            // Abonnementsoverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aquapalaca.Properties.Resources.output;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnUitloggen);
            this.Controls.Add(this.BtnInchecken);
            this.Controls.Add(this.BtnKlanten);
            this.Controls.Add(this.BtnAbonnementen);
            this.Name = "Abonnementsoverzicht";
            this.Text = "Abonnementsoverzicht";
            this.Load += new System.EventHandler(this.Abonnementsoverzicht_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAbonnementen;
        private System.Windows.Forms.Button BtnKlanten;
        private System.Windows.Forms.Button BtnInchecken;
        private System.Windows.Forms.Button BtnUitloggen;
    }
}