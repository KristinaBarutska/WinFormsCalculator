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

        private void buttonOFF_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void buttonON_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            resaultTextBox.Text = resaultTextBox.Text + ".";
            resaultTextBox.ForeColor = Color.Red;
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
