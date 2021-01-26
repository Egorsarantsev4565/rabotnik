using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace rabotnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\fon1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\SOTRUDNIK\sotrudnik.txt"))
            {
                Form3 f = new Form3();
                f.Show();
            }
            else
            {
                MessageBox.Show("Файла нет");
                return;
            }
        }

        private void оПриложенииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void оПриложенииToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
              Form4 f = new Form4();
                f.Show();
          
        }
    }
}
