namespace ConocoApplication.Countries
{
    partial class FormColumbia
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
            pixColumbia = new PictureBox();
            txtColumbia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pixColumbia).BeginInit();
            SuspendLayout();
            // 
            // pixColumbia
            // 
            pixColumbia.Image = Properties.Resources.conocoGlobe;
            pixColumbia.Location = new Point(-1, 0);
            pixColumbia.Name = "pixColumbia";
            pixColumbia.Size = new Size(1757, 827);
            pixColumbia.SizeMode = PictureBoxSizeMode.StretchImage;
            pixColumbia.TabIndex = 0;
            pixColumbia.TabStop = false;
            // 
            // txtColumbia
            // 
            txtColumbia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtColumbia.Location = new Point(301, 298);
            txtColumbia.Multiline = true;
            txtColumbia.Name = "txtColumbia";
            txtColumbia.Size = new Size(418, 146);
            txtColumbia.TabIndex = 1;
            txtColumbia.Text = "4 million ppm";
            // 
            // FormColumbia
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 829);
            Controls.Add(txtColumbia);
            Controls.Add(pixColumbia);
            Name = "FormColumbia";
            Text = "ConocoPhillips Global Map";
            ((System.ComponentModel.ISupportInitialize)pixColumbia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pixColumbia;
        private TextBox txtColumbia;
    }
}