namespace ConocoApplication
{
    public partial class Form1 : Form
    {
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
            if (this.comboBox1.SelectedIndex != -1 )
            {
                this.Hide();
                ResultForm form = new ResultForm();
                form.ShowDialog();
                form.Visible = false;
                this.Show();

            }
        }
    }
}
