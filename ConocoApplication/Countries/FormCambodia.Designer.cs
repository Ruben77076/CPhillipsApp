namespace ConocoApplication.Countries
{
    partial class FormCambodia
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
            pixCambodia = new PictureBox();
            txtCambodia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pixCambodia).BeginInit();
            SuspendLayout();
            // 
            // pixCambodia
            // 
            pixCambodia.Image = Properties.Resources.conocoGlobe;
            pixCambodia.Location = new Point(-3, 3);
            pixCambodia.Name = "pixCambodia";
            pixCambodia.Size = new Size(1756, 826);
            pixCambodia.SizeMode = PictureBoxSizeMode.StretchImage;
            pixCambodia.TabIndex = 0;
            pixCambodia.TabStop = false;
            // 
            // txtCambodia
            // 
            txtCambodia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCambodia.Location = new Point(1222, 462);
            txtCambodia.Multiline = true;
            txtCambodia.Name = "txtCambodia";
            txtCambodia.Size = new Size(291, 103);
            txtCambodia.TabIndex = 1;
            txtCambodia.Text = "11 million ppm";
            // 
            // FormCambodia
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 829);
            Controls.Add(txtCambodia);
            Controls.Add(pixCambodia);
            Name = "FormCambodia";
            Text = "ConocoPhillips Global Map";
            ((System.ComponentModel.ISupportInitialize)pixCambodia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pixCambodia;
        private TextBox txtCambodia;
    }
}