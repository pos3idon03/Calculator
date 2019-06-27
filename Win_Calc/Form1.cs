using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Win_Calc
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_pressed))
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            
            equation.Text = "";
            switch (operation)
            {
                case "+": result.Text = (value + Double.Parse(result.Text)).ToString();break;
                case "-": result.Text = (value - Double.Parse(result.Text)).ToString(); break;
                case "X": result.Text = (value * Double.Parse(result.Text)).ToString(); break;
                case "/": result.Text = (value / Double.Parse(result.Text)).ToString(); break;
                case "sqrt": result.Text = (Math.Pow(value,1/2)).ToString(); break;
                case "x^2": result.Text = (Math.Pow(value, 2)).ToString(); break;
                case "1/x": result.Text = (1/value).ToString(); break;
                default: break;

            }//end  switch
            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }
    }
}
