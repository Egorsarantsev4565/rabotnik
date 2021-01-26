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
using System.Windows.Markup;

namespace rabotnik
{
    public partial class Form3 : Form
    {
        DataTable dt;
        List<Sotrudnik> sotrudnik_list;
        string filterField = "Фамилия";

        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("Фамилия");
            dt.Columns.Add("Имя");
            dt.Columns.Add("руб/час");
            dt.Columns.Add("кол-во часов");
            
            string filename = @"C:\SOTRUDNIK\sotrudnik.txt";
            if (File.Exists(filename))
            {
                StreamReader file = new StreamReader(filename);
                string[] values;
                string newline;
                while ((newline = file.ReadLine()) != null)
                {
                    DataRow dr = dt.NewRow();
                    values = newline.Split(' ');
                    for (int i = 0; i < values.Length; i++)
                    {
                        dr[i] = values[i];
                    }
                    dt.Rows.Add(dr);
                }
                file.Close();
                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();
            }
            else MessageBox.Show("Нет файла с данными");
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                dt.Columns.Add("Зарплата");
                dataGridView1.Columns.Add("Зарплата", "Зарплата");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    double hour = Convert.ToDouble(dt.Rows[i]["кол-во часов"]);
                    double wk = Convert.ToDouble(dt.Rows[i]["руб/час"]);
                    dt.Rows[i]["Зарплата"] = hour * wk;
                }
                dataGridView1.DataSource = dt;
                dataGridView1.Columns.Remove("Зарплата");
            }
            else
            {
                dt.Columns.Remove("Зарплата");
            }
        
    
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterField,
textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = @"C:\SOTRUDNIK\sotrudnik.txt";
            if (File.Exists(filename))
            {
                StreamReader file = new StreamReader(filename);
                string[] values;
                string newline;
                string sn;
                string fn;
                double wk;
                double hr;
               
                Sotrudnik sk;
                sotrudnik_list = new List<Sotrudnik>();
                while ((newline = file.ReadLine()) != null)
                {
                    values = newline.Split(' ');
                    sn = values[0];
                    fn = values[1];
                    wk = Convert.ToDouble(values[2]);
                    hr = Convert.ToDouble(values[3]);
                   
                    sk = new Sotrudnik(sn, fn, wk, hr);
                    sotrudnik_list.Add(sk);
                }
                file.Close();
                int j = 0;
                while (j < sotrudnik_list.Count)
                {
                    sk = sotrudnik_list[j];
                    if (sk.getLastName().Equals(textBox1.Text))
                        sotrudnik_list.RemoveAt(j);
                    else
                        j++;
                }
                j = 0;
                string data;
                while (j < dt.Rows.Count)
                {
                    data = dt.Rows[j][0].ToString();
                    if (data.Equals(textBox1.Text)) dt.Rows[j].Delete();
                    j++;
                }
                textBox1.Text = String.Empty;
                string message = "";
                foreach (var x in sotrudnik_list) message += x.Info() + "\n";
                MessageBox.Show(message);
                file.Close();
                StreamWriter new_file = new StreamWriter(@"C:\SOTRUDNIK\sotrudnik.txt");
                foreach (var x in sotrudnik_list)
                    new_file.WriteLine(x.Info());
                new_file.Close();
                dataGridView1.DataSource = dt;
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
            else MessageBox.Show("Нет файла с данными");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }
    }
}
