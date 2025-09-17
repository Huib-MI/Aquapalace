namespace Aquapalaca
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInlgpagina = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGebruikersnaam = new System.Windows.Forms.Label();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.Location = new System.Drawing.Point(381, 203);
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(111, 22);
            this.txtGebruikersnaam.TabIndex = 0;
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.Location = new System.Drawing.Point(381, 247);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.Size = new System.Drawing.Size(111, 22);
            this.txtWachtwoord.TabIndex = 1;
            // 
            // btnInloggen
            // 
            this.btnInloggen.BackColor = System.Drawing.Color.White;
            this.btnInloggen.FlatAppearance.BorderSize = 0;
            this.btnInloggen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInloggen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInloggen.Location = new System.Drawing.Point(282, 282);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(178, 58);
            this.btnInloggen.TabIndex = 2;
            this.btnInloggen.Text = "Inloggen";
            this.btnInloggen.UseVisualStyleBackColor = false;
            this.btnInloggen.Click += new System.EventHandler(this.btnInloggen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aquapalaca.Properties.Resources._003366;
            this.pictureBox1.Location = new System.Drawing.Point(214, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 245);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblInlgpagina
            // 
            this.lblInlgpagina.AutoSize = true;
            this.lblInlgpagina.BackColor = System.Drawing.Color.Transparent;
            this.lblInlgpagina.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInlgpagina.ForeColor = System.Drawing.Color.White;
            this.lblInlgpagina.Image = global::Aquapalaca.Properties.Resources._003366;
            this.lblInlgpagina.Location = new System.Drawing.Point(298, 145);
            this.lblInlgpagina.Name = "lblInlgpagina";
            this.lblInlgpagina.Size = new System.Drawing.Size(130, 25);
            this.lblInlgpagina.TabIndex = 4;
            this.lblInlgpagina.Text = "Inlogpagina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 42);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(391, 53);
            this.label1.TabIndex = 5;
            this.label1.Text = "AquaPalace LVS";
            // 
            // lblGebruikersnaam
            // 
            this.lblGebruikersnaam.AutoSize = true;
            this.lblGebruikersnaam.BackColor = System.Drawing.Color.White;
            this.lblGebruikersnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruikersnaam.ForeColor = System.Drawing.Color.White;
            this.lblGebruikersnaam.Image = global::Aquapalaca.Properties.Resources._003366;
            this.lblGebruikersnaam.Location = new System.Drawing.Point(230, 206);
            this.lblGebruikersnaam.Name = "lblGebruikersnaam";
            this.lblGebruikersnaam.Size = new System.Drawing.Size(121, 15);
            this.lblGebruikersnaam.TabIndex = 6;
            this.lblGebruikersnaam.Text = "Gebruikersnaam :";
            this.lblGebruikersnaam.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.BackColor = System.Drawing.Color.White;
            this.lblWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWachtwoord.ForeColor = System.Drawing.Color.White;
            this.lblWachtwoord.Image = global::Aquapalaca.Properties.Resources._003366;
            this.lblWachtwoord.Location = new System.Drawing.Point(255, 247);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(93, 15);
            this.lblWachtwoord.TabIndex = 7;
            this.lblWachtwoord.Text = "Wachtwoord :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Aquapalaca.Properties.Resources.output;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(102, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Aquapalaca.Properties.Resources.output;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblWachtwoord);
            this.Controls.Add(this.lblGebruikersnaam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInlgpagina);
            this.Controls.Add(this.btnInloggen);
            this.Controls.Add(this.txtGebruikersnaam);
            this.Controls.Add(this.txtWachtwoord);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.Button btnInloggen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInlgpagina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGebruikersnaam;
        private System.Windows.Forms.Label lblWachtwoord;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

