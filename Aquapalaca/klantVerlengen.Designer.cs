namespace Aquapalaca
{
    partial class klantVerlengen
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
            this.cmbAbonnement = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerlengen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTerug.Location = new System.Drawing.Point(12, 12);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(82, 49);
            this.btnTerug.TabIndex = 0;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = false;
            this.btnTerug.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbAbonnement
            // 
            this.cmbAbonnement.FormattingEnabled = true;
            this.cmbAbonnement.Location = new System.Drawing.Point(74, 107);
            this.cmbAbonnement.Name = "cmbAbonnement";
            this.cmbAbonnement.Size = new System.Drawing.Size(375, 24);
            this.cmbAbonnement.TabIndex = 1;
            this.cmbAbonnement.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Abonnement verlengen";
            // 
            // btnVerlengen
            // 
            this.btnVerlengen.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerlengen.Location = new System.Drawing.Point(206, 180);
            this.btnVerlengen.Name = "btnVerlengen";
            this.btnVerlengen.Size = new System.Drawing.Size(85, 30);
            this.btnVerlengen.TabIndex = 3;
            this.btnVerlengen.Text = "Verlengen";
            this.btnVerlengen.UseVisualStyleBackColor = false;
            this.btnVerlengen.Click += new System.EventHandler(this.btnVerlengen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(194, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "KIes abonnement:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(133, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "*Rittenkaarten worden met 10 ritten verlengd";
            // 
            // klantVerlengen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aquapalaca.Properties.Resources._3a1b12fa_d009_4264_8238_0820842ed812;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 271);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVerlengen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAbonnement);
            this.Controls.Add(this.btnTerug);
            this.Name = "klantVerlengen";
            this.Text = "klantVerlengen";
            this.Load += new System.EventHandler(this.klantVerlengen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.ComboBox cmbAbonnement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerlengen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}