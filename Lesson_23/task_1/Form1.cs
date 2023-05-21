namespace task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();

            double a = Math.Pow(2, -x) * Math.Sqrt(x + Math.Pow(y, 3)) * Math.Pow(Math.E, x - 1 / Math.Sin(z));

            textBox4.Text += Environment.NewLine + "Результат: " + string.Format("{0:f3}", a);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";

        }
    }
}