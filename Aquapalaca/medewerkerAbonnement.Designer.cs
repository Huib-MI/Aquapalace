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
            this.btnTerug = new System.Windows.Forms.Button();
            this.lbxAbonnement = new System.Windows.Forms.ListBox();
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
            this.lbxAbonnement.Location = new System.Drawing.Point(12, 28);
            this.lbxAbonnement.Name = "lbxAbonnement";
            this.lbxAbonnement.Size = new System.Drawing.Size(892, 388);
            this.lbxAbonnement.TabIndex = 1;
            // 
            // medewerkerAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aquapalaca.Properties.Resources.output;
            this.ClientSize = new System.Drawing.Size(1076, 450);
            this.Controls.Add(this.lbxAbonnement);
            this.Controls.Add(this.btnTerug);
            this.Name = "medewerkerAbonnement";
            this.Text = "medewerkerAbonnement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.ListBox lbxAbonnement;
    }
}