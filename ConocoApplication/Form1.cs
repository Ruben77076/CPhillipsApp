namespace ConocoApplication
{
    public partial class Form1 : Form
    {
        public static string country;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "    -Choose one-";
            comboBox2.Text = "        -Choose one-";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if ((this.checkBox1.Checked || this.checkBox1.Checked) && this.comboBox1.SelectedIndex != -1 && this.comboBox2.SelectedIndex != -1)
            {
                this.Hide();
                ResultForm form = new ResultForm();
                form.Show();
            }
            else
            {
                this.ErrorLabel.Text = "Invalid: Select at least one option in all fields.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox1.Focus();
            country = (string)this.comboBox1.SelectedItem;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
