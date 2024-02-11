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
<<<<<<< HEAD
            label2 = new Label();
=======
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
>>>>>>> 8162aac89d6ea3dc267deb91ea4e2520fe92f4de
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Country:";
            label1.Click += label1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(32, 119);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(50, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "2022";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(32, 144);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(50, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "2023";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "USA", "Canada", "Norway/UK", "Australia", "All Others", "Total" });
            comboBox1.Location = new Point(32, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "CO2 from Operations", "CO2 from Imported Electricity", "Methane (CO2e)", "Nitrous Oxide (CO2e)", "Total Greenhouse Gasses" });
            comboBox2.Location = new Point(233, 53);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(160, 23);
            comboBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 27);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 5;
            label2.Text = "Quality:";
            // 
            // button1
            // 
            button1.Location = new Point(318, 176);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Fetch";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 92);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Year(s)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 232);
            label2.Name = "label2";
            label2.Size = new Size(198, 32);
            label2.TabIndex = 1;
            label2.Text = "Can u c this one?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
=======
            ClientSize = new Size(431, 211);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
>>>>>>> 8162aac89d6ea3dc267deb91ea4e2520fe92f4de
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
<<<<<<< HEAD
        private Label label2;
=======
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Button button1;
        private Label label3;
>>>>>>> 8162aac89d6ea3dc267deb91ea4e2520fe92f4de
    }
}
