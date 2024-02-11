namespace ConocoApplication.Countries
{
    partial class FormAustralia
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
            pixAustralia = new PictureBox();
            txtAustralia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pixAustralia).BeginInit();
            SuspendLayout();
            // 
            // pixAustralia
            // 
            pixAustralia.Image = Properties.Resources.conocoGlobe;
            pixAustralia.Location = new Point(-1, 1);
            pixAustralia.Name = "pixAustralia";
            pixAustralia.Size = new Size(1757, 829);
            pixAustralia.SizeMode = PictureBoxSizeMode.StretchImage;
            pixAustralia.TabIndex = 0;
            pixAustralia.TabStop = false;
            // 
            // txtAustralia
            // 
            txtAustralia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAustralia.Location = new Point(1087, 568);
            txtAustralia.Multiline = true;
            txtAustralia.Name = "txtAustralia";
            txtAustralia.Size = new Size(304, 145);
            txtAustralia.TabIndex = 1;
            txtAustralia.Text = "10 million ppm";
            // 
            // FormAustralia
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 829);
            Controls.Add(txtAustralia);
            Controls.Add(pixAustralia);
            Name = "FormAustralia";
            Text = "FormAustralia";
            ((System.ComponentModel.ISupportInitialize)pixAustralia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pixAustralia;
        private TextBox txtAustralia;
    }
}