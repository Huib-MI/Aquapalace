namespace Aquapalaca
{
    partial class medewerkerAbonnement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medewerkerAbonnement));
            this.btnTerug = new System.Windows.Forms.Button();
            this.lbxAbonnement = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKlanten = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnAddAbbonement = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(952, 345);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(112, 71);
            this.btnTerug.TabIndex = 0;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // lbxAbonnement
            // 
            this.lbxAbonnement.FormattingEnabled = true;
            this.lbxAbonnement.ItemHeight = 16;
            this.lbxAbonnement.Location = new System.Drawing.Point(12, 92);
            this.lbxAbonnement.Name = "lbxAbonnement";
            this.lbxAbonnement.Size = new System.Drawing.Size(831, 324);
            this.lbxAbonnement.TabIndex = 1;
            this.lbxAbonnement.SelectedIndexChanged += new System.EventHandler(this.lbxAbonnement_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filteren op klant:";
            // 
            // cmbKlanten
            // 
            this.cmbKlanten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKlanten.FormattingEnabled = true;
            this.cmbKlanten.Location = new System.Drawing.Point(11, 53);
            this.cmbKlanten.Name = "cmbKlanten";
            this.cmbKlanten.Size = new System.Drawing.Size(152, 24);
            this.cmbKlanten.TabIndex = 3;
            this.cmbKlanten.SelectedIndexChanged += new System.EventHandler(this.cmbKlanten_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status abonnement:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(617, 55);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(145, 22);
            this.txtStatus.TabIndex = 5;
            // 
            // btnAddAbbonement
            // 
            this.btnAddAbbonement.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddAbbonement.Location = new System.Drawing.Point(922, 245);
            this.btnAddAbbonement.Name = "btnAddAbbonement";
            this.btnAddAbbonement.Size = new System.Drawing.Size(142, 71);
            this.btnAddAbbonement.TabIndex = 6;
            this.btnAddAbbonement.Text = "Abonnement Toevoegen";
            this.btnAddAbbonement.UseVisualStyleBackColor = false;
            this.btnAddAbbonement.Click += new System.EventHandler(this.btnAddAbbonement_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Filteren op Type abonnement:";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(233, 52);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 24);
            this.cmbType.TabIndex = 8;
            // 
            // medewerkerAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1076, 450);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddAbbonement);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKlanten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxAbonnement);
            this.Controls.Add(this.btnTerug);
            this.Name = "medewerkerAbonnement";
            this.Text = "medewerkerAbonnement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.ListBox lbxAbonnement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKlanten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnAddAbbonement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbType;
    }
}