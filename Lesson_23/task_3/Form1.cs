namespace task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            double x1 = Convert.ToDouble(textBox1.Text);
            double x2 = Convert.ToDouble(textBox2.Text);
            double step = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox5.Text);


            double y = 0;
            if (x1 > x2)
            {
                for (double i = x1; i > x2; i += step)
                {
                    y = i * Math.Sin(Math.Sqrt(i + a - 0.0084));
                    textBox4.Text += "При X = " + string.Format("{0:f1}", i) + "   Y = " + string.Format("{0:f3}", y) + Environment.NewLine;
                }
            }
            else if (x1 < x2)
            {
                for (double i = x1; i < x2; i += step)
                {
                    y = i * Math.Sin(Math.Sqrt(i + a - 0.0084));
                    textBox4.Text += "При X = " + string.Format("{0:f1}", i) + "   Y = " + string.Format("{0:f3}", y) + Environment.NewLine;
                }
            }
            else { textBox4.Text += "Границы диапазона не могут быть равны!"; }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}