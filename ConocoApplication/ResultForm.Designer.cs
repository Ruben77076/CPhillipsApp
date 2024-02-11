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
            controlTab1 = new TabPage();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Segoe UI", 30F);
            headingLabel.Location = new Point(234, 9);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(413, 54);
            headingLabel.TabIndex = 0;
            headingLabel.Text = " 's sustanability report";
            headingLabel.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(controlTab1);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 139);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 311);
            tabControl1.TabIndex = 1;
            // 
            // controlTab1
            // 
            controlTab1.Location = new Point(4, 24);
            controlTab1.Name = "controlTab1";
            controlTab1.Padding = new Padding(3);
            controlTab1.Size = new Size(792, 283);
            controlTab1.TabIndex = 0;
            controlTab1.Text = "Other";
            controlTab1.UseVisualStyleBackColor = true;
            controlTab1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 283);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bar Graph";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(headingLabel);
            Controls.Add(tabControl1);
            Name = "ResultForm";
            Text = "ResultForm";
            Load += ResultForm_Load;
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headingLabel;
        private TabControl tabControl1;
        private TabPage controlTab1;
        private TabPage tabPage2;
    }
}