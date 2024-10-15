namespace _113_10_15_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double kms;
            double liters;
            double average;

            kms = double.Parse(txbkm.Text);
            liters = double.Parse(txbliter.Text);
            average = kms / liters;

            lblshow.Text = average.ToString();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
