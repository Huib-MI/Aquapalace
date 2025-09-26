namespace Aquapalaca
{
    partial class klantGeschiedenis
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
            this.lbxKlantGeschiedenis = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTerug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerug.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTerug.Location = new System.Drawing.Point(12, 12);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(68, 38);
            this.btnTerug.TabIndex = 0;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = false;
            this.btnTerug.Click += new System.EventHandler(this.btnUitloggen_Click);
            // 
            // lbxKlantGeschiedenis
            // 
            this.lbxKlantGeschiedenis.FormattingEnabled = true;
            this.lbxKlantGeschiedenis.ItemHeight = 16;
            this.lbxKlantGeschiedenis.Location = new System.Drawing.Point(95, 12);
            this.lbxKlantGeschiedenis.Name = "lbxKlantGeschiedenis";
            this.lbxKlantGeschiedenis.Size = new System.Drawing.Size(295, 196);
            this.lbxKlantGeschiedenis.TabIndex = 1;
            // 
            // klantGeschiedenis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aquapalaca.Properties.Resources._3a1b12fa_d009_4264_8238_0820842ed812;
            this.ClientSize = new System.Drawing.Size(407, 223);
            this.Controls.Add(this.lbxKlantGeschiedenis);
            this.Controls.Add(this.btnTerug);
            this.Name = "klantGeschiedenis";
            this.Text = "klantGeschiedenis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.ListBox lbxKlantGeschiedenis;
    }
}