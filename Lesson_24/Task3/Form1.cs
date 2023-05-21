using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush orangeBrush = new SolidBrush(Color.Orange);
            Rectangle orangeRect = new Rectangle(50, 50, 100, 100);
            g.FillEllipse(orangeBrush, orangeRect);
            Pen pen = new Pen(Color.DarkOrange, 4);
            g.DrawLine(pen, 75, 65, 85, 75);
            g.DrawLine(pen, 65, 75, 75, 85);
            g.DrawLine(pen, 85, 75, 95, 65);
            g.DrawLine(pen, 75, 85, 85, 95);
            g.DrawLine(pen, 65, 85, 75, 95);
            g.DrawLine(pen, 85, 85, 95, 75);
        }
    }
}
