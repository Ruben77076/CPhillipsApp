namespace ConocoApplication.Countries
{
    partial class FormNorway
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
            pixNorway = new PictureBox();
            txtNorway = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pixNorway).BeginInit();
            SuspendLayout();
            // 
            // pixNorway
            // 
            pixNorway.Image = Properties.Resources.conocoGlobe;
            pixNorway.Location = new Point(2, 0);
            pixNorway.Name = "pixNorway";
            pixNorway.Size = new Size(1752, 830);
            pixNorway.SizeMode = PictureBoxSizeMode.StretchImage;
            pixNorway.TabIndex = 0;
            pixNorway.TabStop = false;
            // 
            // txtNorway
            // 
            txtNorway.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNorway.Location = new Point(948, 126);
            txtNorway.Multiline = true;
            txtNorway.Name = "txtNorway";
            txtNorway.Size = new Size(280, 131);
            txtNorway.TabIndex = 1;
            txtNorway.Text = "6 million ppm";
            // 
            // FormNorway
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 829);
            Controls.Add(txtNorway);
            Controls.Add(pixNorway);
            Name = "FormNorway";
            Text = "ConocoPhillips Global Map";
            ((System.ComponentModel.ISupportInitialize)pixNorway).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pixNorway;
        private TextBox txtNorway;
    }
}