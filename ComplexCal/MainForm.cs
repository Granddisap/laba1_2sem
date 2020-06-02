using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void String2Complex(String str, ref ComplexCal num)
        {
            Regex regex = new Regex(@"\d*\,?\d+[+|-]\d*\,?\d+i");
            if (!regex.IsMatch(str))
            {
                label2.Text = "Некорректные данные";
                return;
            }

            String n1 = null, n2 = null;
            Boolean minus_sign = false;
            int i, index = 0, first_index = 0;

            if (str[0] == '-' || str[0] == '+')
            {
                n1 += str[0];
                first_index = 1;
            }

            for (i = first_index; i < str.Length; i++)
            {
                if (str[i] == '+' || str[i] == '-')
                {
                    num.Re = Convert.ToSingle(n1);
                    minus_sign = (str[i] == '-') ? true : false;
                    index = i + 1;
                    break;
                }
                n1 += str[i];
            }

            if (minus_sign)
            {
                n2 = "-";
            }

            for (i = index; i < str.Length; i++)
            {
                if (str[i] == 'i')
                {
                    num.Im = Convert.ToSingle(n2);
                    break;
                }
                n2 += str[i];
            }

        }
        ComplexCal res = new ComplexCal();

        ComplexCal left_num = new ComplexCal();
        ComplexCal right_num = new ComplexCal();
        private void button1_Click(object sender, EventArgs e)
        {
            
            String2Complex(textBox1.Text, ref left_num);

       
            String2Complex(textBox2.Text, ref right_num);


            if (!(label2.Text == "Неверно введены данные!"))
            {
                res = left_num + right_num;
                if (res.Im >= 0)
                    label2.Text = res.Re.ToString() + "+" + res.Im.ToString() + "i";
                else
                    label2.Text = res.Re.ToString() + res.Im.ToString() + "i";
                label8.Text = res.GetAbs().ToString();
                label10.Text = res.GetArg().ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            String2Complex(textBox3.Text, ref left_num);

            
            String2Complex(textBox4.Text, ref right_num);


            if (!(label2.Text == "Неверно введены данные!"))
            {
                res = left_num - right_num;
                if (res.Im >= 0)
                    label2.Text = res.Re.ToString() + "+" + res.Im.ToString() + "i";
                else
                    label2.Text = res.Re.ToString() + res.Im.ToString() + "i";
                label8.Text = res.GetAbs().ToString();
                label10.Text = res.GetArg().ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            String2Complex(textBox5.Text, ref left_num);

            
            String2Complex(textBox6.Text, ref right_num);


            if (!(label2.Text == "Неверно введены данные!"))
            {
                res = left_num * right_num;
                if (res.Im >= 0)
                    label2.Text = res.Re.ToString() + "+" + res.Im.ToString() + "i";
                else
                    label2.Text = res.Re.ToString() + res.Im.ToString() + "i";
                label8.Text = res.GetAbs().ToString();
                label10.Text = res.GetArg().ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            String2Complex(textBox7.Text, ref left_num);

            
            String2Complex(textBox8.Text, ref right_num);


            if (!(label2.Text == "Неверно введены данные!"))
            {
                res = left_num / right_num;
                if (res.Im >= 0)
                    label2.Text = res.Re.ToString() + "+" + res.Im.ToString() + "i";
                else
                    label2.Text = res.Re.ToString() + res.Im.ToString() + "i";
                label8.Text = res.GetAbs().ToString();
                label10.Text = res.GetArg().ToString();
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
