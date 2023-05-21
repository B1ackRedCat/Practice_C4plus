namespace task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox2.Text);
            double y = Convert.ToDouble(textBox3.Text);
            double z = Convert.ToDouble(textBox4.Text);

            textBox1.Text = "Результаты работы программы: " + Environment.NewLine;
            textBox1.Text += "При X = " + x + Environment.NewLine;
            textBox1.Text += "При Y = " + y + Environment.NewLine;
            textBox1.Text += "При Z = " + z + Environment.NewLine;

            double a;
            if (x * y > 10) { a = Math.Log10(x + y + z); }
            else if (x * y < 10) { a = Math.Pow(Math.E, x + y + z); }
            else { a = x + y + z; }

            textBox1.Text += "Результат: " + string.Format("{0:f3}", a) + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}