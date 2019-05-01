using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_recap
{
    public partial class Form1 : Form
    {
        static double[] numbers;
        static int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (counter <= 9)
            {
                if (double.TryParse(textBoxTask1.Text, out numbers[counter]))
                {

                    counter++;
                    btnAddNumber.Text = $"Add number {counter + 1}";
                    textBoxTask1.ForeColor = Color.LightGray;
                    textBoxTask1.Text = $"Enter your numbers here .....";
                }
                else if (!double.TryParse(textBoxTask1.Text, out numbers[counter]))
                {
                    textBoxTask1.ForeColor = Color.LightGray;
                    textBoxTask1.Text = $"Enter your numbers here .....";
                }
            }
            if (counter > 9)
            {
                textBoxTask1.Visible = false;
                btnDisplay.Visible = true;
                textBoxTask1Instructions.Text = "Thankyou, all 10 numbers have been input...";
            }

            btnAddNumber.Visible = false;
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                listBoxArray.Items.Add($"Number {i + 1}:\t{numbers[i]}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
