namespace Aquapalaca
{
    partial class medewerkerInchecken
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCheckin = new System.Windows.Forms.ComboBox();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.lblCheckin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(308, 144);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(75, 51);
            this.btnTerug.TabIndex = 0;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(208, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Klant inchecken";
            // 
            // cmbCheckin
            // 
            this.cmbCheckin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCheckin.FormattingEnabled = true;
            this.cmbCheckin.Location = new System.Drawing.Point(91, 63);
            this.cmbCheckin.Name = "cmbCheckin";
            this.cmbCheckin.Size = new System.Drawing.Size(152, 24);
            this.cmbCheckin.TabIndex = 12;
            this.cmbCheckin.SelectedIndexChanged += new System.EventHandler(this.cmbCheckin_SelectedIndexChanged);
            // 
            // btnCheckin
            // 
            this.btnCheckin.BackColor = System.Drawing.Color.Chartreuse;
            this.btnCheckin.Location = new System.Drawing.Point(286, 43);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(97, 30);
            this.btnCheckin.TabIndex = 13;
            this.btnCheckin.Text = "Inchecken";
            this.btnCheckin.UseVisualStyleBackColor = false;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckin.Location = new System.Drawing.Point(69, 106);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(153, 16);
            this.lblCheckin.TabIndex = 14;
            this.lblCheckin.Text = "✅ Welkom Medewerker!";
            // 
            // medewerkerInchecken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aquapalaca.Properties.Resources.output;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(395, 207);
            this.Controls.Add(this.lblCheckin);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.cmbCheckin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTerug);
            this.Name = "medewerkerInchecken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "medewerkerInchecken";
            this.Load += new System.EventHandler(this.medewerkerInchecken_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCheckin;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Label lblCheckin;
    }
}