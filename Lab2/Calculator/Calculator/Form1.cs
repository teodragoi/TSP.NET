using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string calculusString = "";
        private double finalResult = 0;
        private double firstNumber = 0;
        private double secondNumber = 0;
        private bool firstOperation = false;
        private string lastOperation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void updateFirstNumber(int number)
        {
            firstNumber = firstNumber * 10 + number;
            calculusString = firstNumber.ToString();
            this.displayTextBox.Text = calculusString;
        }

        private void updateSecondNumber(int number)
        {
            secondNumber = secondNumber * 10 + number;
            var index = calculusString.IndexOf(lastOperation);
            calculusString = calculusString.Substring(0, index + 1) + " " + secondNumber;
            this.displayTextBox.Text = calculusString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!firstOperation) updateFirstNumber(1);
            else updateSecondNumber(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!firstOperation) updateFirstNumber(2);
            else updateSecondNumber(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!firstOperation) updateFirstNumber(3);
            else updateSecondNumber(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!firstOperation) updateFirstNumber(4);
            else updateSecondNumber(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!firstOperation) updateFirstNumber(5);
            else updateSecondNumber(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!firstOperation) updateFirstNumber(6);
            else updateSecondNumber(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!firstOperation) updateFirstNumber(7);
            else updateSecondNumber(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!firstOperation) updateFirstNumber(8);
            else updateSecondNumber(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!firstOperation) updateFirstNumber(9);
            else updateSecondNumber(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!firstOperation) updateFirstNumber(0);
            else updateSecondNumber(0);
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            if (!firstOperation)
            {
                calculusString += " + ";
                lastOperation = "+";
            } else
            {
                firstNumber += secondNumber;
                secondNumber = 0;
                calculusString = firstNumber.ToString() + " + ";
            }
            this.displayTextBox.Text = calculusString;
            firstOperation = true;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (!firstOperation)
            {
                calculusString += " - ";
                lastOperation = "-";
            }
            else
            {
                firstNumber -= secondNumber;
                secondNumber = 0;
                calculusString = firstNumber.ToString() + " - ";
            }
            this.displayTextBox.Text = calculusString;
            firstOperation = true;
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            if (!firstOperation)
            {
                calculusString += " * ";
                lastOperation = "*";
            }
            else
            {
                firstNumber *= secondNumber;
                secondNumber = 0;
                calculusString = firstNumber.ToString() + " * ";
            }
            this.displayTextBox.Text = calculusString;
            firstOperation = true;
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            if (!firstOperation)
            {
                calculusString += " / ";
                lastOperation = "/";
            }
            else
            {
                firstNumber = (double)firstNumber/secondNumber;
                secondNumber = 0;
                calculusString = firstNumber.ToString() + " / ";
            }
            this.displayTextBox.Text = calculusString;
            firstOperation = true;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (lastOperation == "+") finalResult = firstNumber + secondNumber;
            else if (lastOperation == "-") finalResult = firstNumber - secondNumber;
            else if (lastOperation == "*") finalResult = firstNumber * secondNumber;
            else finalResult = firstNumber / secondNumber;
            firstNumber = finalResult;
            this.calculusString = firstNumber.ToString();
            this.displayTextBox.Text = finalResult.ToString();
            secondNumber = 0;
            lastOperation = "";
            firstOperation = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            firstOperation = false;
            calculusString = "";
            lastOperation = "";
            this.displayTextBox.Text = "";
        }
    }
}
