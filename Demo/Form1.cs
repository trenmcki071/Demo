using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 20);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Font drawFont = new Font("Helvetica", 23, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            g.Clear(Color.White);

            g.FillPie(blackBrush, 120, 110, 50, 50, 270, 90);
            g.FillRectangle(blackBrush, 145, 130, 25, 25);

            g.DrawArc(blackPen, 113, 96, 70, 70, 264, 97);
            g.DrawArc(blackPen, 113, 87, 70, 70, 264, 97);
            g.FillRectangle(blackBrush, 173, 130, 20, 25);

            g.DrawArc(blackPen, 92, 63, 115, 115, 265, 97);
            g.DrawArc(blackPen, 92, 53, 115, 115, 265, 97);
            g.FillRectangle(blackBrush, 197, 120, 20, 35);

            g.DrawString("THE", drawFont, drawBrush, 75, 44);
            g.DrawString("NORTH", drawFont, drawBrush, 28, 79);
            g.DrawString("FACE", drawFont, drawBrush, 55, 115);
        }
    }
}
