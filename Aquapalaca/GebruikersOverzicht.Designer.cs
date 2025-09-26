namespace Aquapalaca
{
    partial class GebruikersOverzicht
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
            this.lbxOverzicht = new System.Windows.Forms.ListBox();
            this.lblOverzicht = new System.Windows.Forms.Label();
            this.btnOphalen = new System.Windows.Forms.Button();
            this.lblAanpassen = new System.Windows.Forms.Label();
            this.txtWijzigen = new System.Windows.Forms.TextBox();
            this.btnWijzigen = new System.Windows.Forms.Button();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerug.Location = new System.Drawing.Point(594, 338);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(136, 74);
            this.btnTerug.TabIndex = 0;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // lbxOverzicht
            // 
            this.lbxOverzicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxOverzicht.FormattingEnabled = true;
            this.lbxOverzicht.ItemHeight = 16;
            this.lbxOverzicht.Location = new System.Drawing.Point(56, 100);
            this.lbxOverzicht.Name = "lbxOverzicht";
            this.lbxOverzicht.Size = new System.Drawing.Size(471, 196);
            this.lbxOverzicht.TabIndex = 1;
            this.lbxOverzicht.SelectedIndexChanged += new System.EventHandler(this.lbxOverzicht_SelectedIndexChanged);
            // 
            // lblOverzicht
            // 
            this.lblOverzicht.AutoSize = true;
            this.lblOverzicht.BackColor = System.Drawing.Color.Transparent;
            this.lblOverzicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverzicht.Location = new System.Drawing.Point(51, 59);
            this.lblOverzicht.Name = "lblOverzicht";
            this.lblOverzicht.Size = new System.Drawing.Size(204, 25);
            this.lblOverzicht.TabIndex = 2;
            this.lblOverzicht.Text = "Gebruikersoverzicht";
            // 
            // btnOphalen
            // 
            this.btnOphalen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOphalen.Location = new System.Drawing.Point(56, 326);
            this.btnOphalen.Name = "btnOphalen";
            this.btnOphalen.Size = new System.Drawing.Size(230, 74);
            this.btnOphalen.TabIndex = 3;
            this.btnOphalen.Text = "Gebruikers ophalen";
            this.btnOphalen.UseVisualStyleBackColor = true;
            this.btnOphalen.Click += new System.EventHandler(this.btnOphalen_Click);
            // 
            // lblAanpassen
            // 
            this.lblAanpassen.AutoSize = true;
            this.lblAanpassen.BackColor = System.Drawing.Color.Transparent;
            this.lblAanpassen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAanpassen.Location = new System.Drawing.Point(624, 74);
            this.lblAanpassen.Name = "lblAanpassen";
            this.lblAanpassen.Size = new System.Drawing.Size(133, 20);
            this.lblAanpassen.TabIndex = 5;
            this.lblAanpassen.Text = "Rol aanpassen";
            // 
            // txtWijzigen
            // 
            this.txtWijzigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWijzigen.Location = new System.Drawing.Point(630, 112);
            this.txtWijzigen.Name = "txtWijzigen";
            this.txtWijzigen.ReadOnly = true;
            this.txtWijzigen.Size = new System.Drawing.Size(127, 22);
            this.txtWijzigen.TabIndex = 6;
            // 
            // btnWijzigen
            // 
            this.btnWijzigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWijzigen.Location = new System.Drawing.Point(628, 201);
            this.btnWijzigen.Name = "btnWijzigen";
            this.btnWijzigen.Size = new System.Drawing.Size(127, 42);
            this.btnWijzigen.TabIndex = 7;
            this.btnWijzigen.Text = "Wijzigen";
            this.btnWijzigen.UseVisualStyleBackColor = true;
            this.btnWijzigen.Click += new System.EventHandler(this.btnWijzigen_Click);
            // 
            // cbxRol
            // 
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Location = new System.Drawing.Point(630, 155);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(121, 24);
            this.cbxRol.TabIndex = 8;
            this.cbxRol.SelectedIndexChanged += new System.EventHandler(this.cbxRol_SelectedIndexChanged);
            // 
            // GebruikersOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aquapalaca.Properties.Resources.output;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxRol);
            this.Controls.Add(this.btnWijzigen);
            this.Controls.Add(this.txtWijzigen);
            this.Controls.Add(this.lblAanpassen);
            this.Controls.Add(this.btnOphalen);
            this.Controls.Add(this.lblOverzicht);
            this.Controls.Add(this.lbxOverzicht);
            this.Controls.Add(this.btnTerug);
            this.Name = "GebruikersOverzicht";
            this.Text = "GebruikersOverzicht";
            this.Load += new System.EventHandler(this.GebruikersOverzicht_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.ListBox lbxOverzicht;
        private System.Windows.Forms.Label lblOverzicht;
        private System.Windows.Forms.Button btnOphalen;
        private System.Windows.Forms.Label lblAanpassen;
        private System.Windows.Forms.TextBox txtWijzigen;
        private System.Windows.Forms.Button btnWijzigen;
        private System.Windows.Forms.ComboBox cbxRol;
    }
}