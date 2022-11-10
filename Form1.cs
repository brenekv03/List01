using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> list = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            Random random = new Random();
            for(int i = 0; i <n;i++)
            {
                list.Add(random.Next(-5,11));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(int x in list)
            {
                listBox1.Items.Add(x);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.RemoveRange(0,listBox1.Items.Count);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                list.Remove(list.Max());
            }
            else
            {
                list.Remove(list.Min());
            }
        }
    }
}
