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
        double firstNumber;
        double secondNumber;
        double result;
        string operation = "";
        string history;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textScr.Text == "0")
            {
                textScr.Text = "1";
            }
            else
            {
                textScr.Text = textScr.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textScr.Text == "0")
            {
                textScr.Text = "2";
            }
            else
            {
                textScr.Text = textScr.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textScr.Text == "0")
            {
                textScr.Text = "3";
            }
            else
            {
                textScr.Text = textScr.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textScr.Text == "0")
            {
                textScr.Text = "4";
            }
            else
            {
                textScr.Text = textScr.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textScr.Text == "0")
            {
                textScr.Text = "5";
            }
            else
            {
                textScr.Text = textScr.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textScr.Text == "0")
            {
                textScr.Text = "6";
            }
            else
            {
                textScr.Text = textScr.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textScr.Text == "0")
            {
                textScr.Text = "7";
            }
            else
            {
                textScr.Text = textScr.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textScr.Text == "0")
            {
                textScr.Text = "8";
            }
            else
            {
                textScr.Text = textScr.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textScr.Text == "0")
            {
                textScr.Text = "9";
            }
            else
            {
                textScr.Text = textScr.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textScr.Text == "0")
            {
                textScr.Text = "0";
            }
            else
            {
                textScr.Text = textScr.Text + "0";
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!textScr.Text.Contains(","))
            {
                if (textScr.Text == "0")
                {
                    textScr.Text = "0,";
                }
                else
                {
                    textScr.Text = textScr.Text + ",";
                }
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                if (textScr.Text != "0")
                {
                    firstNumber = Convert.ToDouble(textScr.Text);
                    operationBox.Text = textScr.Text + "+";
                }
                else
                {
                    operationBox.Text = result + "+";
                }
            }
            else
            {
                Equal();
                operationBox.Text = result + "+";
            }
            textScr.Text = "0";
            operation = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (textScr.Text == "0" && !textScr.Text.Contains("-"))
            {
                textScr.Text = "-";
            }
            else if(operation == "")
            {
                if (textScr.Text != "0" && !textScr.Text.Contains("-"))
                {
                    firstNumber = Convert.ToDouble(textScr.Text);
                    operationBox.Text = firstNumber + "-";
                }
                else
                {
                    operationBox.Text = result + "-";
                }
                textScr.Text = "0";
                operation = "-";
            }
            else
            {
                Equal();
                operationBox.Text = result + "-";
                textScr.Text = "0";
                operation = "-";
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                if (textScr.Text != "0")
                {
                    firstNumber = Convert.ToDouble(textScr.Text);
                    operationBox.Text = firstNumber + "*";
                }
                else
                {
                    operationBox.Text = result + "*";
                }
            }
            else
            {
                Equal();
                operationBox.Text = result + "*";
            }
            textScr.Text = "0";
            operation = "*";
        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                if (textScr.Text != "0")
                {
                    firstNumber = Convert.ToDouble(textScr.Text);
                    operationBox.Text = firstNumber + "/";
                }
                else
                {
                    operationBox.Text = result + "/";
                }
            }
            else
            {
                Equal();
                operationBox.Text = result + "/";
            }
            textScr.Text = "0";
            operation = "/";
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                if (textScr.Text != "0")
                {
                    firstNumber = Convert.ToDouble(textScr.Text);
                    operationBox.Text = firstNumber + "^";
                }
                else
                {
                    operationBox.Text = result + "^";
                }
            }
            else
            {
                Equal();
            }
            textScr.Text = "0";
            operation = "^";
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            if (operation == "" && result != 0)
            {
                firstNumber = result;
            }
            else if (operation == "")
            {
                firstNumber = Convert.ToDouble(textScr.Text);
            }
            else
            {
                Equal();
            }
            result = Math.Sqrt(firstNumber);
            operationBox.Text = "√" + firstNumber + "=" + result;
            firstNumber = result;
            textScr.Text = "0";
            operation = "";
        }

        private void btnEqu_Click(object sender, EventArgs e)
        {
            Equal();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            operation = "";
            result = 0;
            textScr.Text = "0";
            operationBox.Text = "0";
            history = "";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textScr.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.SetToolTip(this.btnC, "Clear everything");
            toolTip1.SetToolTip(this.btnCE, "Clear actuall line");
            toolTip1.SetToolTip(this.btnRoot, "Insert number then click this symbol to sqrRoot");
            toolTip1.SetToolTip(this.btnSum, "Sum two numbers");
            toolTip1.SetToolTip(this.btnSub, "Subtracts a number from a number");
            toolTip1.SetToolTip(this.btnMul, "Multiply number by a number");
            toolTip1.SetToolTip(this.btnDev, "Devide number by another number. Can't devide by 0");
            toolTip1.SetToolTip(this.btnSqr, "Number to power of another number");
        }

        private void Equal()
        {
            if (operation != "" && textScr.Text != "-")
            {
                secondNumber = Convert.ToDouble(textScr.Text);
                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                        {
                            result = firstNumber / secondNumber;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("You can't devide by 0!", "Devide error");
                            break;
                        }
                    case "^":
                        result = Math.Pow(firstNumber, secondNumber);
                        break;
                }
                if ((operation != "/") || (operation == "/" && secondNumber != 0))
                {
                    operationBox.Text = firstNumber + operation + secondNumber + "=" + result;
                    history = history + "\n" + operationBox.Text;
                    operation = "";
                    firstNumber = result;
                }               
                textScr.Text = "0";              
            }
        }

        private void btnHis_Click(object sender, EventArgs e)
        {
            MessageBox.Show(history, "History");
        }
    }
}
