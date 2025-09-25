namespace Aquapalaca
{
    partial class Rolbeheer
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
            this.BtnUitloggen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnUitloggen
            // 
            this.BtnUitloggen.Location = new System.Drawing.Point(612, 350);
            this.BtnUitloggen.Name = "BtnUitloggen";
            this.BtnUitloggen.Size = new System.Drawing.Size(144, 52);
            this.BtnUitloggen.TabIndex = 4;
            this.BtnUitloggen.Text = "Terug";
            this.BtnUitloggen.UseVisualStyleBackColor = true;
            this.BtnUitloggen.Click += new System.EventHandler(this.BtnUitloggen_Click);
            // 
            // Rolbeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aquapalaca.Properties.Resources.output;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnUitloggen);
            this.Name = "Rolbeheer";
            this.Text = "Rolbeheer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnUitloggen;
    }
}