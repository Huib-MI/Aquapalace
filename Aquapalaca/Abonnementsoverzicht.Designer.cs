namespace Aquapalaca
{
    partial class Abonnementsoverzicht
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abonnementsoverzicht));
            this.BtnAbonnementen = new System.Windows.Forms.Button();
            this.BtnKlanten = new System.Windows.Forms.Button();
            this.BtnInchecken = new System.Windows.Forms.Button();
            this.BtnUitloggen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvSubscriptions = new System.Windows.Forms.DataGridView();
            this.lbxAbonnement = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAbonnementen
            // 
            this.BtnAbonnementen.Location = new System.Drawing.Point(126, 96);
            this.BtnAbonnementen.Name = "BtnAbonnementen";
            this.BtnAbonnementen.Size = new System.Drawing.Size(144, 52);
            this.BtnAbonnementen.TabIndex = 0;
            this.BtnAbonnementen.Text = "Abonnementen";
            this.BtnAbonnementen.UseVisualStyleBackColor = true;
            // 
            // BtnKlanten
            // 
            this.BtnKlanten.Location = new System.Drawing.Point(324, 96);
            this.BtnKlanten.Name = "BtnKlanten";
            this.BtnKlanten.Size = new System.Drawing.Size(144, 52);
            this.BtnKlanten.TabIndex = 1;
            this.BtnKlanten.Text = "Klanten";
            this.BtnKlanten.UseVisualStyleBackColor = true;
            this.BtnKlanten.Click += new System.EventHandler(this.BtnKlanten_Click);
            // 
            // BtnInchecken
            // 
            this.BtnInchecken.Location = new System.Drawing.Point(532, 96);
            this.BtnInchecken.Name = "BtnInchecken";
            this.BtnInchecken.Size = new System.Drawing.Size(144, 52);
            this.BtnInchecken.TabIndex = 2;
            this.BtnInchecken.Text = "Inchecken";
            this.BtnInchecken.UseVisualStyleBackColor = true;
            // 
            // BtnUitloggen
            // 
            this.BtnUitloggen.Location = new System.Drawing.Point(644, 356);
            this.BtnUitloggen.Name = "BtnUitloggen";
            this.BtnUitloggen.Size = new System.Drawing.Size(144, 52);
            this.BtnUitloggen.TabIndex = 3;
            this.BtnUitloggen.Text = "Terug";
            this.BtnUitloggen.UseVisualStyleBackColor = true;
            this.BtnUitloggen.Click += new System.EventHandler(this.BtnUitloggen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Overzicht Abonnementen";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 21);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(391, 53);
            this.label1.TabIndex = 7;
            this.label1.Text = "AquaPalace LVS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Aquapalaca.Properties.Resources.output;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(209, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // dgvSubscriptions
            // 
            this.dgvSubscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubscriptions.Location = new System.Drawing.Point(12, 204);
            this.dgvSubscriptions.Name = "dgvSubscriptions";
            this.dgvSubscriptions.RowHeadersWidth = 51;
            this.dgvSubscriptions.RowTemplate.Height = 24;
            this.dgvSubscriptions.Size = new System.Drawing.Size(286, 204);
            this.dgvSubscriptions.TabIndex = 11;
            this.dgvSubscriptions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubscriptions_CellContentClick);
            // 
            // lbxAbonnement
            // 
            this.lbxAbonnement.FormattingEnabled = true;
            this.lbxAbonnement.ItemHeight = 16;
            this.lbxAbonnement.Location = new System.Drawing.Point(324, 204);
            this.lbxAbonnement.Name = "lbxAbonnement";
            this.lbxAbonnement.Size = new System.Drawing.Size(296, 212);
            this.lbxAbonnement.TabIndex = 12;
            this.lbxAbonnement.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Abonnementsoverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aquapalaca.Properties.Resources.output;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxAbonnement);
            this.Controls.Add(this.dgvSubscriptions);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnUitloggen);
            this.Controls.Add(this.BtnInchecken);
            this.Controls.Add(this.BtnKlanten);
            this.Controls.Add(this.BtnAbonnementen);
            this.Name = "Abonnementsoverzicht";
            this.Text = "Abonnementsoverzicht";
            this.Load += new System.EventHandler(this.Abonnementsoverzicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAbonnementen;
        private System.Windows.Forms.Button BtnKlanten;
        private System.Windows.Forms.Button BtnInchecken;
        private System.Windows.Forms.Button BtnUitloggen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvSubscriptions;
        private System.Windows.Forms.ListBox lbxAbonnement;
    }
}