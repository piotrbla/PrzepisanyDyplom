using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrzepisanyDyplom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics m_graphics;
        private readonly Pen m_pen = new Pen(Color.Blue, 2F);

        //private void DrawPoint(int x, int y)
        //{
        //    m_graphics.DrawRectangle(Pens.Red, x, y, 1, 1);
        //}

        private void Button1Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            pictureBox1.Refresh();
            m_graphics = pictureBox1.CreateGraphics();
            m_graphics.DrawLine(m_pen, 10, 10, 100, 100);
            button1.Enabled = true;
        }


    }
}
