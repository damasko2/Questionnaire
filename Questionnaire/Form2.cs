using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private bool BorderCheck(MouseEventArgs e)
        {
            if ((e.X>=0&&e.X<=5)||(e.Y>=0&&e.Y<=5)||(e.Y>=185&&e.Y<=190)||
                (e.X>=315&&e.X<=320))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "X = " + e.X.ToString() + ", Y = " + e.Y.ToString();
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "X = " + (e.X+panel3.Location.X).ToString() + ", Y = "
                + (e.Y+panel3.Location.Y).ToString();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                MessageBox.Show("Вы нажали за пределами прямоугольника");
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys==Keys.Control&&e.Button==MouseButtons.Left)
            {
                this.Close();
            }

            if (e.Button == MouseButtons.Right)
            {
                this.Text = $"Width = {this.Size.Width}, Height = {this.Size.Height}";
            }
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                if (BorderCheck(e))
                {
                    MessageBox.Show("Вы нажали на границу");
                }
                else
                {
                    MessageBox.Show("Вы нажали внутри прямоугольника");
                }
            }
        }
    }
}
