using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Task 2
namespace WindowsFormsApp1
{ 
    public partial class Form1 : Form
    {
        static int[] nums = new int[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1000,9999);
            }
        }

        private void frequencyBtn_Click(object sender, EventArgs e)
        {
            //Loop to go through array elements & count frequencies
            for (int i = 0; i < nums.Length; i++)
            {
                //Count frequencies
                int count = 1;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }
                //Not sure how to print count total to screen
                listBox1.Text = nums[i] + count;
            }
        }
    }
}
