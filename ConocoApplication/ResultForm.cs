using ConocoApplication.Countries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConocoApplication
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            this.Shown += new EventHandler(ResultForm_Shown);

        }
        private void ResultForm_Shown(object sender, EventArgs e)
        {
            this.headingLabel.Text = Form1.country + "'s sustainability report";
            this.barHeading.Text = Form1.country + "'s sustainability report";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tabControl1.SelectedTab == tabMap)
            //{
            //    //FormUSA.ActiveForm.Visible = true;
            //    FormUSA formUSA = new FormUSA();

            //    tabControl1.Controls.Add(formUSA);
            //    formUSA.Dock = DockStyle.Bottom;
            //    formUSA.Show();

            //    //Form2 frm = new Form2();
            //    //frm.TopLevel = false;
            //    //tabPage1.Controls.Add(frm);
            //    //frm.Dock = DockStyle.Fill;
            //    //frm.Show();
            //}


        }

        private void tabBar_Click(object sender, EventArgs e)
        {
            barHeading.Text = Form1.country + "'s sustainability report";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Form1.country == "USA")
            {
                pictureBox1.Image = Properties.Resources.usa;
            }
            else
            {
                return;
            }
        }
    }
}
