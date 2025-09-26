namespace Aquapalaca
{
    partial class medewerkerKlanten
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
            this.lbxKlanten = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFilterKlant = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtStad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefoon = new System.Windows.Forms.TextBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeselect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxKlanten
            // 
            this.lbxKlanten.FormattingEnabled = true;
            this.lbxKlanten.ItemHeight = 16;
            this.lbxKlanten.Location = new System.Drawing.Point(12, 53);
            this.lbxKlanten.Name = "lbxKlanten";
            this.lbxKlanten.Size = new System.Drawing.Size(695, 548);
            this.lbxKlanten.TabIndex = 2;
            this.lbxKlanten.SelectedIndexChanged += new System.EventHandler(this.lbxKlanten_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(108, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Klanten";
            // 
            // lblFilterKlant
            // 
            this.lblFilterKlant.AutoSize = true;
            this.lblFilterKlant.Location = new System.Drawing.Point(741, 18);
            this.lblFilterKlant.Name = "lblFilterKlant";
            this.lblFilterKlant.Size = new System.Drawing.Size(73, 16);
            this.lblFilterKlant.TabIndex = 8;
            this.lblFilterKlant.Text = "Voornaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Achternaam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(742, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Postcode:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(741, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(742, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(742, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Telefoon";
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(752, 44);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(183, 22);
            this.txtVoornaam.TabIndex = 14;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(750, 107);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(185, 22);
            this.txtAchternaam.TabIndex = 15;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(748, 245);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(187, 22);
            this.txtPostcode.TabIndex = 16;
            // 
            // txtStad
            // 
            this.txtStad.Location = new System.Drawing.Point(748, 313);
            this.txtStad.Name = "txtStad";
            this.txtStad.Size = new System.Drawing.Size(187, 22);
            this.txtStad.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(748, 381);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 22);
            this.txtEmail.TabIndex = 18;
            // 
            // txtTelefoon
            // 
            this.txtTelefoon.Location = new System.Drawing.Point(745, 460);
            this.txtTelefoon.Name = "txtTelefoon";
            this.txtTelefoon.Size = new System.Drawing.Size(190, 22);
            this.txtTelefoon.TabIndex = 19;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(860, 521);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(113, 80);
            this.btnTerug.TabIndex = 0;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWijzig
            // 
            this.btnWijzig.BackColor = System.Drawing.Color.Gold;
            this.btnWijzig.Location = new System.Drawing.Point(727, 521);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(113, 80);
            this.btnWijzig.TabIndex = 20;
            this.btnWijzig.Text = "Wijzig";
            this.btnWijzig.UseVisualStyleBackColor = false;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(746, 179);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(189, 22);
            this.txtAdress.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(740, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Adress";
            // 
            // btnDeselect
            // 
            this.btnDeselect.BackColor = System.Drawing.Color.MistyRose;
            this.btnDeselect.BackgroundImage = global::Aquapalaca.Properties.Resources.deselect;
            this.btnDeselect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeselect.Location = new System.Drawing.Point(657, 4);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(50, 43);
            this.btnDeselect.TabIndex = 23;
            this.btnDeselect.UseVisualStyleBackColor = false;
            this.btnDeselect.Click += new System.EventHandler(this.btnDeselect_Click);
            // 
            // medewerkerKlanten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aquapalaca.Properties.Resources.output;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 617);
            this.Controls.Add(this.btnDeselect);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnWijzig);
            this.Controls.Add(this.txtTelefoon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtStad);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFilterKlant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxKlanten);
            this.Controls.Add(this.btnTerug);
            this.Name = "medewerkerKlanten";
            this.Text = "medewerkerKlanten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbxKlanten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFilterKlant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtStad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefoon;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeselect;
    }
}