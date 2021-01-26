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
    public partial class Form2 : Form
    {
        string fn; 
        string sn;
        double wk;
        double hr;
       
      
        List<Sotrudnik> sotrudnik_list = new List<Sotrudnik>();
        
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            hour.KeyPress += hour_KeyPress;
            money.KeyPress += work_KeyPress;
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (surname.Text != String.Empty)
            {
                 sn = surname.Text;
            }
            else
            {
                MessageBox.Show("Введите фамилию");
                surname.Focus();
                return;
            }
            if (firstname.Text != String.Empty)
            {
                 fn = firstname.Text;
            }
            else
            {
                MessageBox.Show("Введите имя");
                firstname.Focus();
                return;
            }
            if (work.Text != String.Empty)
            {
                 wk = Convert.ToDouble(work.Text.Replace(',', '.'));
            } else
            {
                MessageBox.Show("Введите кол-во руб/час");
                work.Focus();
                return;
            }
            if (hour.Text != String.Empty)
            {
                 hr = Convert.ToDouble(hour.Text.Replace(',', '.'));
            }
            else
            {
                MessageBox.Show("Введите кол-во часов");
                hour.Focus();
                return;
            }

            Sotrudnik sk = new Sotrudnik(sn, fn, wk, hr);
            MessageBox.Show(sk.Info());
            StreamWriter streamwriter = new StreamWriter(@"C:\SOTRUDNIK\sotrudnik.txt", true, System.Text.Encoding.GetEncoding("utf-8"));
            streamwriter.WriteLine(sk.Info());
            streamwriter.Close();
            sotrudnik_list.Add(sk);
        }

        private void work_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != ',')
            {
                e.Handled = true;
            }
        }

        private void hour_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != ',')
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double zarplata = 0;
            if (work.Text != String.Empty)
            {
                wk = Convert.ToDouble(work.Text.Replace(',', '.'));
            }
            else
            {
                work.Focus();
                MessageBox.Show("Заполните поле Оплата в час");
                return;
            }

            if (hour.Text != String.Empty)
            {
                hr = Convert.ToDouble(hour.Text.Replace(',', '.'));
            }
            else
            {
                hour.Focus();
                MessageBox.Show("Заполните поле Количество часов");
                return;
            }

            zarplata = hr * wk;
            money.Text = zarplata.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             string message = "";
            foreach (var x in sotrudnik_list) message += x.Info() + "\n";
            MessageBox.Show(message);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPicture = new OpenFileDialog();
            openPicture.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png";
            if (openPicture.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openPicture.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void work_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
