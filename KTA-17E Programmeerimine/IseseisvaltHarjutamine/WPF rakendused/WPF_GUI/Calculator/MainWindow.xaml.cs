using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _firstNumber, _secondNumber;// _answer;
        private string _currentText, _lastOperation;//, _secondaryText;
        public MainWindow()
        {
            InitializeComponent();
            HardReset();
            _currentText = Calculator_Display.Text;
            //Calculator calculator = new Calculator();
        }

        private void Number_0_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("0");
            ChangeSecondaryText("0");
        }

        private void Number_1_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("1");
            ChangeSecondaryText("1");
        }

        private void Number_2_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("2");
            ChangeSecondaryText("2");
        }

        private void Number_3_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("3");
            ChangeSecondaryText("3");
        }

        private void Number_4_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("4");
            ChangeSecondaryText("4");
        }

        private void Number_5_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("5");
            ChangeSecondaryText("5");
        }

        private void Number_6_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("6");
            ChangeSecondaryText("6");
        }

        private void Number_7_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("7");
            ChangeSecondaryText("7");
        }

        private void Number_8_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("8");
            ChangeSecondaryText("8");
        }

        private void Number_9_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("9");
            ChangeSecondaryText("9");
        }

        private void Operation_Equals_Click(object sender, RoutedEventArgs e)
        {
            if (_firstNumber == 0)
            {
                return;
            }
            _secondNumber = double.Parse(Calculator_Display.Text);
            Calculator_Secondary_Display.Text = "";
            switch (_lastOperation)
            {
                case "+":
                    Calculator_Display.Text = (_firstNumber + _secondNumber).ToString();
                    SoftReset();
                    break;
                case "-":
                    Calculator_Display.Text = (_firstNumber - _secondNumber).ToString();
                    SoftReset();
                    break;
                case "x":
                    Calculator_Display.Text = (_firstNumber * _secondNumber).ToString();
                    SoftReset();
                    break;
                case "/":
                    Calculator_Display.Text = (_firstNumber / _secondNumber).ToString();
                    SoftReset();
                    break;
            }
        }

        private void Operation_Add_Click(object sender, RoutedEventArgs e)
        {
            ChangeSecondaryText("+");
            OperationClicked("+");

        }

        private void Operation_Subtract_Click(object sender, RoutedEventArgs e)
        {
            ChangeSecondaryText("-");
            OperationClicked("-");

        }

        private void Operation_Multiply_Click(object sender, RoutedEventArgs e)
        {
            ChangeSecondaryText("x");
            OperationClicked("x");

        }

        private void Operation_Divide_Click(object sender, RoutedEventArgs e)
        {
            ChangeSecondaryText("/");
            OperationClicked("/");
        }

        private void Operation_Clear_Click(object sender, RoutedEventArgs e)
        {
            HardReset();
        }

        private void ChangeMainText(string inputNumber)
        {
            if (_currentText == "0")
            {
                _currentText = inputNumber;
                Calculator_Display.Text = _currentText;
            }
            else
            {
                _currentText = _currentText + inputNumber;
                Calculator_Display.Text = _currentText;
            }
        }

        private void ChangeSecondaryText(string inputString)
        {
            if (Calculator_Display.Text != "0" && _currentText != "0")
            {
                Calculator_Secondary_Display.Text += inputString;
            }
        }

        private void OperationClicked(string operation)
        {
            switch (operation)
            {
                case "+":
                    if (_firstNumber == 0 || _currentText == "0")
                    {
                        _firstNumber = double.Parse(Calculator_Display.Text);
                        _currentText = "0";
                        _lastOperation = "+";
                        return;
                    }
                    _firstNumber = AddTwoNumbers(_firstNumber, int.Parse(Calculator_Display.Text));
                    Calculator_Display.Text = _firstNumber.ToString();
                    _currentText = "0";
                    _lastOperation = "+";
                    break;
                case "-":
                    if (_firstNumber == 0 || _currentText == "0")
                    {
                        _firstNumber = double.Parse(Calculator_Display.Text);
                        _currentText = "0";
                        _lastOperation = "-";
                        return;
                    }
                    _firstNumber = SubtractTwoNumbers(_firstNumber, int.Parse(Calculator_Display.Text));
                    Calculator_Display.Text = _firstNumber.ToString();
                    _currentText = "0";
                    _lastOperation = "-";
                    break;
                case "x":
                    if (_firstNumber == 0 || _currentText == "0")
                    {
                        _firstNumber = double.Parse(Calculator_Display.Text);
                        _currentText = "0";
                        _lastOperation = "x";
                        return;
                    }
                    _firstNumber = MultiplyTwoNumbers(_firstNumber, int.Parse(Calculator_Display.Text));
                    Calculator_Display.Text = _firstNumber.ToString();
                    _currentText = "0";
                    _lastOperation = "x";
                    break;
                case "/":
                    if (_firstNumber == 0 || _currentText == "0")
                    {
                        _firstNumber = double.Parse(Calculator_Display.Text);
                        _currentText = "0";
                        _lastOperation = "/";
                        return;
                    }
                    _firstNumber = DivideTwoNumbers(_firstNumber, int.Parse(Calculator_Display.Text));
                    Calculator_Display.Text = _firstNumber.ToString();
                    _currentText = "0";
                    _lastOperation = "/";
                    break;
            }
        }

        private void HardReset()
        {
            _currentText = "0";
            _firstNumber = 0;
            _secondNumber = 0;
            Calculator_Display.Text = "0";
            Calculator_Secondary_Display.Text = "";
        }

        private void SoftReset()
        {
            _firstNumber = 0;
            _secondNumber = 0;
            _currentText = "0";
        }

        private double AddTwoNumbers(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        private double SubtractTwoNumbers(double numOne, double numTwo)
        {
            return numOne - numTwo;
        }

        private double MultiplyTwoNumbers(double numOne, double numTwo)
        {
            return numOne * numTwo;
        }

        private double DivideTwoNumbers(double numOne, double numTwo)
        {
            return numOne / numTwo;
        }
    }
}