namespace ConocoApplication.Countries
{
    partial class FormUSA
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
            pixUSA = new PictureBox();
            txtUSA = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pixUSA).BeginInit();
            SuspendLayout();
            // 
            // pixUSA
            // 
            pixUSA.Image = Properties.Resources.conocoGlobe;
            pixUSA.Location = new Point(-1, 0);
            pixUSA.Name = "pixUSA";
            pixUSA.Size = new Size(1756, 832);
            pixUSA.TabIndex = 0;
            pixUSA.TabStop = false;
            // 
            // txtUSA
            // 
            txtUSA.BackColor = SystemColors.ActiveCaption;
            txtUSA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUSA.Location = new Point(231, 99);
            txtUSA.Multiline = true;
            txtUSA.Name = "txtUSA";
            txtUSA.Size = new Size(443, 202);
            txtUSA.TabIndex = 1;
            txtUSA.Text = "8,441 thousand tonnes";
            txtUSA.TextAlign = HorizontalAlignment.Center;
            // 
            // FormUSA
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 829);
            Controls.Add(txtUSA);
            Controls.Add(pixUSA);
            Name = "FormUSA";
            Text = "ConocoPhillips Global Map";
            ((System.ComponentModel.ISupportInitialize)pixUSA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pixUSA;
        private TextBox txtUSA;
    }
}