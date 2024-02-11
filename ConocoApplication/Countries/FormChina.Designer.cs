namespace ConocoApplication.Countries
{
    partial class FormChina
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
            pixChina = new PictureBox();
            txtChina = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pixChina).BeginInit();
            SuspendLayout();
            // 
            // pixChina
            // 
            pixChina.Image = Properties.Resources.conocoGlobe;
            pixChina.Location = new Point(1, 0);
            pixChina.Name = "pixChina";
            pixChina.Size = new Size(1749, 829);
            pixChina.SizeMode = PictureBoxSizeMode.StretchImage;
            pixChina.TabIndex = 0;
            pixChina.TabStop = false;
            // 
            // txtChina
            // 
            txtChina.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChina.Location = new Point(1171, 67);
            txtChina.Multiline = true;
            txtChina.Name = "txtChina";
            txtChina.Size = new Size(362, 149);
            txtChina.TabIndex = 1;
            txtChina.Text = "8 million ppm";
            // 
            // FormChina
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 829);
            Controls.Add(txtChina);
            Controls.Add(pixChina);
            Name = "FormChina";
            Text = "ConocoPhillips Global Map";
            ((System.ComponentModel.ISupportInitialize)pixChina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pixChina;
        private TextBox txtChina;
    }
}