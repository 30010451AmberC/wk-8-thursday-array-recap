using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        //Task1
        static Dictionary<string, int> dict = new Dictionary<string, int>{
                { "Apples", 2 },
                { "Bananas", 1 },
                { "Kiwifruit", 5 },
                { "Pear", 10 }};
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(KeyValuePair<string,int> x in dict)
            {
                listBox1.Items.Add($"key: {x.Key}\tValue: {x.Value}");
            }
        }
    }
}
