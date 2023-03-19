using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace oaip8laba
{
    public partial class Form1 : Form
    {
        Rectangle rectagle;
        ShapeContainer shapeContainer;
        Init init;
        public Form1()
        {
            init = new Init();
            shapeContainer = new ShapeContainer();
                InitializeComponent();
                Init.bitmap = new
        Bitmap(pictureBox1.ClientSize.Width,
        pictureBox1.ClientSize.Height);
                Init.pen = new Pen(Color.Black, 5);
               
                Init.pictureBox = pictureBox1;
               
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            rectagle = new Rectangle(int.Parse(textBox1.Text),
                int.Parse(textBox2.Text),
        int.Parse(textBox3.Text), int.Parse(textBox4.Text));
                ShapeContainer.AddFigure(this.rectagle);
                rectagle.Draw();
                comboBox1.Items.Clear();
                try
                {
                    foreach( Figure figure in ShapeContainer.figureList)
                    {
                        comboBox1.Items.Add(figure);
                    }
                }catch(Exception ex) { MessageBox.Show(ex.Message); }

            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBox1.SelectedItem== null) 
                {
                    throw new Exception();
                }
                else
                {
                    Figure figure;
                    figure = (Figure)comboBox1.SelectedItem;
                    figure.DeleteF(figure);
                    comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                    comboBox1.Update();
                    comboBox1.ResetText();
                } 

            }catch(Exception Ex ) { MessageBox.Show(Ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null)
                {
                    throw new Exception();
                }
                else
                {
                    Figure figure;
                    figure = (Figure)comboBox1.SelectedItem;
                    figure.MoveTo(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                    
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
