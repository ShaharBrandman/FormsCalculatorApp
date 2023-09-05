﻿using System;
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
    public partial class CalculatorForm : Form
    {

        public TextBox numberScope;

        public CalculatorForm()
        {
            InitializeComponent();
            numberScope = firstNumber;
        }

        public void validateScope()
        {
            if(numberScope == firstNumber)
            {
                numberScope = secondNumber;
            }
        }

        private string calculate()
        {

            float a = float.Parse(firstNumber.Text);
            float b = float.Parse(secondNumber.Text);

            float c = 0;

            switch(MathOperator.Text)
            {
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
                case "/":
                    c = a / b;
                    break;
                case "*":
                    c = a * b;
                    break;
                default:
                    return "CUNT";
                   
            }

            return c + "";
        }

        private void one_Click(object sender, EventArgs e)
        {
            numberScope.Text += 1;
        }

        private void two_Click(object sender, EventArgs e)
        {
            numberScope.Text += 2;
        }

        private void three_Click(object sender, EventArgs e)
        {
            numberScope.Text += 3;
        }

        private void four_Click(object sender, EventArgs e)
        {
            numberScope.Text += 4;
        }

        private void five_Click(object sender, EventArgs e)
        {
            numberScope.Text += 5;
        }

        private void six_Click(object sender, EventArgs e)
        {
            numberScope.Text += 6;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            numberScope.Text += 7;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            numberScope.Text += 8;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            numberScope.Text += 9;
        }
        private void zero_Click(object sender, EventArgs e)
        {
            numberScope.Text += 0;
        }

        private void add_Click(object sender, EventArgs e)
        {
            validateScope();
            MathOperator.Text = "+";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            numberScope.Text += ".";
        }

        private void getResult_Click(object sender, EventArgs e)
        {
            Result.Text = calculate();
            firstNumber.Text = "";
            secondNumber.Text = "";
            MathOperator.Text = "";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            validateScope();
            MathOperator.Text = "-";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            validateScope();
            MathOperator.Text = "/";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            validateScope();
            MathOperator.Text = "*";
        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void firstNumber_TextChanged(object sender, EventArgs e)
        {
            numberScope = firstNumber;
        }

        private void MathOperator_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void secondNumber_MouseEnter(object sender, EventArgs e)
        {
            numberScope = secondNumber;
        }

        private void firstNumber_MouseEnter(object sender, EventArgs e)
        {
            numberScope = firstNumber;
        }
    }
}
