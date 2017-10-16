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
    

        private void buttonOFF_Click(object sender, EventArgs e)
        {

        }

        private void buttonON_Click(object sender, EventArgs e)
        {
            
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
