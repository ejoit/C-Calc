using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        double answerA = 0;
        double answerB = 0;
        bool btnPlusbuttonClicked = false;
        bool btnMinusbuttonClicked = false;


        private void btnPlus_Click(object sender, EventArgs e)
        {
            answerA = answerA + double.Parse(txtCalc.Text);
            txtCalc.Clear();
            btnPlusbuttonClicked = true;
            btnMinusbuttonClicked = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCalc.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (btnPlusbuttonClicked == true)
                answerB = answerA + double.Parse(txtCalc.Text);
            else if (btnMinusbuttonClicked == true)
                answerB = answerA - double.Parse(txtCalc.Text);
            txtCalc.Text = answerB.ToString();
            answerA = 0;


        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + ".";
        }


       


        private void btnMinus_Click(object sender, EventArgs e)
        {
            answerA = answerA + double.Parse(txtCalc.Text);
            txtCalc.Clear();
            btnPlusbuttonClicked = false;
            btnMinusbuttonClicked = true;

        }
    }
}
