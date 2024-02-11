namespace ConocoApplication.Countries
{
    partial class FormQatar
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
            pixQatar = new PictureBox();
            txtQatar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pixQatar).BeginInit();
            SuspendLayout();
            // 
            // pixQatar
            // 
            pixQatar.Image = Properties.Resources.conocoGlobe;
            pixQatar.Location = new Point(0, 1);
            pixQatar.Name = "pixQatar";
            pixQatar.Size = new Size(1756, 831);
            pixQatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pixQatar.TabIndex = 0;
            pixQatar.TabStop = false;
            // 
            // txtQatar
            // 
            txtQatar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQatar.Location = new Point(735, 298);
            txtQatar.Multiline = true;
            txtQatar.Name = "txtQatar";
            txtQatar.Size = new Size(311, 148);
            txtQatar.TabIndex = 1;
            txtQatar.Text = "12 million ppm";
            // 
            // FormQatar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 829);
            Controls.Add(txtQatar);
            Controls.Add(pixQatar);
            Name = "FormQatar";
            Text = "ConocoPhillips Global Map";
            ((System.ComponentModel.ISupportInitialize)pixQatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pixQatar;
        private TextBox txtQatar;
    }
}