using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsCalculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operatorUsed = "";
        Boolean operationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void resultTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (resultTB.Text == "0" || operationPerformed == true)
                resultTB.Clear();
            operationPerformed = false; 
            
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (resultTB.Text.Contains("."))
                    resultTB.Text = resultTB.Text + button.Text;
               
            }
            else
            resultTB.Text = resultTB.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatorUsed = button.Text;
            result = Double.Parse(resultTB.Text);
            label1.Text = result + operatorUsed;
            operationPerformed = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultTB.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultTB.Text = "";
            result = 0;
            label1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch(operatorUsed)
            {
                case "+" :
                    resultTB.Text = (result + Double.Parse(resultTB.Text)).ToString();
                    break;

                case "-":
                    resultTB.Text = (result - Double.Parse(resultTB.Text)).ToString();
                    break;

                case "*":
                    resultTB.Text = (result * Double.Parse(resultTB.Text)).ToString();
                    break;

                case "/":
                    resultTB.Text = (result / Double.Parse(resultTB.Text)).ToString();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
