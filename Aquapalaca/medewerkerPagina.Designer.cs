namespace Aquapalaca
{
    partial class medewerkerPagina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medewerkerPagina));
            this.btnUitloggen = new System.Windows.Forms.Button();
            this.btnAbonnementen = new System.Windows.Forms.Button();
            this.btnKlanten = new System.Windows.Forms.Button();
            this.btnInchecken = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUitloggen
            // 
            this.btnUitloggen.Location = new System.Drawing.Point(633, 212);
            this.btnUitloggen.Name = "btnUitloggen";
            this.btnUitloggen.Size = new System.Drawing.Size(137, 91);
            this.btnUitloggen.TabIndex = 0;
            this.btnUitloggen.Text = "Uitloggen";
            this.btnUitloggen.UseVisualStyleBackColor = true;
            this.btnUitloggen.Click += new System.EventHandler(this.btnUitloggen_Click);
            // 
            // btnAbonnementen
            // 
            this.btnAbonnementen.Location = new System.Drawing.Point(12, 125);
            this.btnAbonnementen.Name = "btnAbonnementen";
            this.btnAbonnementen.Size = new System.Drawing.Size(169, 58);
            this.btnAbonnementen.TabIndex = 1;
            this.btnAbonnementen.Text = "Abonnementen";
            this.btnAbonnementen.UseVisualStyleBackColor = true;
            this.btnAbonnementen.Click += new System.EventHandler(this.btnAbonnementen_Click);
            // 
            // btnKlanten
            // 
            this.btnKlanten.Location = new System.Drawing.Point(12, 229);
            this.btnKlanten.Name = "btnKlanten";
            this.btnKlanten.Size = new System.Drawing.Size(169, 56);
            this.btnKlanten.TabIndex = 2;
            this.btnKlanten.Text = "Klanten";
            this.btnKlanten.UseVisualStyleBackColor = true;
            this.btnKlanten.Click += new System.EventHandler(this.btnKlanten_Click);
            // 
            // btnInchecken
            // 
            this.btnInchecken.Location = new System.Drawing.Point(12, 341);
            this.btnInchecken.Name = "btnInchecken";
            this.btnInchecken.Size = new System.Drawing.Size(169, 56);
            this.btnInchecken.TabIndex = 3;
            this.btnInchecken.Text = "Inchecken";
            this.btnInchecken.UseVisualStyleBackColor = true;
            this.btnInchecken.Click += new System.EventHandler(this.btnInchecken_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 23);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(304, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "AquaPalace LVS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Aquapalaca.Properties.Resources.output;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(248, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // medewerkerPagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aquapalaca.Properties.Resources.output;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInchecken);
            this.Controls.Add(this.btnKlanten);
            this.Controls.Add(this.btnAbonnementen);
            this.Controls.Add(this.btnUitloggen);
            this.Name = "medewerkerPagina";
            this.Text = "medewerkerPagina";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUitloggen;
        private System.Windows.Forms.Button btnAbonnementen;
        private System.Windows.Forms.Button btnKlanten;
        private System.Windows.Forms.Button btnInchecken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}