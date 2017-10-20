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
        private int _firstNumber = 0, _secondNumber = 0;
        private double _answer = 0;
        private string _currentText;
        public MainWindow()
        {
            InitializeComponent();
            _currentText = Calculator_Display.Text;
        }

        private void Number_0_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("0");
        }

        private void Number_1_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("1");
        }

        private void Number_2_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("2");
        }

        private void Number_3_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("3");
        }

        private void Number_4_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("4");
        }

        private void Number_5_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("5");
        }

        private void Number_6_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("6");
        }

        private void Number_7_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("7");
        }

        private void Number_8_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("8");
        }

        private void Number_9_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainText("9");
        }

        private void Operation_Equals_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Operation_Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Operation_Subtract_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Operation_Multiply_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Operation_Divide_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Operation_DivideFraction_Click(object sender, RoutedEventArgs e)
        {

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
    }
}
