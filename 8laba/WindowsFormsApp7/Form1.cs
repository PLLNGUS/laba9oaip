using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        static class Init
        {
            public static Bitmap bitmap;
            public static PictureBox pictureBox;
            public static Pen pen;

        }
        public Form1()
        {
            InitializeComponent();
            Init.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Init.pen = new Pen(Color.Black, 5);
            Init.pictureBox = pictureBox1; 
           
        }

       
            private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new
            Bitmap(pictureBox1.ClientSize.Width,
            pictureBox1.ClientSize.Height);
            Pen pen = new Pen(Color.Black, 5);
        }
        public void DrawLinePoint(PaintEventArgs e) 
        { 
            Graphics g = Graphics.FromImage(Init.bitmap);
            Point point1 = new Point(100, 100); 
            Point point2 = new Point(500, 100);
            g.DrawLine(Init.pen, point1, point2); 
            pictureBox1.Image = Init.bitmap;
        }
      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(Init.bitmap);

            g.DrawLine(Init.pen, float.Parse(textBox1.Text), float.Parse(textBox2.Text), float.Parse(textBox1.Text) * 2, float.Parse(textBox2.Text));
            Init.pictureBox.Image = Init.bitmap;


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public  void DrawRectangle()
        {
            
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(Init.bitmap); g.DrawRectangle(Init.pen, float.Parse(textBox6.Text), float.Parse(textBox5.Text), float.Parse(textBox4.Text), float.Parse(textBox3.Text));
            Init.pictureBox.Image = Init.bitmap;
        }
    }
}
