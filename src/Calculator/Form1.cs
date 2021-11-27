using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private bool symbolPressed = false;
        private double firstValue;
        private double secondValue;
        private string symbolType;
        private double result;
        private string finalResult;
        private double secondPower;
        private double onePerX;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if(symbolPressed == true)
            {
                textDisplay.Text = "0";
                symbolPressed = false;
            }
            else
            {
                if(textDisplay.Text == "0")
                {
                    textDisplay.Text = "0";
                }
                else
                {
                    textDisplay.Text += "0";
                } 
            }
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (symbolPressed == true)
            {
                textDisplay.Text = "1";
                symbolPressed = false;
            }
            else
            {
                if (textDisplay.Text == "0")
                {
                    textDisplay.Text = "1";
                }
                else
                {
                    textDisplay.Text += "1";
                }
            }
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (symbolPressed == true)
            {
                textDisplay.Text = "2";
                symbolPressed = false;
            }
            else
            {
                if (textDisplay.Text == "0")
                {
                    textDisplay.Text = "2";
                }
                else
                {
                    textDisplay.Text += "2";
                }
            }
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (symbolPressed == true)
            {
                textDisplay.Text = "3";
                symbolPressed = false;
            }
            else
            {
                if (textDisplay.Text == "0")
                {
                    textDisplay.Text = "3";
                }
                else
                {
                    textDisplay.Text += "3";
                }
            }
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (symbolPressed == true)
            {
                textDisplay.Text = "4";
                symbolPressed = false;
            }
            else
            {
                if (textDisplay.Text == "0")
                {
                    textDisplay.Text = "4";
                }
                else
                {
                    textDisplay.Text += "4";
                }
            }
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {

            if (symbolPressed == true)
            {
                textDisplay.Text = "5";
                symbolPressed = false;
            }
            else
            {
                if (textDisplay.Text == "0")
                {
                    textDisplay.Text = "5";
                }
                else
                {
                    textDisplay.Text += "5";
                }
            }
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (symbolPressed == true)
            {
                textDisplay.Text = "6";
                symbolPressed = false;
            }
            else
            {
                if (textDisplay.Text == "0")
                {
                    textDisplay.Text = "6";
                }
                else
                {
                    textDisplay.Text += "6";
                }
            }
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {

            if (symbolPressed == true)
            {
                textDisplay.Text = "7";
                symbolPressed = false;
            }
            else
            {
                if (textDisplay.Text == "0")
                {
                    textDisplay.Text = "7";
                }
                else
                {
                    textDisplay.Text += "7";
                }
            }
        }

        private void eightButton_Click(object sender, EventArgs e)
        {

            if (symbolPressed == true)
            {
                textDisplay.Text = "8";
                symbolPressed = false;
            }
            else
            {
                if (textDisplay.Text == "0")
                {
                    textDisplay.Text = "8";
                }
                else
                {
                    textDisplay.Text += "8";
                }
            }
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (symbolPressed == true)
            {
                textDisplay.Text = "9";
                symbolPressed = false;
            }
            else
            {
                if (textDisplay.Text == "0")
                {
                    textDisplay.Text = "9";
                }
                else
                {
                    textDisplay.Text += "9";
                }
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(textDisplay.Text);
            symbolPressed = true;
            textDisplay.Text += " + ";
            //textDisplay.Text = "";
            symbolType = "+";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(textDisplay.Text);
            symbolPressed = true;
            textDisplay.Text += " - ";
            //textDisplay.Text = "";
            symbolType = "-";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(textDisplay.Text);
            symbolPressed = true;
            textDisplay.Text += " * ";
            //textDisplay.Text = "";
            symbolType = "*";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(textDisplay.Text);
            symbolPressed = true;
            textDisplay.Text += " / ";
            //textDisplay.Text = "";
            symbolType = "/";
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            textDisplay.Text += ".";
        }

        private void percentButton_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(textDisplay.Text);
            symbolPressed = true;
            textDisplay.Text += " % ";
            symbolType = "%";
        }

        private void radButton_Click(object sender, EventArgs e)
        {
            if (symbolPressed == false)
            {
                secondValue = double.Parse(textDisplay.Text);
                double rad = Math.Sqrt(secondValue);
                textDisplay.Text = rad.ToString();
                symbolPressed = false;
            }
            else
            {
                firstValue = double.Parse(textDisplay.Text);
                double rad = Math.Sqrt(firstValue);
                textDisplay.Text = rad.ToString();
                symbolPressed = true;
            }
        }

        private void powerTwoButton_Click(object sender, EventArgs e)
        {
            if(symbolPressed == false)
            {
                secondValue = double.Parse(textDisplay.Text);
                secondPower = secondValue * secondValue;
                textDisplay.Text = secondPower.ToString();
                symbolPressed = false;
            }
            else
            {
                firstValue = double.Parse(textDisplay.Text);
                secondPower = firstValue * firstValue;
                textDisplay.Text = secondPower.ToString();
                symbolPressed = true;
            }         
        }

        private void radicalButton_Click(object sender, EventArgs e)
        {
            if (symbolPressed == false)
            {
                secondValue = double.Parse(textDisplay.Text);
                onePerX = 1 / secondValue;
                textDisplay.Text = onePerX.ToString();
            }
            else
            {
                firstValue = double.Parse(textDisplay.Text);
                onePerX = 1 / firstValue;
                textDisplay.Text = onePerX.ToString();
                symbolPressed = true;
            }
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1);
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            secondValue = double.Parse(textDisplay.Text);
            if(firstValue != 0 && secondValue != 0)
            {
                if(symbolType == "+")
                {
                    result = firstValue + secondValue;
                }
                else if(symbolType == "-")
                {
                    result = firstValue - secondValue;
                }
                else if (symbolType == "*")
                {
                    result = firstValue * secondValue;
                }
                else if (symbolType == "/")
                {
                    result = firstValue / secondValue;
                }
                else if (symbolType == "%")
                {
                    result = firstValue % secondValue;
                }

                finalResult = result.ToString();
                textDisplay.Text = finalResult;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            firstValue = 0;
            secondValue = 0;
            textDisplay.Text = "0";
        }

        private void resetButton2_Click(object sender, EventArgs e)
        {
            secondValue = 0;
            textDisplay.Text = "0";
        }
    }
}
