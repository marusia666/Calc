using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Array_calc : Form
    {
        ArrCalc Arr;

        public Array_calc()
        {
            InitializeComponent();

            ArrCalc Arr = new ArrCalc(); 

            Res_textBox.Text = "0";
        }

        private void Close_button_Click(object sender, EventArgs e)
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

        private void Hist_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Arr_History form4 = new Arr_History();
            if (form4.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Res_textBox.Text += "1";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Res_textBox.Text += "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Res_textBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Res_textBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Res_textBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Res_textBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Res_textBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Res_textBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Res_textBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Res_textBox.Text += "10";
        }

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

        private void Minusbutton_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                int[] a = Res_textBox.Text.Split(' ').Select(x => int.Parse(x)).ToArray();

                Arr.Put_A(ref a);

                Minusbutton.Enabled = false;

                Res_textBox.Text = "0";
            }
        }

        private void Logarithm_button_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                int[] a = Res_textBox.Text.Split(' ').Select(x => int.Parse(x)).ToArray();

                Arr.Put_A(ref a);

                Logarithm_button.Enabled = false;

                Res_textBox.Text = "0";
            }
        }

        private void Degree_button_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                int[] a = Res_textBox.Text.Split(' ').Select(x => int.Parse(x)).ToArray();

                Arr.Put_A(ref a);

                Degree_button.Enabled = false;

                Res_textBox.Text = "0";
            }
        }

        private void Multiplbutton_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                int[] a = Res_textBox.Text.Split(' ').Select(x => int.Parse(x)).ToArray();

                Arr.Put_A(ref a);

                Multiplbutton.Enabled = false;

                Res_textBox.Text = "0";
            }
        }

        private void Divbutton_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                int[] a = Res_textBox.Text.Split(' ').Select(x => int.Parse(x)).ToArray();

                Arr.Put_A(ref a);

                Divbutton.Enabled = false;

                Res_textBox.Text = "0";
            }
        }

        private void Plusbutton_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                int[] a = Res_textBox.Text.Split(' ').Select(x => int.Parse(x)).ToArray();

                Arr.Put_A(ref a);

                Plusbutton.Enabled = false;

                Res_textBox.Text = "0";
            }
        }

        private void SqrNbutton_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                int[] a = Res_textBox.Text.Split(' ').Select(x => int.Parse(x)).ToArray();

                Arr.Put_A(ref a);

                SqrNbutton.Enabled = false;

                Res_textBox.Text = "0";
            }
        }

        private void Sqr2_button_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                int[] a = Res_textBox.Text.Split(' ').Select(x => int.Parse(x)).ToArray();

                Arr.Put_A(ref a);

                Arr.Clear_A();
                FreeButtons();
            }
        }

        private void Sqered_button_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                int[] a = Res_textBox.Text.Split(' ').Select(x => int.Parse(x)).ToArray();

                Arr.Put_A(ref a);

                Res_textBox.Text = Arr.Square().ToString();

                Arr.Clear_A();
                FreeButtons();
            }
        }

        private void Factorial_button_Click(object sender, EventArgs e)
        {
            /*if (CanPress())
            {
                int[] a = Res_textBox.Text.Split(' ').Select(x => int.Parse(x)).ToArray();
                int[] b;
                for (int i = 0; i <= a.Length; i++)
                {
                    if (a[i] >= 0.0)
                    {   

                        C.Clear_A();
                        FreeButtons();
                    }
                }
            }*/
        }

        private void Resultbutton_Click(object sender, EventArgs e)
        {
            int[] a = Res_textBox.Text.Split(' ').Select(x => int.Parse(x)).ToArray();

            Arr.Put_A(ref a);

            if (!Multiplbutton.Enabled)
                Res_textBox.Text = Arr.Multiplication(Convert.ToInt32(Res_textBox.Text)).ToString();

            if (!Divbutton.Enabled)
                Res_textBox.Text = Arr.Division(Convert.ToInt32(Res_textBox.Text)).ToString();

            if (!Plusbutton.Enabled)
                Res_textBox.Text = Arr.Sum(Convert.ToInt32(Res_textBox.Text)).ToString();

            if (!Minusbutton.Enabled)
                Res_textBox.Text = Arr.Subtraction(Convert.ToInt32(Res_textBox.Text)).ToString();

            if (!SqrNbutton.Enabled)
                Res_textBox.Text = Arr.SqrtX(Convert.ToInt32(Res_textBox.Text)).ToString();

            if (!Degree_button.Enabled)
                Res_textBox.Text = Arr.Degree(Convert.ToInt32(Res_textBox.Text)).ToString();

            if (!Logarithm_button.Enabled)
                Res_textBox.Text = Arr.Log(Convert.ToInt32(Res_textBox.Text)).ToString();

            Arr.Clear_A();
            FreeButtons();
        }
    }
}
