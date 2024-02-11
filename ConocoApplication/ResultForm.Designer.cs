namespace ConocoApplication
{
    partial class ResultForm
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
            headingLabel = new Label();
            tabControl1 = new TabControl();
            tabBar = new TabPage();
            barHeading = new Label();
            tabMap = new TabPage();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabBar.SuspendLayout();
            tabMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Segoe UI", 30F);
            headingLabel.Location = new Point(281, -19);
            headingLabel.Margin = new Padding(6, 0, 6, 0);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(819, 106);
            headingLabel.TabIndex = 1;
            headingLabel.Text = " 's sustanability report";
            headingLabel.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabBar);
            tabControl1.Controls.Add(tabMap);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1486, 960);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabBar
            // 
            tabBar.BackgroundImage = Properties.Resources.CP_alaska;
            tabBar.BackgroundImageLayout = ImageLayout.Stretch;
            tabBar.Controls.Add(barHeading);
            tabBar.Location = new Point(8, 46);
            tabBar.Margin = new Padding(6);
            tabBar.Name = "tabBar";
            tabBar.Padding = new Padding(6);
            tabBar.Size = new Size(1470, 906);
            tabBar.TabIndex = 1;
            tabBar.Text = "Bar Graph";
            tabBar.UseVisualStyleBackColor = true;
            tabBar.Click += tabBar_Click;
            // 
            // barHeading
            // 
            barHeading.AutoSize = true;
            barHeading.Font = new Font("Segoe UI", 30F);
            barHeading.Location = new Point(297, 0);
            barHeading.Margin = new Padding(6, 0, 6, 0);
            barHeading.Name = "barHeading";
            barHeading.Size = new Size(819, 106);
            barHeading.TabIndex = 2;
            barHeading.Text = " 's sustanability report";
            barHeading.Click += label1_Click_1;
            // 
            // tabMap
            // 
            tabMap.BackgroundImage = Properties.Resources.CP_lngPlant;
            tabMap.BackgroundImageLayout = ImageLayout.Stretch;
            tabMap.Controls.Add(pictureBox1);
            tabMap.Controls.Add(headingLabel);
            tabMap.Location = new Point(8, 46);
            tabMap.Margin = new Padding(6);
            tabMap.Name = "tabMap";
            tabMap.Padding = new Padding(6);
            tabMap.Size = new Size(1470, 906);
            tabMap.TabIndex = 0;
            tabMap.Text = "Global Map";
            tabMap.UseVisualStyleBackColor = true;
            tabMap.Click += tabPage1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usa;
            pictureBox1.Location = new Point(46, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1360, 739);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1486, 960);
            Controls.Add(tabControl1);
            Margin = new Padding(6);
            Name = "ResultForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConocoPhillips Sustainability";
            Load += ResultForm_Load;
            tabControl1.ResumeLayout(false);
            tabBar.ResumeLayout(false);
            tabBar.PerformLayout();
            tabMap.ResumeLayout(false);
            tabMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label headingLabel;
        private TabControl tabControl1;
        private TabPage tabMap;
        private TabPage tabBar;
        private Label barHeading;
        private PictureBox pictureBox1;
    }
}