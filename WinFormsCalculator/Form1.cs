using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        public void disable()
        {
            resaultTextBox.Enabled = false;
            buttonON.Show();
            buttonOFF.Hide();
            button0.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            buttonDot.Enabled = false;
            buttonAdd.Enabled = false;
            buttonSubs.Enabled = false;
            buttonMul.Enabled = false;
            buttonDiv.Enabled = false;
            buttonClear.Enabled = false;
            buttonEqual.Enabled = false;
            buttonBack.Enabled = false;
        }

        public void enable()
        {
            resaultTextBox.Enabled = true;
            buttonON.Hide();
            buttonOFF.Show();
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            buttonDot.Enabled = true;
            buttonAdd.Enabled = true;
            buttonSubs.Enabled = true;
            buttonMul.Enabled = true;
            buttonDiv.Enabled = true;
            buttonClear.Enabled = true;
            buttonEqual.Enabled = true;
            buttonBack.Enabled = true;
        }

        float num, ans;
        int count;

        public void compute()
        {
            switch (count)
            {
                case 1:
                    ans = num + float.Parse(resaultTextBox.Text);
                    resaultTextBox.Text = ans.ToString();
                    break;

                case 2:
                    ans = num - float.Parse(resaultTextBox.Text);
                    resaultTextBox.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(resaultTextBox.Text);
                    resaultTextBox.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(resaultTextBox.Text);
                    resaultTextBox.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

        private void buttonOFF_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void buttonON_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            num = float.Parse(resaultTextBox.Text);
            resaultTextBox.Clear();
            resaultTextBox.Focus();
            count = 1;
            resaultLabel.Text = num.ToString() + "+";

        }

        private void buttonSubs_Click(object sender, EventArgs e)
        {
            num = float.Parse(resaultTextBox.Text);
            resaultTextBox.Clear();
            resaultTextBox.Focus();
            count = 2;
            resaultLabel.Text = num.ToString() + "-";
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            num = float.Parse(resaultTextBox.Text);
            resaultTextBox.Clear();
            resaultTextBox.Focus();
            count = 3;
            resaultLabel.Text = num.ToString() + "*";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            num = float.Parse(resaultTextBox.Text);
            resaultTextBox.Clear();
            resaultTextBox.Focus();
            count = 4;
            resaultLabel.Text = num.ToString() + "/";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            compute();
            resaultLabel.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            int length = resaultTextBox.TextLength - 1;
            string text = resaultTextBox.Text;
            resaultTextBox.Clear();
            for(int i=0; i < length; i++)
            {
                resaultTextBox.Text = resaultTextBox.Text + text[i];
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            resaultTextBox.Text = "";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!resaultTextBox.Text.Contains(","))
            {
                resaultTextBox.Text = resaultTextBox.Text + ",";
                resaultTextBox.ForeColor = Color.Red;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            resaultTextBox.Text = resaultTextBox.Text + 0;
            resaultTextBox.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resaultTextBox.Text = resaultTextBox.Text + 1;
            resaultTextBox.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resaultTextBox.Text = resaultTextBox.Text + 2;
            resaultTextBox.ForeColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resaultTextBox.Text = resaultTextBox.Text + 3;
            resaultTextBox.ForeColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resaultTextBox.Text = resaultTextBox.Text + 4;
            resaultTextBox.ForeColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resaultTextBox.Text = resaultTextBox.Text + 5;
            resaultTextBox.ForeColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resaultTextBox.Text = resaultTextBox.Text + 6;
            resaultTextBox.ForeColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resaultTextBox.Text = resaultTextBox.Text + 7;
            resaultTextBox.ForeColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resaultTextBox.Text = resaultTextBox.Text + 8;
            resaultTextBox.ForeColor = Color.Red;
        }
      

        private void button9_Click(object sender, EventArgs e)
        {
            resaultTextBox.Text = resaultTextBox.Text + 9;
            resaultTextBox.ForeColor = Color.Red;
        }
    }
}
