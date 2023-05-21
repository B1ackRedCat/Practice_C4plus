using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xMin = Convert.ToDouble(XInput.Text);
            double xMax = Convert.ToDouble(endInput.Text);
            double step = Convert.ToDouble(stepInput.Text);
            int count = (int)Math.Ceiling((xMax - xMin) / step) + 1;
            double[] x =  new double[count];
            double[] y = new double[count];
            for(int i = 0; i < count; i++)
            {
                x[i] = xMin + step * i;
                y[i] = Math.Pow(Math.E, x[i]);
            }
            chart1.ChartAreas[0].AxisX.Minimum = xMin;
            chart1.ChartAreas[0].AxisX.Maximum = xMin + step * count;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = step;
            chart1.Series[0].Points.DataBindXY(x, y);
        }
    }
}
