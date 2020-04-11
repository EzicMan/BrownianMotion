using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsProject
{
    public partial class Form3 : Form
    {
        Form1 f = new Form1();
        public Form3()
        {
            InitializeComponent();
            f.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox1.Text[textBox1.Text.Length - 1] - '0' >= 0 && textBox1.Text[textBox1.Text.Length - 1] - '0' <= 9)
            {
                if (!button1.Enabled)
                {
                    button1.Enabled = true;
                }
            }
            else
            {
                if (button1.Enabled)
                {
                    button1.Enabled = false;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            f.addLine(Convert.ToInt32(textBox1.Text));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            f.clear();
        }
    }
}
