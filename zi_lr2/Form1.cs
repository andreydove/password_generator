using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zi_lr2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result, str, str1, str2, str3, str4;
            decimal length = 0;

            Random rnd = new Random();
            str = "";
            str1 = "19283746504378192560";
            str2 = "abcdefghijklmnopqastuvwxyz";
            str3 = "ABCDEFGHIJKLMNOPQASTUVWXYZ";
            str4 = "!@#$%^&*()_+|\\=-<>.,/?''; :\"][}{";
            result = "";
            length = numericUpDown1.Value;
            if (checkBox1.Checked == true) { str = str + str1; }
            if (checkBox2.Checked == true) { str = str + str2; }
            if (checkBox3.Checked == true) { str = str + str3; }
            if (checkBox4.Checked == true) { str = str + str4; }
            if ((checkBox1.Checked == false) && (checkBox2.Checked == false) && (checkBox3.Checked == false) && (checkBox4.Checked == false))
            {
                MessageBox.Show("Оберіть з яких символів має складатись пароль!","Помилка");
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    result = result + str[rnd.Next(str.Length)].ToString();
                }
                textBox1.Text = result;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked == false) && (checkBox2.Checked == false) && (checkBox3.Checked == false) && (checkBox4.Checked == false))
            {
                MessageBox.Show("Оберіть з яких символів має складатись пароль!", "Помилка");
            }
            else
            {
                Clipboard.SetText(textBox1.Text);
            }
        }
    }
}
