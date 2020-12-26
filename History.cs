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
    public partial class History : Form
    {
        Calc C;
        double a;

        public History()
        {
            InitializeComponent();
            C = new Calc();
            Res1_textBox.Text = "0";
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

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_page form1 = new Main_page();
            if (form1.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
        }

        private void res8_button_Click(object sender, EventArgs e)
        {

        }


        private void SpLast_button_Click(object sender, EventArgs e)
        {
            a = C.ShowHist();
            Res1_textBox.Text = a.ToString();
        }
    }
}
