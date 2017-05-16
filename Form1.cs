using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        int result;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            result = random.Next(0, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //input.Text = result.ToString();
            if(input.Text != "")
            {
                int data = int.Parse(input.Text);
                if (data > result)
                {
                    more_sign.BackColor = System.Drawing.Color.Green;
                    less_sign.BackColor = System.Drawing.Color.Red;
                    more.Text = data.ToString();
                }
                else if(data < result)
                {
                    more_sign.BackColor = System.Drawing.Color.Red;
                    less_sign.BackColor = System.Drawing.Color.Green;
                    less.Text = data.ToString();
                }
                else
                {
                    string message = "Answer is "+data.ToString();
                    string caption = "Correct!!!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    more_sign.BackColor = System.Drawing.Color.Green;
                    less_sign.BackColor = System.Drawing.Color.Green;
                    more_sign.Text = "=";
                    less_sign.Text = "=";
                    answer.Text = data.ToString();
                    MessageBox.Show(message, caption, buttons);
                }
            }
            else
            {
                string message = "Please Fill Input";
                string caption = "Input is NULL";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }
    }
}
