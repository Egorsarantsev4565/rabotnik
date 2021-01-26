using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rabotnik
{  
   

        public partial class Form5 : Form

        {

            List<Sotrudnik> rabotnik_list;

            string[] lastname = new string[8];

            string[] info = new string[8];

            int count;

            string ln;

            string fn;

            double h;

            double d;
  public Form5()

        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)

            {

                this.MaximumSize = new Size(815, 640);

                this.MinimumSize = new Size(815, 640);

                string filename = @"C:\SOTRUDNIK\sotrudnik.txt";

                if (File.Exists(filename)) 

                {

                  StreamReader file = new StreamReader(filename);

                    string[] values;

                    string newline; 

                    rabotnik_list = new List<Sotrudnik>();

                    while ((newline = file.ReadLine()) != null)

                    {

                        values = newline.Split(' ');

                        ln = values[1];

                        fn = values[0];

                        d = Convert.ToDouble(values[2]);

                        h = Convert.ToDouble(values[3]);

                    Sotrudnik r = new Sotrudnik(fn, ln, d, h);

                        rabotnik_list.Add(r);

                        lastname[rabotnik_list.Count - 1] = ln;

                        info[rabotnik_list.Count - 1] = ln + " " + fn + ",\n" + h + "часов " + d + "(ставка руб./час) ";

                    }

                    count = rabotnik_list.Count;

                }

                try { pictureBox1.Image = Image.FromFile("C:\\SOTRUDNIK\\images\\" + lastname[0] + ".jpg"); }

                catch { }

                try { pictureBox2.Image = Image.FromFile("C:\\SOTRUDNIK\\images\\" + lastname[1] + ".jpg"); }

                catch { }

                try { pictureBox3.Image = Image.FromFile("C:\\SOTRUDNIK\\images\\" + lastname[2] + ".jpg"); }

                catch { }

                try { pictureBox4.Image = Image.FromFile("C:\\SOTRUDNIK\\images\\" + lastname[3] + ".jpg"); }

                catch { }

                try { pictureBox5.Image = Image.FromFile("C:\\SOTRUDNIK\\images\\" + lastname[4] + ".jpg"); }

                catch { }

                try { pictureBox6.Image = Image.FromFile("C:\\SOTRUDNIK\\images\\" + lastname[5] + ".jpg"); }

                catch { }

                try { pictureBox7.Image = Image.FromFile("C:\\SOTRUDNIK\\images\\" + lastname[6] + ".jpg"); }

                catch { }

                try { pictureBox8.Image = Image.FromFile("C:\\SOTRUDNIK\\images\\" + lastname[7] + ".jpg"); }

                catch { }

                try { label1.Text = info[0]; }

                catch { }

                try { label2.Text = info[1]; }

                catch { }

                try { label3.Text = info[2]; }

                catch { }

                try { label4.Text = info[3]; }

                catch { }

                try { label5.Text = info[4]; }

                catch { }

                try { label6.Text = info[5]; }

                catch { }

                try { label7.Text = info[6]; }

                catch { }

                try { label8.Text = info[7]; }

                catch { }

                pictureBox1.Image = Image.FromFile("C:\\SOTRUDNIK\\images\\" + 1 + ".jpg");

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBox2.Image = Image.FromFile("C:\\SOTRUDNIK\\images\\" + 2 + ".jpg");

                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBox3.Image = Image.FromFile("C:\\SOTRUDNIK\\images\\" + 3 + ".jpg");

                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBox4.Image = Image.FromFile("C:\\SOTRUDNIK\\images\\" + 4 + ".jpg");

                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBox5.Image = Image.FromFile("C:\\SOTRUDNIK\\images\\" + 5 + ".jpg");

                pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBox6.Image = Image.FromFile("C:\\SOTRUDNIK\\images\\" + 6 + ".jpg");

                pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBox7.Image = Image.FromFile("C:\\SOTRUDNIK\\images\\" + 7 + ".jpg");

                pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBox8.Image = Image.FromFile("C:\\SOTRUDNIK\\images\\" + 8 + ".jpg");

                pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;

            }

            private void pictureBox1_MouseEnter_1(object sender, EventArgs e)

            {

                pictureBox1.Visible = false;

            }

            private void pictureBox1_MouseLeave_1(object sender, EventArgs e)

            {

                pictureBox1.Visible = true;

            }

            private void pictureBox2_MouseEnter(object sender, EventArgs e)

            {

                pictureBox2.Visible = false;

            }

            private void pictureBox2_MouseLeave(object sender, EventArgs e)

            {

                pictureBox2.Visible = true;

            }

            private void pictureBox3_MouseEnter(object sender, EventArgs e)

            {

                pictureBox3.Visible = false;

            }

            private void pictureBox3_MouseLeave(object sender, EventArgs e)

            {

                pictureBox3.Visible = true;

            }

            private void pictureBox4_MouseEnter(object sender, EventArgs e)

            {

                pictureBox4.Visible = false;

            }

            private void pictureBox4_MouseLeave(object sender, EventArgs e)

            {

                pictureBox4.Visible = true;

            }

            private void pictureBox5_MouseEnter(object sender, EventArgs e)

            {

                pictureBox5.Visible = false;

            }

            private void pictureBox5_MouseLeave(object sender, EventArgs e)

            {

                pictureBox5.Visible = true;

            }

            private void pictureBox6_MouseEnter(object sender, EventArgs e)

            {

                pictureBox6.Visible = false;

            }

            private void pictureBox6_MouseLeave(object sender, EventArgs e)

            {

                pictureBox6.Visible = true;

            }

            private void pictureBox7_MouseEnter(object sender, EventArgs e)

            {

                pictureBox7.Visible = false;

            }

            private void pictureBox7_MouseLeave(object sender, EventArgs e)

            {

                pictureBox7.Visible = true;

            }

            private void pictureBox8_MouseEnter(object sender, EventArgs e)

            {

                pictureBox8.Visible = false;

            }

            private void pictureBox8_MouseLeave(object sender, EventArgs e)

            {

                pictureBox8.Visible = true;

            }

      
    }

    }