using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace محمود_اغا_lesson_code_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.BurlyWood;
            pictureBox1.Width = pictureBox1.Height = 200;
            pictureBox1.BackColor = Color.BlanchedAlmond;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter="Image Files|*.jpg;*.png|All Files|*.*";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                textBox1.BackColor= Color.DarkViolet;

                Bitmap mybitmap = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = mybitmap;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
