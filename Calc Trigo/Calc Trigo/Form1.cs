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

namespace Calc_Trigo
{
    public partial class Form1 : Form
    {
        float a, b, t;
        int count = 0;
        bool sign = true;
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(Display.Text);
                    Display.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(Display.Text);
                    Display.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(Display.Text);
                    Display.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(Display.Text);
                    Display.Text = b.ToString();
                    break;
                case 5:
                    t = float.Parse(Display.Text);
                    b = (float)Math.Pow(a, t);
                    Display.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Display_Click(object sender, EventArgs e)
        {
            Display.Text = "";
        }
        public void ErrorMsg()
        {
            Display.Text = "Введите другое значение";
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            try
            {
                double sinNum = double.Parse(Display.Text);
                Display.Text = Convert.ToString(Math.Round(Math.Sin(sinNum), 2));
            }
            catch
            {
                ErrorMsg();
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            try
            {
                double cosNum = double.Parse(Display.Text);
                Display.Text = Convert.ToString(Math.Round(Math.Cos(cosNum), 2));
            }
            catch
            {
                ErrorMsg();
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            try
            {
                double tanNum = double.Parse(Display.Text);
                Display.Text = Convert.ToString(Math.Round(Math.Tan(tanNum), 2));
            }
            catch
            {
                ErrorMsg();
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(Display.Text);
                Display.Clear();
                count = 1;
                label1.Text = a.ToString() + "+";
                sign = true;
            }
            catch
            {
                ErrorMsg();
            }
        }
        private void minus_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(Display.Text);
                Display.Clear();
                count = 2;
                label1.Text = a.ToString() + "-";
                sign = true;
            }
            catch
            {
                ErrorMsg();
            }
        }
        private void Mult_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(Display.Text);
                Display.Clear();
                count = 3;
                label1.Text = a.ToString() + "*";
                sign = true;
            }
            catch
            {
                ErrorMsg();
            }
        }

        private void Div_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(Display.Text);
                Display.Clear();
                count = 4;
                label1.Text = a.ToString() + "/";
                sign = true;
            }
            catch
            {
                ErrorMsg();
            }
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void DelAll_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            label1.Text = "";
        }

        private void znak_Click(object sender, EventArgs e)
        {
            if (sign == true)
            {
                Display.Text = "-" + Display.Text;
                sign = false;
            }
            else if (sign == false)
            {
                Display.Text = Display.Text.Replace("-", "");
                sign = true;
            }
        }

        private void Step2_Click(object sender, EventArgs e)
        {
            try
            {
                double Num = double.Parse(Display.Text);
                Display.Text = Convert.ToString(Math.Round(Num * Num, 2));
            }
            catch
            {
                ErrorMsg();
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n     Для начала работы нужно нажать на текстовое поле и ввести число, после ввода какого-либо числа нужно при помощи кнопки <<Sign>> выбрать каким будет число - положительным или отрицательным." +
                "\n     После этих действий важно указать тригонометрические действия, выполняемые с этим числом при помощи необходимых кнопок." +
                "\n     Сразу после этого нужно указать действие, которое будет происходить с 1 и 2 числом, после выбора действия нужно проделать ту же работу, что и с 1 числом." +
                "\n     После написания 2 числе нужно нажать на кнопку <<=>>");
        }

        private void Step3_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(Display.Text);
            Display.Text = Convert.ToString(Math.Round(Num * Num * Num, 2));
        }

        private void StepX_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(Display.Text);
                Display.Clear();
                count = 5;
                label1.Text = a.ToString() + "^";
                sign = true;
            }
            catch
            {
                ErrorMsg();
            }
        }

        private void btnCoTan_Click(object sender, EventArgs e)
        {
            try
            {
                double cotanNum = double.Parse(Display.Text);
                Display.Text = Convert.ToString(Math.Round(1/Math.Tan(cotanNum), 2));
            }
            catch
            {
                ErrorMsg();
            }
        }
    }
}
