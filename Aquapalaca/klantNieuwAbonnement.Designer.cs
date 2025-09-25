namespace Aquapalaca
{
    partial class klantNieuwAbonnement
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
            this.btnTerug = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbMaand = new System.Windows.Forms.RadioButton();
            this.rdbJaar = new System.Windows.Forms.RadioButton();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.rdbRittenkaart = new System.Windows.Forms.RadioButton();
            this.btnBevestigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTerug.Location = new System.Drawing.Point(12, 12);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(86, 39);
            this.btnTerug.TabIndex = 0;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = false;
            this.btnTerug.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nieuw abonnement afsluiten";
            // 
            // rdbMaand
            // 
            this.rdbMaand.AutoSize = true;
            this.rdbMaand.BackColor = System.Drawing.Color.Transparent;
            this.rdbMaand.Location = new System.Drawing.Point(73, 121);
            this.rdbMaand.Name = "rdbMaand";
            this.rdbMaand.Size = new System.Drawing.Size(359, 20);
            this.rdbMaand.TabIndex = 2;
            this.rdbMaand.TabStop = true;
            this.rdbMaand.Text = "Maandabonnement, Onberperkt toegang voor 1 maand!";
            this.rdbMaand.UseVisualStyleBackColor = false;
            // 
            // rdbJaar
            // 
            this.rdbJaar.AutoSize = true;
            this.rdbJaar.BackColor = System.Drawing.Color.Transparent;
            this.rdbJaar.Location = new System.Drawing.Point(73, 147);
            this.rdbJaar.Name = "rdbJaar";
            this.rdbJaar.Size = new System.Drawing.Size(321, 20);
            this.rdbJaar.TabIndex = 3;
            this.rdbJaar.TabStop = true;
            this.rdbJaar.Text = "Jaarabonnement, Onbeperkt toegang voor 1 jaar!";
            this.rdbJaar.UseVisualStyleBackColor = false;
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.BackColor = System.Drawing.Color.Transparent;
            this.lblPrijs.Location = new System.Drawing.Point(156, 211);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(39, 16);
            this.lblPrijs.TabIndex = 4;
            this.lblPrijs.Text = "Prijs: ";
            // 
            // rdbRittenkaart
            // 
            this.rdbRittenkaart.AutoSize = true;
            this.rdbRittenkaart.BackColor = System.Drawing.Color.Transparent;
            this.rdbRittenkaart.Location = new System.Drawing.Point(73, 174);
            this.rdbRittenkaart.Name = "rdbRittenkaart";
            this.rdbRittenkaart.Size = new System.Drawing.Size(285, 20);
            this.rdbRittenkaart.TabIndex = 5;
            this.rdbRittenkaart.TabStop = true;
            this.rdbRittenkaart.Text = "10-Rittenkaart, Toegang voor 10 bezoeken!";
            this.rdbRittenkaart.UseVisualStyleBackColor = false;
            // 
            // btnBevestigen
            // 
            this.btnBevestigen.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBevestigen.Location = new System.Drawing.Point(159, 253);
            this.btnBevestigen.Name = "btnBevestigen";
            this.btnBevestigen.Size = new System.Drawing.Size(97, 55);
            this.btnBevestigen.TabIndex = 6;
            this.btnBevestigen.Text = "Abonnement bevestigen";
            this.btnBevestigen.UseVisualStyleBackColor = false;
            this.btnBevestigen.Click += new System.EventHandler(this.btnBevestigen_Click);
            // 
            // klantNieuwAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aquapalaca.Properties.Resources._3a1b12fa_d009_4264_8238_0820842ed812;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(457, 372);
            this.Controls.Add(this.btnBevestigen);
            this.Controls.Add(this.rdbRittenkaart);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.rdbJaar);
            this.Controls.Add(this.rdbMaand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTerug);
            this.Name = "klantNieuwAbonnement";
            this.Text = "klantNieuwAbonnement";
            this.Load += new System.EventHandler(this.klantNieuwAbonnement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbMaand;
        private System.Windows.Forms.RadioButton rdbJaar;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.RadioButton rdbRittenkaart;
        private System.Windows.Forms.Button btnBevestigen;
    }
}