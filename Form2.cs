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
    public partial class Form2 : Form
    {
        List<List<double>> l = new List<List<double>>();
        public Form2()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0 && listBox1.SelectedIndex != -1)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                for (int i = 0; i < l[listBox1.SelectedIndex].Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = (i + 1) * (i + 1) + " шаг";
                    dataGridView1[1, i].Value = l[listBox1.SelectedIndex][i] / 46;
                }
            }
        }

        public void AddColumn()
        {
            listBox1.Items.Add(l.Count + 1 + " линия");
            l.Add(new List<double>());
        }

        public void clear()
        {
            listBox1.Items.Clear();
            l.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        public void AddData(int num, double data)
        {
            l[num].Add(data);
        }
    }
}
