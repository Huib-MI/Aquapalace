namespace Aquapalaca
{
    partial class KlantPagina
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
            this.lblNaam = new System.Windows.Forms.Label();
            this.btnUitloggen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(574, 102);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(44, 16);
            this.lblNaam.TabIndex = 0;
            this.lblNaam.Text = "label1";
            this.lblNaam.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUitloggen
            // 
            this.btnUitloggen.Location = new System.Drawing.Point(577, 327);
            this.btnUitloggen.Name = "btnUitloggen";
            this.btnUitloggen.Size = new System.Drawing.Size(140, 63);
            this.btnUitloggen.TabIndex = 1;
            this.btnUitloggen.Text = "Uitloggen";
            this.btnUitloggen.UseVisualStyleBackColor = true;
            this.btnUitloggen.Click += new System.EventHandler(this.btnUitloggen_Click);
            // 
            // KlantPagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUitloggen);
            this.Controls.Add(this.lblNaam);
            this.Name = "KlantPagina";
            this.Text = "KlantPagina";
            this.Load += new System.EventHandler(this.KlantPagina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Button btnUitloggen;
    }
}