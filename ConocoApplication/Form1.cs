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
<<<<<<< HEAD

            if ((this.checkBox1.Checked || this.checkBox1.Checked) && this.comboBox1.SelectedIndex != -1 && this.comboBox2.SelectedIndex != -1)
            {
                this.Hide();
                ResultForm form = new ResultForm();
                form.Show();
=======
            if (this.comboBox1.SelectedIndex != -1 )
            {
                this.Hide();
                ResultForm form = new ResultForm();
                form.ShowDialog();
                form.Visible = false;
                this.Show();

>>>>>>> 60bb0c29454fd88ad162f78079d380f3cf4b7b53
            }
            else
            {
                this.ErrorLabel.Text = "Invalid: Select at least one option in all fields.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
