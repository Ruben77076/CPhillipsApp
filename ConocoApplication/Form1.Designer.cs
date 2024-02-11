namespace ConocoApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            ErrorLabel = new Label();
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 0;
            label1.Text = "Country:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 495);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(198, 32);
            label2.TabIndex = 1;
            label2.Text = "Can u c this one?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(59, 254);
            checkBox1.Margin = new Padding(6, 6, 6, 6);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 36);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "2022";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(59, 307);
            checkBox2.Margin = new Padding(6, 6, 6, 6);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(98, 36);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "2023";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "USA", "Canada", "Norway/UK", "Australia", "All Others", "Total" });
            comboBox1.Location = new Point(59, 113);
            comboBox1.Margin = new Padding(6, 6, 6, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 40);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "CO2 from Operations", "CO2 from Imported Electricity", "Methane (CO2e)", "Nitrous Oxide (CO2e)", "Total Greenhouse Gasses" });
            comboBox2.Location = new Point(433, 113);
            comboBox2.Margin = new Padding(6, 6, 6, 6);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(294, 40);
            comboBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 196);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 7;
            label3.Text = "Year(s)";
            // 
            // button1
            // 
            button1.Location = new Point(591, 375);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(139, 49);
            button1.TabIndex = 6;
            button1.Text = "Fetch";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Location = new Point(245, 254);
            ErrorLabel.Margin = new Padding(6, 0, 6, 0);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 32);
            ErrorLabel.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(433, 58);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 32);
            label4.TabIndex = 9;
            label4.Text = "Quality:";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.CP_rigs;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(ErrorLabel);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConocoPhillips Sustainability";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;



        //private Label label2;



        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;


        private Button button1;
        private Label ErrorLabel;

        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

    }
}
