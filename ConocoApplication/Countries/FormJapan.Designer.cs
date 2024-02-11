namespace ConocoApplication.Countries
{
    partial class FormJapan
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
            pixJapan = new PictureBox();
            txtJapan = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pixJapan).BeginInit();
            SuspendLayout();
            // 
            // pixJapan
            // 
            pixJapan.Image = Properties.Resources.conocoGlobe;
            pixJapan.Location = new Point(0, 1);
            pixJapan.Name = "pixJapan";
            pixJapan.Size = new Size(1757, 827);
            pixJapan.SizeMode = PictureBoxSizeMode.StretchImage;
            pixJapan.TabIndex = 0;
            pixJapan.TabStop = false;
            // 
            // txtJapan
            // 
            txtJapan.Location = new Point(1188, 223);
            txtJapan.Multiline = true;
            txtJapan.Name = "txtJapan";
            txtJapan.Size = new Size(282, 155);
            txtJapan.TabIndex = 1;
            txtJapan.Text = "9 million ppm";
            // 
            // FormJapan
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 829);
            Controls.Add(txtJapan);
            Controls.Add(pixJapan);
            Name = "FormJapan";
            Text = "ConocoPhillips Global Map";
            ((System.ComponentModel.ISupportInitialize)pixJapan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pixJapan;
        private TextBox txtJapan;
    }
}