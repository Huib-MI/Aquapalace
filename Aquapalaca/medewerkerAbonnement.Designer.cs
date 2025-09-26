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
            this.lblFilterKlant = new System.Windows.Forms.Label();
            this.cmbFilterKlant = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnAddAbbonement = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.cmbKoppelKlant = new System.Windows.Forms.ComboBox();
            this.lblKoppelKlant = new System.Windows.Forms.Label();
            this.btnKoppelKlant = new System.Windows.Forms.Button();
            this.btnDeselect = new System.Windows.Forms.Button();
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
            // lblFilterKlant
            // 
            this.lblFilterKlant.AutoSize = true;
            this.lblFilterKlant.Location = new System.Drawing.Point(12, 24);
            this.lblFilterKlant.Name = "lblFilterKlant";
            this.lblFilterKlant.Size = new System.Drawing.Size(104, 16);
            this.lblFilterKlant.TabIndex = 2;
            this.lblFilterKlant.Text = "Filteren op klant:";
            // 
            // cmbFilterKlant
            // 
            this.cmbFilterKlant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterKlant.FormattingEnabled = true;
            this.cmbFilterKlant.Location = new System.Drawing.Point(11, 53);
            this.cmbFilterKlant.Name = "cmbFilterKlant";
            this.cmbFilterKlant.Size = new System.Drawing.Size(152, 24);
            this.cmbFilterKlant.TabIndex = 3;
            this.cmbFilterKlant.SelectedIndexChanged += new System.EventHandler(this.cmbKlanten_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(493, 24);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(125, 16);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status abonnement:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(492, 55);
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
            // cmbFilterType
            // 
            this.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Location = new System.Drawing.Point(229, 53);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(200, 24);
            this.cmbFilterType.TabIndex = 8;
            this.cmbFilterType.SelectedIndexChanged += new System.EventHandler(this.cmbTypes_SelectedIndexChanged);
            // 
            // cmbKoppelKlant
            // 
            this.cmbKoppelKlant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKoppelKlant.FormattingEnabled = true;
            this.cmbKoppelKlant.Location = new System.Drawing.Point(912, 53);
            this.cmbKoppelKlant.Name = "cmbKoppelKlant";
            this.cmbKoppelKlant.Size = new System.Drawing.Size(152, 24);
            this.cmbKoppelKlant.TabIndex = 10;
            this.cmbKoppelKlant.SelectedIndexChanged += new System.EventHandler(this.cmbKoppelKlant_SelectedIndexChanged);
            // 
            // lblKoppelKlant
            // 
            this.lblKoppelKlant.AutoSize = true;
            this.lblKoppelKlant.Location = new System.Drawing.Point(928, 24);
            this.lblKoppelKlant.Name = "lblKoppelKlant";
            this.lblKoppelKlant.Size = new System.Drawing.Size(125, 16);
            this.lblKoppelKlant.TabIndex = 9;
            this.lblKoppelKlant.Text = "Koppelen aan klant:";
            // 
            // btnKoppelKlant
            // 
            this.btnKoppelKlant.BackColor = System.Drawing.Color.Gold;
            this.btnKoppelKlant.Location = new System.Drawing.Point(959, 92);
            this.btnKoppelKlant.Name = "btnKoppelKlant";
            this.btnKoppelKlant.Size = new System.Drawing.Size(105, 37);
            this.btnKoppelKlant.TabIndex = 11;
            this.btnKoppelKlant.Text = "Koppel";
            this.btnKoppelKlant.UseVisualStyleBackColor = false;
            this.btnKoppelKlant.Click += new System.EventHandler(this.btnKoppelKlant_Click);
            // 
            // btnDeselect
            // 
            this.btnDeselect.BackColor = System.Drawing.Color.MistyRose;
            this.btnDeselect.BackgroundImage = global::Aquapalaca.Properties.Resources.deselect;
            this.btnDeselect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeselect.Location = new System.Drawing.Point(777, 24);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(66, 62);
            this.btnDeselect.TabIndex = 12;
            this.btnDeselect.UseVisualStyleBackColor = false;
            this.btnDeselect.Click += new System.EventHandler(this.btnDeselect_Click);
            // 
            // medewerkerAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1076, 450);
            this.Controls.Add(this.btnDeselect);
            this.Controls.Add(this.btnKoppelKlant);
            this.Controls.Add(this.cmbKoppelKlant);
            this.Controls.Add(this.lblKoppelKlant);
            this.Controls.Add(this.cmbFilterType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddAbbonement);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbFilterKlant);
            this.Controls.Add(this.lblFilterKlant);
            this.Controls.Add(this.lbxAbonnement);
            this.Controls.Add(this.btnTerug);
            this.Name = "medewerkerAbonnement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "medewerkerAbonnement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.ListBox lbxAbonnement;
        private System.Windows.Forms.Label lblFilterKlant;
        private System.Windows.Forms.ComboBox cmbFilterKlant;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnAddAbbonement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.ComboBox cmbKoppelKlant;
        private System.Windows.Forms.Label lblKoppelKlant;
        private System.Windows.Forms.Button btnKoppelKlant;
        private System.Windows.Forms.Button btnDeselect;
    }
}