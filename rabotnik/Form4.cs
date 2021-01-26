using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rabotnik
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(440, 480);
            this.StartPosition = FormStartPosition.CenterScreen;
            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel { Dock = DockStyle.Fill };
            Button button1 = new Button();
            Button button2 = new Button();
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            PictureBox pictureBox2 = new PictureBox();
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            PictureBox pictureBox3 = new PictureBox();
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            TextBox textBox1 = new TextBox();

            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.RowCount = 4;

            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBox3, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 3);
            tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            tableLayoutPanel1.TabIndex = 0;

            button1.Dock = DockStyle.Fill;
            button1.Name = "button1";
            button1.TabIndex = 0;
            button1.Text = "Hello, Sotrudnik";
            button1.Click += new EventHandler(this.Hello);

            button2.Dock = DockStyle.Fill;
            button2.Name = "button2";
            button2.TabIndex = 1;
            button2.Text = "Bye, Sotrudnik";
            button2.Click += new EventHandler(this.Bye);

            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabIndex = 2;
            pictureBox1.Image = Image.FromFile(@"C:\1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            tableLayoutPanel1.SetRowSpan(pictureBox1, 2);

            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabIndex = 3;
            pictureBox2.Image = Image.FromFile(@"C:\2.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Name = "pictureBox2";
            pictureBox3.TabIndex = 4;
            pictureBox3.Image = Image.FromFile(@"C:\3.jpg");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            textBox1.Dock = DockStyle.Fill;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Text = "Разработчик: Студент 425 группы, Саранцев Егор\t Адрес эл. почты: egorsarantsev4565@yandex.ru";
            textBox1.Font =
            new Font(textBox1.Font.FontFamily, 20F, FontStyle.Bold | FontStyle.Italic);
            textBox1.ForeColor = Color.Blue;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TabIndex = 5;
            tableLayoutPanel1.SetColumnSpan(textBox1, 2);
            Controls.Add(tableLayoutPanel1);
        }

        void Hello(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, Sotrudnik");
        }
        void Bye(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}

