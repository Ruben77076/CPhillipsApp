namespace ConocoApplication.Countries
{
    partial class FormUK
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
            pixUK = new PictureBox();
            txtUK = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pixUK).BeginInit();
            SuspendLayout();
            // 
            // pixUK
            // 
            pixUK.Image = Properties.Resources.conocoGlobe;
            pixUK.Location = new Point(2, -1);
            pixUK.Name = "pixUK";
            pixUK.Size = new Size(1753, 830);
            pixUK.SizeMode = PictureBoxSizeMode.StretchImage;
            pixUK.TabIndex = 0;
            pixUK.TabStop = false;
            // 
            // txtUK
            // 
            txtUK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUK.Location = new Point(644, 234);
            txtUK.Multiline = true;
            txtUK.Name = "txtUK";
            txtUK.Size = new Size(362, 193);
            txtUK.TabIndex = 1;
            txtUK.Text = "5 million ppm";
            // 
            // FormUK
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 829);
            Controls.Add(txtUK);
            Controls.Add(pixUK);
            Name = "FormUK";
            Text = "ConocoPhillips Global Map";
            ((System.ComponentModel.ISupportInitialize)pixUK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pixUK;
        private TextBox txtUK;
    }
}