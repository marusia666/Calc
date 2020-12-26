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

namespace Calculator
{
    public partial class Main_page : Form
    {
        Calc C;
        double hist = 0;

        public Main_page()
        {
            InitializeComponent();
            C = new Calc();
            Res_textBox.Text = "0";
        }

        private void Main_page_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void C_button_Click(object sender, EventArgs e)
        {
            Res_textBox.Text = "0";
            C.Clear_A();
            FreeButtons();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Res_textBox.Text += "0";
            CorrectNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Res_textBox.Text += "1";
            CorrectNumber();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Res_textBox.Text += "4";
            CorrectNumber();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Res_textBox.Text += "7";
            CorrectNumber();
        }

        private void CangeSignbutton_Click(object sender, EventArgs e)
        {
            if (Res_textBox.Text[0] == '-')
                Res_textBox.Text = Res_textBox.Text.Remove(0, 1);
            else
                Res_textBox.Text = "-" + Res_textBox.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Res_textBox.Text += "8";
            CorrectNumber();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Res_textBox.Text += "9";
            CorrectNumber();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Minusbutton_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(Res_textBox.Text));

                Minusbutton.Enabled = false;

                Res_textBox.Text = "0";
            }
        }

        private void Logarithm_button_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(Res_textBox.Text));

                Logarithm_button.Enabled = false;

                Res_textBox.Text = "0";
            }
        }

        private void Degree_button_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(Res_textBox.Text));

                Degree_button.Enabled = false;

                Res_textBox.Text = "0";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Res_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FractionalPartbutton_Click(object sender, EventArgs e)
        {
            if ((Res_textBox.Text.IndexOf(",") == -1) && (Res_textBox.Text.IndexOf("∞") == -1))
                Res_textBox.Text += ",";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Res_textBox.Text += "2";
            CorrectNumber();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Res_textBox.Text += "3";
            CorrectNumber();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Res_textBox.Text += "5";
            CorrectNumber();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Res_textBox.Text += "6";
            CorrectNumber();
        }

        //функция для удаления лишнего нуля впереди числа
        private void CorrectNumber()
        {
            //если есть знак "бесконечность" - не пишем цифры после него
            if (Res_textBox.Text.IndexOf("∞") != -1)
                Res_textBox.Text = Res_textBox.Text.Substring(0, Res_textBox.Text.Length - 1);

            //для положительного числа
            if (Res_textBox.Text[0] == '0' && (Res_textBox.Text.IndexOf(",") != 1))
                Res_textBox.Text = Res_textBox.Text.Remove(0, 1);

            //для отрицательного числа
            if (Res_textBox.Text[0] == '-')
                if (Res_textBox.Text[1] == '0' && (Res_textBox.Text.IndexOf(",") != 2))
                    Res_textBox.Text = Res_textBox.Text.Remove(1, 1);
        }

        private void Resultbutton_Click(object sender, EventArgs e)
        {

            if (!Multiplbutton.Enabled)
            {
                hist = C.Multiplication(Convert.ToDouble(Res_textBox.Text));
                C.Put_A(hist);
                C.RemHist(hist);
                Res_textBox.Text = C.Multiplication(Convert.ToDouble(Res_textBox.Text)).ToString();
            }

            if (!Divbutton.Enabled)
                Res_textBox.Text = C.Division(Convert.ToDouble(Res_textBox.Text)).ToString();

            if (!Plusbutton.Enabled)
                Res_textBox.Text = C.Sum(Convert.ToDouble(Res_textBox.Text)).ToString();

            if (!Minusbutton.Enabled)
                Res_textBox.Text = C.Subtraction(Convert.ToDouble(Res_textBox.Text)).ToString();

            if (!SqrNbutton.Enabled)
                Res_textBox.Text = C.SqrtX(Convert.ToDouble(Res_textBox.Text)).ToString();

            if (!Degree_button.Enabled)
                Res_textBox.Text = C.Degree(Convert.ToDouble(Res_textBox.Text)).ToString();

            if (!Logarithm_button.Enabled)
                Res_textBox.Text = C.Log(Convert.ToDouble(Res_textBox.Text)).ToString();

            C.Clear_A();
            FreeButtons();
        }

        private void Multiplbutton_Click(object sender, EventArgs e)
        {

            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(Res_textBox.Text));

                Multiplbutton.Enabled = false;

                Res_textBox.Text = "0";
            }
        }

        private void Divbutton_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(Res_textBox.Text));

                Divbutton.Enabled = false;

                Res_textBox.Text = "0";
            }
        }

        private void Plusbutton_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(Res_textBox.Text));

                Plusbutton.Enabled = false;

                Res_textBox.Text = "0";
            }
        }

        private void SqrNbutton_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(Res_textBox.Text));

                SqrNbutton.Enabled = false;

                Res_textBox.Text = "0";
            }
        }

        private void Sqr2_button_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(Res_textBox.Text));

                Res_textBox.Text = C.Sqrt().ToString();

                C.Clear_A();
                FreeButtons();
            }
        }

        private void Sqered_button_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(Res_textBox.Text));

                Res_textBox.Text = C.Square().ToString();

                C.Clear_A();
                FreeButtons();
            }
        }

        private void Factorial_button_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                if ((Convert.ToDouble(Res_textBox.Text) == (int)(Convert.ToDouble(Res_textBox.Text))) &&
                    ((Convert.ToDouble(Res_textBox.Text) >= 0.0)))
                {
                    C.Put_A(Convert.ToDouble(Res_textBox.Text));

                    Res_textBox.Text = C.Factorial().ToString();

                    C.Clear_A();
                    FreeButtons();
                }
            }
        }

        //проверяет не нажата ли еще какая-либо из кнопок операций
        private bool CanPress()
        {
            if (!Multiplbutton.Enabled)
                return false;

            if (!Divbutton.Enabled)
                return false;

            if (!Plusbutton.Enabled)
                return false;

            if (!Minusbutton.Enabled)
                return false;

            if (!SqrNbutton.Enabled)
                return false;

            if (!Degree_button.Enabled)
                return false;

            if (!Logarithm_button.Enabled)
                return false;

            return true;
        }

        //снятие нажатия всех кнопок операций
        private void FreeButtons()
        {
            Multiplbutton.Enabled = true;
            Divbutton.Enabled = true;
            Plusbutton.Enabled = true;
            Minusbutton.Enabled = true;
            SqrNbutton.Enabled = true;
            Degree_button.Enabled = true;
            Logarithm_button.Enabled = true;
        }

        private void Del_button_Click(object sender, EventArgs e)
        {
            int lenght = Res_textBox.Text.Length - 1;
            string text = Res_textBox.Text;
            Res_textBox.Clear();
            for (int i = 0; i < lenght; i++)
            {
                Res_textBox.Text = Res_textBox.Text + text[i];
            }
        }

        private void Percentbutton_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(Res_textBox.Text));

                Res_textBox.Text = C.Percent().ToString();

                C.Clear_A();
                FreeButtons();
            }
        }

        private void Hist_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            History form2 = new History();
            if (form2.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Arraymode_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Array_calc form3 = new Array_calc();
            if (form3.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Openf_button_Click(object sender, EventArgs e)
        {
            String line;
            StreamReader sr = new StreamReader("D:\\for_calc.txt");
                line = sr.ReadLine();
                sr.Close();
                Console.ReadLine();
            

            Res_textBox.Clear();
            for (int i = 0; i < line.Length; i++)
            {
                Res_textBox.Text = Res_textBox.Text + line[i];
            }

        }
    }
}
