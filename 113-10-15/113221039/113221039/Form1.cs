namespace _113221039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output;

            output = "����" + txtYear.Text + "�~" + txtMonth.Text + "��" + txtday.Text + "��" + "�P��" + txtdayofweek.Text;

            lblshow.Text = output;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdayofweek.Text = "";
            txtday.Text = "";
            txtMonth.Text = "";
            txtYear.Text = "";
            lblshow.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
