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
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textScr.Text == "0" || textScr.Text == null)
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
            if (textScr.Text == "0" || textScr.Text == null)
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
            if (textScr.Text == "0" || textScr.Text == null)
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
            if (textScr.Text == "0" || textScr.Text == null)
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
            if (textScr.Text == "0" || textScr.Text == null)
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
            if (textScr.Text == "0" || textScr.Text == null)
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
            if (textScr.Text == "0" || textScr.Text == null)
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
            if (textScr.Text == "0" || textScr.Text == null)
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
            if (textScr.Text == "0" || textScr.Text == null)
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
            if (textScr.Text == "0" || textScr.Text == null)
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
                if (textScr.Text == "0" || textScr.Text == null)
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
            //if (operation != "")
            //{
                if (textScr.Text != "")
                {
                    firstNumber = Convert.ToDouble(textScr.Text);
                    operationBox.Text = textScr.Text + "+";
                }
                else
                {
                    operationBox.Text = result + "+";
                }
            //}
            //else
            //{
            //    btnEqu_Click();
            //}
            textScr.Text = null;
            operation = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (textScr.Text != "")
            {
                firstNumber = Convert.ToDouble(textScr.Text);
                operationBox.Text = textScr.Text + "-";
            }
            else
            {
                operationBox.Text = result + "-";
            }
            textScr.Text = null;
            operation = "-";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (textScr.Text != "")
            {
                firstNumber = Convert.ToDouble(textScr.Text);
                operationBox.Text = textScr.Text + "*";
            }
            else
            {
                operationBox.Text = result + "*";
            }
            textScr.Text = null;
            operation = "*";
        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            if (textScr.Text != "")
            {
                firstNumber = Convert.ToDouble(textScr.Text);
                operationBox.Text = textScr.Text + "/";
            }
            else
            {
                operationBox.Text = result + "/";
            }
            textScr.Text = null;
            operation = "/";
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            if (textScr.Text != "")
            {
                firstNumber = Convert.ToDouble(textScr.Text);
                operationBox.Text = textScr.Text + "^";
            }
            else
            {
                operationBox.Text = result + "^";
            }
            textScr.Text = null;
            operation = "^";
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            operationBox.Text = "√" + textScr.Text;
            result = Math.Sqrt(Convert.ToDouble(textScr.Text));
            operationBox.Text = "√" + textScr.Text + "=" + result;
            firstNumber = result;
            textScr.Text = null;
            operation = null;
        }

        private void btnEqu_Click(object sender, EventArgs e)
        {
            if (operation != null)
            {
                operationBox.Text = operationBox.Text + textScr.Text + "=";
                switch (operation)
                {
                    case "+":
                        result = firstNumber + Convert.ToDouble(textScr.Text);
                        operationBox.Text = operationBox.Text + result;
                        break;
                    case "-":
                        result = firstNumber - Convert.ToDouble(textScr.Text);
                        operationBox.Text = operationBox.Text + result;
                        break;
                    case "*":
                        result = firstNumber * Convert.ToDouble(textScr.Text);
                        operationBox.Text = operationBox.Text + result;
                        break;
                    case "/":
                        if (Convert.ToDouble(textScr.Text) != 0)
                        {
                            result = firstNumber / Convert.ToDouble(textScr.Text);
                            operationBox.Text = operationBox.Text + result;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("You can't devide by 0!");
                            break;
                        }
                    case "^":
                        result = firstNumber;
                        for (int i = 1; i < Convert.ToInt32(textScr.Text); i++)
                        {
                            result = result * firstNumber;
                        }
                        operationBox.Text = operationBox.Text + result;
                        break;
                }
                firstNumber = result;
                textScr.Text = null;
                operation = null;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            operation = null;
            result = 0;
            textScr.Text = null;
            operationBox.Text = null;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textScr.Text = null;
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
    }
}
