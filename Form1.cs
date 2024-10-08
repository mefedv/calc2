﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace calc2
{
    public partial class Form1 : Form
    {
        private double currentValue = 0;
        private string currentOperation = "0";
        private double previousValue = 0;
        public Form1()
        {
            InitializeComponent();
        }

      
            private void button1_Click(object sender, EventArgs e)
            {
                textBox1.Text = textBox1.Text + 1; 
            }
            private void button2_Click(object sender, EventArgs e)
            {

                textBox1.Text = textBox1.Text + 2;

            }
            private void button3_Click(object sender, EventArgs e)
            {

                textBox1.Text = textBox1.Text + 3;

            }
            private void button4_Click(object sender, EventArgs e)
            {

                textBox1.Text = textBox1.Text + 4;

            }
            private void button5_Click(object sender, EventArgs e)
            {

                textBox1.Text = textBox1.Text + 5;

            }
            private void button6_Click(object sender, EventArgs e)
            {

                textBox1.Text = textBox1.Text + 6;

            }
            private void button7_Click(object sender, EventArgs e)
            {

                textBox1.Text = textBox1.Text + 7;

            }
            private void button8_Click(object sender, EventArgs e)
            {

                textBox1.Text = textBox1.Text + 8;

            }
            private void button9_Click(object sender, EventArgs e)
            {

                textBox1.Text = textBox1.Text + 9;

            }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            currentValue = float.Parse(textBox1.Text);
            
            currentOperation = "+";
            textBox1.Clear();

        }
        private void button12_Click(object sender, EventArgs e)
        {
            currentValue = float.Parse(textBox1.Text);
      
            currentOperation = "-";
            
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            currentValue = float.Parse(textBox1.Text);
          
            currentOperation = "*";
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            currentValue = float.Parse(textBox1.Text);
            
            currentOperation = "/";
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            calculate();
            
        }
        private void calculate()
        {
            switch (currentOperation)
            {
                 case "+":
                    previousValue = currentValue + float.Parse(textBox1.Text);
                    textBox1.Text = previousValue.ToString();
                    break;
                case "-":
                    previousValue = currentValue - float.Parse(textBox1.Text);
                    textBox1.Text = previousValue.ToString();
                    break;
                case "*":
                    previousValue = currentValue * float.Parse(textBox1.Text);
                    textBox1.Text = previousValue.ToString();
                    break;
                case "/":
                    if (currentValue == 0)
                        {
                        textBox1.Text = "Ошибка";
                        return;

                    }
                    previousValue = currentValue / float.Parse(textBox1.Text);
                    textBox1.Text = previousValue.ToString();
                    break;
            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            currentValue = float.Parse(textBox1.Text);
            textBox1.Text = Math.Pow(currentValue, 2).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            currentValue = float.Parse(textBox1.Text);
            textBox1.Text = Math.Sin(currentValue).ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            currentValue = float.Parse(textBox1.Text);
            textBox1.Text = Math.Cos(currentValue).ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            currentValue = float.Parse(textBox1.Text);
            textBox1.Text = Math.Pow(currentValue,0.5).ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",'";
        }
    }
    }


