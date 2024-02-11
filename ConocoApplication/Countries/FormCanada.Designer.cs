namespace ConocoApplication.Countries
{
    partial class FormCanada
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
            pixCanada = new PictureBox();
            txtCanada = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pixCanada).BeginInit();
            SuspendLayout();
            // 
            // pixCanada
            // 
            pixCanada.Image = Properties.Resources.conocoGlobe;
            pixCanada.Location = new Point(1, 3);
            pixCanada.Name = "pixCanada";
            pixCanada.Size = new Size(1753, 823);
            pixCanada.SizeMode = PictureBoxSizeMode.StretchImage;
            pixCanada.TabIndex = 0;
            pixCanada.TabStop = false;
            // 
            // txtCanada
            // 
            txtCanada.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCanada.Location = new Point(210, 241);
            txtCanada.Multiline = true;
            txtCanada.Name = "txtCanada";
            txtCanada.Size = new Size(445, 174);
            txtCanada.TabIndex = 1;
            txtCanada.Text = "2 million ppm";
            // 
            // FormCanada
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 829);
            Controls.Add(txtCanada);
            Controls.Add(pixCanada);
            Name = "FormCanada";
            Text = "ConocoPhillips Global Map";
            ((System.ComponentModel.ISupportInitialize)pixCanada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pixCanada;
        private TextBox txtCanada;
    }
}