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
    public partial class Arr_History : Form
    {
        public Arr_History()
        {
            InitializeComponent();
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
            Array_calc form3 = new Array_calc();
            if (form3.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
