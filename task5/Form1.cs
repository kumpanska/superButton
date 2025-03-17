using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void Actions(object sender, EventArgs e);
        private void OpacityBtn_Click(object sender, EventArgs e)
        {
            if (this.Opacity == 1.0)
            {
                this.Opacity = 0.5;
            }
            else { this.Opacity = 1.0; }
        }

        private void ColorBackgroundBtn_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Pink)
            {
                this.BackColor = Color.Yellow;
            }
            else { this.BackColor = Color.Pink; }
        }

        private void MessageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void btnSetOfActions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");
        }
    }
}
