namespace Aquapalaca
{
    partial class medewerkerNieuwAbonnement
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
            this.lblKoppelKlant = new System.Windows.Forms.Label();
            this.cmbKoppelKlant = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbTypeAbonnement = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpEindDatum = new System.Windows.Forms.DateTimePicker();
            this.btnAddAbonnement = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRitten = new System.Windows.Forms.TextBox();
            this.cmbStatusAbonnement = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKoppelKlant
            // 
            this.lblKoppelKlant.AutoSize = true;
            this.lblKoppelKlant.Location = new System.Drawing.Point(134, 9);
            this.lblKoppelKlant.Name = "lblKoppelKlant";
            this.lblKoppelKlant.Size = new System.Drawing.Size(125, 16);
            this.lblKoppelKlant.TabIndex = 10;
            this.lblKoppelKlant.Text = "Koppelen aan klant:";
            // 
            // cmbKoppelKlant
            // 
            this.cmbKoppelKlant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKoppelKlant.FormattingEnabled = true;
            this.cmbKoppelKlant.Location = new System.Drawing.Point(122, 41);
            this.cmbKoppelKlant.Name = "cmbKoppelKlant";
            this.cmbKoppelKlant.Size = new System.Drawing.Size(152, 24);
            this.cmbKoppelKlant.TabIndex = 11;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(139, 86);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(120, 16);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Type abonnement:";
            // 
            // cmbTypeAbonnement
            // 
            this.cmbTypeAbonnement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeAbonnement.FormattingEnabled = true;
            this.cmbTypeAbonnement.Location = new System.Drawing.Point(122, 116);
            this.cmbTypeAbonnement.Name = "cmbTypeAbonnement";
            this.cmbTypeAbonnement.Size = new System.Drawing.Size(152, 24);
            this.cmbTypeAbonnement.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Start abonnement:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Eind abonnement:";
            // 
            // dtpStartDatum
            // 
            this.dtpStartDatum.Location = new System.Drawing.Point(12, 194);
            this.dtpStartDatum.Name = "dtpStartDatum";
            this.dtpStartDatum.Size = new System.Drawing.Size(153, 22);
            this.dtpStartDatum.TabIndex = 16;
            // 
            // dtpEindDatum
            // 
            this.dtpEindDatum.Location = new System.Drawing.Point(224, 194);
            this.dtpEindDatum.Name = "dtpEindDatum";
            this.dtpEindDatum.Size = new System.Drawing.Size(153, 22);
            this.dtpEindDatum.TabIndex = 17;
            // 
            // btnAddAbonnement
            // 
            this.btnAddAbonnement.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAddAbonnement.Location = new System.Drawing.Point(142, 386);
            this.btnAddAbonnement.Name = "btnAddAbonnement";
            this.btnAddAbonnement.Size = new System.Drawing.Size(105, 37);
            this.btnAddAbonnement.TabIndex = 18;
            this.btnAddAbonnement.Text = "Toevoegen";
            this.btnAddAbonnement.UseVisualStyleBackColor = false;
            this.btnAddAbonnement.Click += new System.EventHandler(this.btnKoppelKlant_Click_1);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(324, 386);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(71, 44);
            this.btnTerug.TabIndex = 19;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Overige ritten:";
            // 
            // txtRitten
            // 
            this.txtRitten.Location = new System.Drawing.Point(171, 342);
            this.txtRitten.Name = "txtRitten";
            this.txtRitten.Size = new System.Drawing.Size(57, 22);
            this.txtRitten.TabIndex = 21;
            // 
            // cmbStatusAbonnement
            // 
            this.cmbStatusAbonnement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusAbonnement.FormattingEnabled = true;
            this.cmbStatusAbonnement.Location = new System.Drawing.Point(157, 265);
            this.cmbStatusAbonnement.Name = "cmbStatusAbonnement";
            this.cmbStatusAbonnement.Size = new System.Drawing.Size(86, 24);
            this.cmbStatusAbonnement.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Status Abonnement";
            // 
            // MedewerkerNieuwAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aquapalaca.Properties.Resources.output;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 454);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbStatusAbonnement);
            this.Controls.Add(this.txtRitten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnAddAbonnement);
            this.Controls.Add(this.dtpEindDatum);
            this.Controls.Add(this.dtpStartDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTypeAbonnement);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbKoppelKlant);
            this.Controls.Add(this.lblKoppelKlant);
            this.Name = "MedewerkerNieuwAbonnement";
            this.Text = "MedewerkerNieuwAbonnement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKoppelKlant;
        private System.Windows.Forms.ComboBox cmbKoppelKlant;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbTypeAbonnement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartDatum;
        private System.Windows.Forms.DateTimePicker dtpEindDatum;
        private System.Windows.Forms.Button btnAddAbonnement;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRitten;
        private System.Windows.Forms.ComboBox cmbStatusAbonnement;
        private System.Windows.Forms.Label label4;
    }
}