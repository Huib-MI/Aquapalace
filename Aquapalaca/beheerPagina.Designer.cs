namespace Aquapalaca
{
    partial class beheerPagina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(beheerPagina));
            this.btnUitloggen = new System.Windows.Forms.Button();
            this.BtnGebruikersoverzicht = new System.Windows.Forms.Button();
            this.BtnAanpassen = new System.Windows.Forms.Button();
            this.BtnAbonnementsoverzicht = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUitloggen
            // 
            this.btnUitloggen.Location = new System.Drawing.Point(671, 368);
            this.btnUitloggen.Name = "btnUitloggen";
            this.btnUitloggen.Size = new System.Drawing.Size(117, 51);
            this.btnUitloggen.TabIndex = 0;
            this.btnUitloggen.Text = "Uitloggen";
            this.btnUitloggen.UseVisualStyleBackColor = true;
            this.btnUitloggen.Click += new System.EventHandler(this.btnUitloggen_Click);
            // 
            // BtnGebruikersoverzicht
            // 
            this.BtnGebruikersoverzicht.Location = new System.Drawing.Point(32, 63);
            this.BtnGebruikersoverzicht.Name = "BtnGebruikersoverzicht";
            this.BtnGebruikersoverzicht.Size = new System.Drawing.Size(161, 67);
            this.BtnGebruikersoverzicht.TabIndex = 1;
            this.BtnGebruikersoverzicht.Text = "Gebruikersoverzicht";
            this.BtnGebruikersoverzicht.UseVisualStyleBackColor = true;
            this.BtnGebruikersoverzicht.Click += new System.EventHandler(this.BtnGebruikersoverzicht_Click);
            // 
            // BtnAanpassen
            // 
            this.BtnAanpassen.Location = new System.Drawing.Point(32, 184);
            this.BtnAanpassen.Name = "BtnAanpassen";
            this.BtnAanpassen.Size = new System.Drawing.Size(161, 67);
            this.BtnAanpassen.TabIndex = 2;
            this.BtnAanpassen.Text = "Aanpassen";
            this.BtnAanpassen.UseVisualStyleBackColor = true;
            // 
            // BtnAbonnementsoverzicht
            // 
            this.BtnAbonnementsoverzicht.Location = new System.Drawing.Point(32, 301);
            this.BtnAbonnementsoverzicht.Name = "BtnAbonnementsoverzicht";
            this.BtnAbonnementsoverzicht.Size = new System.Drawing.Size(161, 67);
            this.BtnAbonnementsoverzicht.TabIndex = 5;
            this.BtnAbonnementsoverzicht.Text = " abonementen";
            this.BtnAbonnementsoverzicht.UseVisualStyleBackColor = true;
            this.BtnAbonnementsoverzicht.Click += new System.EventHandler(this.BtnAbonnementsoverzicht_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 22);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(391, 53);
            this.label1.TabIndex = 6;
            this.label1.Text = "AquaPalace LVS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Aquapalaca.Properties.Resources.output;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(247, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // beheerPagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aquapalaca.Properties.Resources.output;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAbonnementsoverzicht);
            this.Controls.Add(this.BtnAanpassen);
            this.Controls.Add(this.BtnGebruikersoverzicht);
            this.Controls.Add(this.btnUitloggen);
            this.Name = "beheerPagina";
            this.Text = " ";
            this.Load += new System.EventHandler(this.beheerPagina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUitloggen;
        private System.Windows.Forms.Button BtnGebruikersoverzicht;
        private System.Windows.Forms.Button BtnAanpassen;
        private System.Windows.Forms.Button BtnAbonnementsoverzicht;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}