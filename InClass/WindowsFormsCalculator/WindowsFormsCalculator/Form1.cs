using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculator
{
    public partial class Form1 : Form
    {
        // 변수 선언
        enum Operators
        {
            None, Add, Subtract, Multiply, Divide, Result
        }

        Operators currentOperator = Operators.None;
        Boolean operatorChangeFlag = false;
        int operand1 = 0;
        int operand2 = 0;

        public Form1()
        {
            InitializeComponent();
            displayResult.Text = "";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                displayResult.Text = "";
                operatorChangeFlag = false;
            }
            displayResult.Text += "7";
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                displayResult.Text = "";
                operatorChangeFlag = false;
            }
            displayResult.Text += "8";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            operand1 = Int32.Parse(displayResult.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                displayResult.Text = "";
                operatorChangeFlag = false;
            }
            displayResult.Text += "4";
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                displayResult.Text = "";
                operatorChangeFlag = false;
            }
            displayResult.Text += "5";
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                displayResult.Text = "";
                operatorChangeFlag = false;
            }
            displayResult.Text += "6";
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            operand1 = Int32.Parse(displayResult.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                displayResult.Text = "";
                operatorChangeFlag = false;
            }
            displayResult.Text += "1";
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                displayResult.Text = "";
                operatorChangeFlag = false;
            }
            displayResult.Text += "2";
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                displayResult.Text = "";
                operatorChangeFlag = false;
            }
            displayResult.Text += "3";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operand1 = Int32.Parse(displayResult.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            operand1 = 0;
            operand2 = 0;
            currentOperator = Operators.None;
            displayResult.Text = "";
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                displayResult.Text = "";
                operatorChangeFlag = false;
            }
            displayResult.Text += "0";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            operand2 = Int32.Parse(displayResult.Text);
            if (currentOperator == Operators.Add)
            {
                operand1 += operand2;
                displayResult.Text = operand1.ToString();
            }
            else if (currentOperator == Operators.Subtract)
            {
                operand1 -= operand2;
                displayResult.Text = operand1.ToString();
            }
            else if (currentOperator == Operators.Multiply)
            {
                operand1 *= operand2;
                displayResult.Text = operand1.ToString();
            }
            else if (currentOperator == Operators.Divide)
            {
                if (operand2 == 0)
                {
                    displayResult.Text = "[오류] 0으로 나눌수 없음";
                }
                else
                {
                    operand1 /= operand2;
                    displayResult.Text = operand1.ToString();
                }
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operand1 = Int32.Parse(displayResult.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                displayResult.Text = "";
                operatorChangeFlag = false;
            }
            displayResult.Text += "9";
        }
    }
}
