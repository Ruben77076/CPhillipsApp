namespace ConocoApplication.Countries
{
    partial class FormAlaska
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
            pictureBox1 = new PictureBox();
            alaskaTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.conocoGlobe;
            pictureBox1.Location = new Point(-2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1754, 835);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // alaskaTxt
            // 
            alaskaTxt.BackColor = SystemColors.ActiveCaption;
            alaskaTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alaskaTxt.Location = new Point(198, 116);
            alaskaTxt.Multiline = true;
            alaskaTxt.Name = "alaskaTxt";
            alaskaTxt.Size = new Size(382, 245);
            alaskaTxt.TabIndex = 1;
            alaskaTxt.Text = "1 million ppm";
            // 
            // FormAlaska
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 829);
            Controls.Add(alaskaTxt);
            Controls.Add(pictureBox1);
            Name = "FormAlaska";
            Text = "ConocoPhillips Global Map";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox alaskaTxt;
    }
}