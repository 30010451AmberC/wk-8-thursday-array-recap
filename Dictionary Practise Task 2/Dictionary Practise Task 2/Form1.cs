using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_Practise_Task_2
{
    public partial class Form1 : Form
    {
        static Dictionary<int, string> dict = new Dictionary<int, string>();
        static int counter = 1000;

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            dict.Add(counter, textBox1.Text);
            counter++;
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(KeyValuePair<int, string> x in dict)
            {
                listBox1.Items.Add($"key: {x.Key}\tValue: {x.Value}");
            }
        }
    }
}
