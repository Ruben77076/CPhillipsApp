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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            tabMap = new TabPage();
            headingLabel = new Label();
            tabBar = new TabPage();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            barHeading = new Label();
            tabControl1 = new TabControl();
            colorDialog1 = new ColorDialog();
            label2 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tabMap.SuspendLayout();
            tabBar.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabMap
            // 
            tabMap.BackgroundImage = Properties.Resources.CP_lngPlant;
            tabMap.BackgroundImageLayout = ImageLayout.Stretch;
            tabMap.Controls.Add(headingLabel);
            tabMap.Location = new Point(4, 24);
            tabMap.Name = "tabMap";
            tabMap.Padding = new Padding(3);
            tabMap.Size = new Size(730, 323);
            tabMap.TabIndex = 0;
            tabMap.Text = "Global Map";
            tabMap.UseVisualStyleBackColor = true;
            tabMap.Click += tabPage1_Click;
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Segoe UI", 30F);
            headingLabel.Location = new Point(151, -9);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(413, 54);
            headingLabel.TabIndex = 1;
            headingLabel.Text = " 's sustanability report";
            headingLabel.Click += label1_Click;
            // 
            // tabBar
            // 
            tabBar.BackgroundImage = Properties.Resources.CP_alaska;
            tabBar.BackgroundImageLayout = ImageLayout.Stretch;
            tabBar.Controls.Add(label12);
            tabBar.Controls.Add(label11);
            tabBar.Controls.Add(label10);
            tabBar.Controls.Add(label9);
            tabBar.Controls.Add(label8);
            tabBar.Controls.Add(label2);
            tabBar.Controls.Add(label7);
            tabBar.Controls.Add(label6);
            tabBar.Controls.Add(label5);
            tabBar.Controls.Add(label4);
            tabBar.Controls.Add(label3);
            tabBar.Controls.Add(label1);
            tabBar.Controls.Add(panel6);
            tabBar.Controls.Add(panel5);
            tabBar.Controls.Add(panel4);
            tabBar.Controls.Add(panel3);
            tabBar.Controls.Add(panel2);
            tabBar.Controls.Add(panel1);
            tabBar.Controls.Add(barHeading);
            tabBar.Location = new Point(4, 24);
            tabBar.Name = "tabBar";
            tabBar.Padding = new Padding(3);
            tabBar.Size = new Size(730, 323);
            tabBar.TabIndex = 1;
            tabBar.Text = "Bar Graph";
            tabBar.UseVisualStyleBackColor = true;
            tabBar.Click += tabBar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(395, 268);
            label7.Name = "label7";
            label7.Size = new Size(61, 30);
            label7.TabIndex = 11;
            label7.Text = "2020";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(160, 268);
            label6.Name = "label6";
            label6.Size = new Size(61, 30);
            label6.TabIndex = 10;
            label6.Text = "2018";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(279, 268);
            label5.Name = "label5";
            label5.Size = new Size(61, 30);
            label5.TabIndex = 9;
            label5.Text = "2019";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(533, 268);
            label4.Name = "label4";
            label4.Size = new Size(61, 30);
            label4.TabIndex = 8;
            label4.Text = "2021";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(648, 268);
            label3.Name = "label3";
            label3.Size = new Size(61, 30);
            label3.TabIndex = 7;
            label3.Text = "2022";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(38, 268);
            label1.Name = "label1";
            label1.Size = new Size(61, 30);
            label1.TabIndex = 5;
            label1.Text = "2016";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(648, 121);
            panel6.Name = "panel6";
            panel6.Size = new Size(76, 128);
            panel6.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(533, 179);
            panel5.Name = "panel5";
            panel5.Size = new Size(76, 70);
            panel5.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(395, 225);
            panel4.Name = "panel4";
            panel4.Size = new Size(76, 24);
            panel4.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(279, 195);
            panel3.Name = "panel3";
            panel3.Size = new Size(76, 54);
            panel3.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(160, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(76, 93);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(38, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(76, 160);
            panel1.TabIndex = 3;
            // 
            // barHeading
            // 
            barHeading.AutoSize = true;
            barHeading.Font = new Font("Segoe UI", 30F);
            barHeading.Location = new Point(160, 0);
            barHeading.Name = "barHeading";
            barHeading.Size = new Size(413, 54);
            barHeading.TabIndex = 2;
            barHeading.Text = " 's sustanability report";
            barHeading.Click += label1_Click_1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabBar);
            tabControl1.Controls.Add(tabMap);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(738, 351);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 58);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 12;
            label2.Text = "7100";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(160, 122);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 13;
            label8.Text = "3459";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(279, 167);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 14;
            label9.Text = "2056";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(648, 88);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 15;
            label10.Text = "5000 tonnes";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(533, 137);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 16;
            label11.Text = "4500 tonnes";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(395, 195);
            label12.Name = "label12";
            label12.Size = new Size(64, 15);
            label12.TabIndex = 17;
            label12.Text = "900 tonnes";
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(738, 351);
            Controls.Add(tabControl1);
            Name = "ResultForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConocoPhillips Sustainability";
            Load += ResultForm_Load;
            tabMap.ResumeLayout(false);
            tabMap.PerformLayout();
            tabBar.ResumeLayout(false);
            tabBar.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private TabPage tabMap;
        private Label headingLabel;
        private TabPage tabBar;
        private Label barHeading;
        private TabControl tabControl1;
        private Panel panel1;
        private ColorDialog colorDialog1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label2;
    }
}