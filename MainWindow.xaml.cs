using System;
using System.Windows;
using System.Windows.Controls;

namespace my_wpf_app
{
    public partial class MainWindow : Window


    {
        private double firstNumber = 0;

        private double secondNumber = 0;
        private string operation = string.Empty;
        private bool isOperatorPressed = false;
        private double result = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string value = button.Tag.ToString(); // Get the Tag value
            InputBox.Text += value; // Append the value to the input box
            if (isOperatorPressed)
            {
                secondNumber = double.Parse(value);
                // isOperatorPressed = false;
            }
            else
            {
                firstNumber = double.Parse(InputBox.Text);
            }
        }

        private void Operator_click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string operatorValue = button.Tag.ToString(); // Get the operator value
            if (operatorValue == "Add")
            {
                operation = "+";
                InputBox.Text = string.Empty; // Clear the input box for the next number
                isOperatorPressed = true;
            }
            else if (operatorValue == "Subtract")
            {
                operation = "-";
                InputBox.Text = string.Empty; // Clear the input box for the next number
                isOperatorPressed = true;
            }
            else if (operatorValue == "Multiply")
            {
                operation = "*";
                InputBox.Text = string.Empty; // Clear the input box for the next number
                isOperatorPressed = true;
            }
            else if (operatorValue == "Divide")
            {
                operation = "/";
                InputBox.Text = string.Empty; // Clear the input box for the next number
                isOperatorPressed = true;
            }
            else if (operatorValue == "Equals")
            {
                if (operation != string.Empty)
                {
                    // Perform the calculation
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
                            result = firstNumber / secondNumber;
                            break;
                    }
                    InputBox.Text = result.ToString();
                    firstNumber = result;
                    secondNumber = 0;
                }
            }
            else if (operatorValue == "Clear" || operatorValue == "ClearAll")
            {
                InputBox.Text = string.Empty; // Clear the input box
                firstNumber = 0;
                secondNumber = 0;
                operation = string.Empty;
                isOperatorPressed = false;
            }
            else if (operatorValue == "Delete")
            {
                if (InputBox.Text.Length > 0)
                {
                    InputBox.Text = InputBox.Text.Remove(InputBox.Text.Length - 1);
                }
            }
            else if (operatorValue == "Decimal")
            {
                if (!InputBox.Text.Contains("."))
                {
                    InputBox.Text += ".";
                }
            }
        }

    }
}