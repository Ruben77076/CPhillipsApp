namespace ConocoApplication.Countries
{
    partial class FormMalaysia
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
            pixMalaysia = new PictureBox();
            txtMalaysia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pixMalaysia).BeginInit();
            SuspendLayout();
            // 
            // pixMalaysia
            // 
            pixMalaysia.Image = Properties.Resources.conocoGlobe;
            pixMalaysia.Location = new Point(2, 2);
            pixMalaysia.Name = "pixMalaysia";
            pixMalaysia.Size = new Size(1752, 829);
            pixMalaysia.SizeMode = PictureBoxSizeMode.StretchImage;
            pixMalaysia.TabIndex = 0;
            pixMalaysia.TabStop = false;
            // 
            // txtMalaysia
            // 
            txtMalaysia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMalaysia.Location = new Point(1318, 524);
            txtMalaysia.Multiline = true;
            txtMalaysia.Name = "txtMalaysia";
            txtMalaysia.Size = new Size(280, 123);
            txtMalaysia.TabIndex = 1;
            txtMalaysia.Text = "13 million ppm";
            // 
            // FormMalaysia
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 829);
            Controls.Add(txtMalaysia);
            Controls.Add(pixMalaysia);
            Name = "FormMalaysia";
            Text = "ConocoPhillips Global Map";
            ((System.ComponentModel.ISupportInitialize)pixMalaysia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pixMalaysia;
        private TextBox txtMalaysia;
    }
}