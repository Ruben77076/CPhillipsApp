namespace ConocoApplication.Countries
{
    partial class FormLibya
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
            pixLibya = new PictureBox();
            txtLibya = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pixLibya).BeginInit();
            SuspendLayout();
            // 
            // pixLibya
            // 
            pixLibya.Image = Properties.Resources.conocoGlobe;
            pixLibya.Location = new Point(1, 1);
            pixLibya.Name = "pixLibya";
            pixLibya.Size = new Size(1752, 829);
            pixLibya.SizeMode = PictureBoxSizeMode.StretchImage;
            pixLibya.TabIndex = 0;
            pixLibya.TabStop = false;
            // 
            // txtLibya
            // 
            txtLibya.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLibya.Location = new Point(790, 415);
            txtLibya.Multiline = true;
            txtLibya.Name = "txtLibya";
            txtLibya.Size = new Size(340, 138);
            txtLibya.TabIndex = 1;
            txtLibya.Text = "7 million ppm";
            // 
            // FormLibya
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 829);
            Controls.Add(txtLibya);
            Controls.Add(pixLibya);
            Name = "FormLibya";
            Text = "ConocoPhillips Global Map";
            ((System.ComponentModel.ISupportInitialize)pixLibya).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pixLibya;
        private TextBox txtLibya;
    }
}