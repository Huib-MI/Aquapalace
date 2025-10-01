namespace Aquapalaca
{
    partial class klantInchecken
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
            this.lblcheck = new System.Windows.Forms.Label();
            this.btnInchecken = new System.Windows.Forms.Button();
            this.lblWelkom = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTerug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerug.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTerug.Location = new System.Drawing.Point(16, 103);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(87, 46);
            this.btnTerug.TabIndex = 0;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = false;
            this.btnTerug.Click += new System.EventHandler(this.btnUitloggen_Click);
            // 
            // lblcheck
            // 
            this.lblcheck.AutoSize = true;
            this.lblcheck.BackColor = System.Drawing.Color.Transparent;
            this.lblcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheck.Location = new System.Drawing.Point(9, 9);
            this.lblcheck.Name = "lblcheck";
            this.lblcheck.Size = new System.Drawing.Size(298, 39);
            this.lblcheck.TabIndex = 1;
            this.lblcheck.Text = "Klanten Inchecken";
            // 
            // btnInchecken
            // 
            this.btnInchecken.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInchecken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInchecken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInchecken.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInchecken.Location = new System.Drawing.Point(219, 103);
            this.btnInchecken.Name = "btnInchecken";
            this.btnInchecken.Size = new System.Drawing.Size(88, 46);
            this.btnInchecken.TabIndex = 5;
            this.btnInchecken.Text = "Inchecken";
            this.btnInchecken.UseVisualStyleBackColor = false;
            this.btnInchecken.Click += new System.EventHandler(this.btnInchecken_Click);
            // 
            // lblWelkom
            // 
            this.lblWelkom.AutoSize = true;
            this.lblWelkom.BackColor = System.Drawing.Color.Transparent;
            this.lblWelkom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelkom.Location = new System.Drawing.Point(54, 64);
            this.lblWelkom.Name = "lblWelkom";
            this.lblWelkom.Size = new System.Drawing.Size(74, 20);
            this.lblWelkom.TabIndex = 6;
            this.lblWelkom.Text = "Welkom:";
            this.lblWelkom.Click += new System.EventHandler(this.lblNaam_Click);
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.BackColor = System.Drawing.Color.Transparent;
            this.lblNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(134, 64);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(0, 20);
            this.lblNaam.TabIndex = 7;
            // 
            // klantInchecken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aquapalaca.Properties.Resources._3a1b12fa_d009_4264_8238_0820842ed812;
            this.ClientSize = new System.Drawing.Size(319, 161);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblWelkom);
            this.Controls.Add(this.btnInchecken);
            this.Controls.Add(this.lblcheck);
            this.Controls.Add(this.btnTerug);
            this.Name = "klantInchecken";
            this.Text = "klantInchecken";
            this.Load += new System.EventHandler(this.klantInchecken_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Label lblcheck;
        private System.Windows.Forms.Button btnInchecken;
        private System.Windows.Forms.Label lblWelkom;
        private System.Windows.Forms.Label lblNaam;
    }
}