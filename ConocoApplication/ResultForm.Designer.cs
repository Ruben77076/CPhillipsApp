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
<<<<<<< HEAD
            tabPage2 = new TabPage();
            controlTab1 = new TabPage();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
=======
            tabBar = new TabPage();
            tabMap = new TabPage();
            barHeading = new Label();
            tabControl1.SuspendLayout();
            tabBar.SuspendLayout();
            tabMap.SuspendLayout();
>>>>>>> ef8332772d2218a3a941d8538351690a5eebcf60
            SuspendLayout();
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Segoe UI", 30F);
<<<<<<< HEAD
            headingLabel.Location = new Point(228, 28);
=======
            headingLabel.Location = new Point(281, -19);
            headingLabel.Margin = new Padding(6, 0, 6, 0);
>>>>>>> ef8332772d2218a3a941d8538351690a5eebcf60
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(819, 106);
            headingLabel.TabIndex = 1;
            headingLabel.Text = " 's sustanability report";
            headingLabel.Click += label1_Click;
            // 
            // tabControl1
            // 
<<<<<<< HEAD
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(controlTab1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(headingLabel);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bar Graph";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // controlTab1
            // 
            controlTab1.Location = new Point(4, 24);
            controlTab1.Name = "controlTab1";
            controlTab1.Padding = new Padding(3);
            controlTab1.Size = new Size(792, 422);
            controlTab1.TabIndex = 0;
            controlTab1.Text = "Other";
            controlTab1.UseVisualStyleBackColor = true;
            controlTab1.Click += tabPage1_Click;
            // 
=======
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
            // tabMap
            // 
            tabMap.BackgroundImage = Properties.Resources.CP_lngPlant;
            tabMap.BackgroundImageLayout = ImageLayout.Stretch;
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
>>>>>>> ef8332772d2218a3a941d8538351690a5eebcf60
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            ClientSize = new Size(800, 450);
=======
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1486, 960);
>>>>>>> ef8332772d2218a3a941d8538351690a5eebcf60
            Controls.Add(tabControl1);
            Margin = new Padding(6);
            Name = "ResultForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConocoPhillips Sustainability";
            Load += ResultForm_Load;
            tabControl1.ResumeLayout(false);
<<<<<<< HEAD
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
=======
            tabBar.ResumeLayout(false);
            tabBar.PerformLayout();
            tabMap.ResumeLayout(false);
            tabMap.PerformLayout();
>>>>>>> ef8332772d2218a3a941d8538351690a5eebcf60
            ResumeLayout(false);
        }

        #endregion

        private Label headingLabel;
        private TabControl tabControl1;
<<<<<<< HEAD
        private TabPage controlTab1;
        private TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
=======
        private TabPage tabMap;
        private TabPage tabBar;
        private Label barHeading;
>>>>>>> ef8332772d2218a3a941d8538351690a5eebcf60
    }
}