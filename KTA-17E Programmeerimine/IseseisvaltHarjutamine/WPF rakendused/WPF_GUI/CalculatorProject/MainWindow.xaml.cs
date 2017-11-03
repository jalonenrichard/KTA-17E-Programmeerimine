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

namespace CalculatorProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Public Properties

        /// <summary>
        /// Left side of the equation
        /// </summary>
        public double LeftSide { get; private set; }

        /// <summary>
        /// Right side of the equation
        /// </summary>
        public double RightSide { get; private set; }

        /// <summary>
        /// Last operation
        /// </summary>
        public string Operation { get; private set; }

        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
            //Clear the screen when the calculator is fired up
            Clear_Click(null, null);
        }
        #endregion

        #region Number Buttons

        /// <summary>
        /// Number 0 button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Number_0_Click(object sender, RoutedEventArgs e)
        {
            //Add the content of the pressed button to the current display string
            InsertTextValue(this.Number_0.Content.ToString());
        }

        /// <summary>
        /// Number 1 button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Number_1_Click(object sender, RoutedEventArgs e)
        {
            //Add the content of the pressed button to the current display string
            InsertTextValue(this.Number_1.Content.ToString());
        }

        /// <summary>
        /// Number 2 button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Number_2_Click(object sender, RoutedEventArgs e)
        {
            //Add the content of the pressed button to the current display string
            InsertTextValue(this.Number_2.Content.ToString());
        }

        /// <summary>
        /// Number 3 button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Number_3_Click(object sender, RoutedEventArgs e)
        {
            //Add the content of the pressed button to the current display string
            InsertTextValue(this.Number_3.Content.ToString());
        }

        /// <summary>
        /// Number 4 button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Number_4_Click(object sender, RoutedEventArgs e)
        {
            //Add the content of the pressed button to the current display string
            InsertTextValue(this.Number_4.Content.ToString());
        }

        /// <summary>
        /// Number 5 button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Number_5_Click(object sender, RoutedEventArgs e)
        {
            //Add the content of the pressed button to the current display string
            InsertTextValue(this.Number_5.Content.ToString());
        }

        /// <summary>
        /// Number 6 button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Number_6_Click(object sender, RoutedEventArgs e)
        {
            //Add the content of the pressed button to the current display string
            InsertTextValue(this.Number_6.Content.ToString());
        }

        /// <summary>
        /// Number 7 button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Number_7_Click(object sender, RoutedEventArgs e)
        {
            //Add the content of the pressed button to the current display string
            InsertTextValue(this.Number_7.Content.ToString());
        }

        /// <summary>
        /// Number 8 button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Number_8_Click(object sender, RoutedEventArgs e)
        {
            //Add the content of the pressed button to the current display string
            InsertTextValue(this.Number_8.Content.ToString());
        }

        /// <summary>
        /// Number 9 button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Number_9_Click(object sender, RoutedEventArgs e)
        {
            //Add the content of the pressed button to the current display string
            InsertTextValue(this.Number_9.Content.ToString());
        }

        #endregion

        #region Operation Buttons

        /// <summary>
        /// When the "=" button is pressed calculate input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Operation_Equals_Click(object sender, RoutedEventArgs e)
        {
            //Calculate the equation
            OperationPressed(this.Operation);
        }

        /// <summary>
        /// When the "+" button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Operation_Add_Click(object sender, RoutedEventArgs e)
        {
            //Store the value as left side
            //If left side is already filled, divide the numbers and store the new operand
            OperationPressed(Operation_Add.Content.ToString());
        }

        /// <summary>
        /// When the "-" button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Operation_Subtract_Click(object sender, RoutedEventArgs e)
        {
            //Store the value as left side
            //If left side is already filled, divide the numbers and store the new operand
            OperationPressed(Operation_Subtract.Content.ToString());
        }

        /// <summary>
        /// When the "x" button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Operation_Multiply_Click(object sender, RoutedEventArgs e)
        {
            //Store the value as left side
            //If left side is already filled, divide the numbers and store the new operand
            OperationPressed(Operation_Multiply.Content.ToString());
        }

        /// <summary>
        /// When the "/" button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Operation_Divide_Click(object sender, RoutedEventArgs e)
        {
            //Store the value as left side
            //If left side is already filled, divide the numbers and store the new operand
            OperationPressed(Operation_Divide.Content.ToString());
        }

        #endregion

        #region Clear Button

        /// <summary>
        /// Clears the Calculator Display and resets all values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            //Set the Text of Calculator_Display TextBlock to an empty string
            this.Calculator_Display.Text = "0";
            //Reset the left and right side values of the operation and the operand
            this.LeftSide = 0;
            this.RightSide = 0;
            this.Operation = string.Empty;
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Change the Calculator display text adding the numbers our user has pressed
        /// </summary>
        /// <param name="textValue">The pressed number button content as a string</param>
        private void InsertTextValue(string textValue)
        {
            //If the current calculator screen value is 0 and 0 is the pressed button
            if (textValue == "0" && this.Calculator_Display.Text == "0")
            {
                return;
            }
            //if the current calculator screen value is 0 and the pressed button is anything
            else if ((this.Calculator_Display.Text == "0") || (this.LeftSide != 0 && RightSide == 0 && this.Calculator_Display.Text == this.LeftSide.ToString()))
            {
                //Set the text to be the pressed button so the 0 gets deleted
                this.Calculator_Display.Text = textValue;
                return;
            }
            //Otherwise add the string to the existing display text
            this.Calculator_Display.Text += textValue;
        }

        /// <summary>
        /// Store the left or right side value when an operation is pressed
        /// </summary>
        private void OperationPressed(string operand)
        {
            //If the left side of the operation is empty
            if (this.LeftSide == 0)
            {
                //Set the left side to be the current text
                this.LeftSide = int.Parse(this.Calculator_Display.Text);
                this.Operation = operand;
            }
            else
            {
                //Set the right side of the equation to be equal to the current text
                this.RightSide = int.Parse(this.Calculator_Display.Text);
                //Calculate the equation using the last operand
                CalculateAnswer(this.Operation);
                //And add switch the current operand
                this.Operation = operand;
            }
        }

        /// <summary>
        /// Calculate the answer of the equation
        /// </summary>
        private void CalculateAnswer(string operand)
        {
            //According to Operation, which is string type, do the according calculation and display it
            switch (operand)
            {
                //when the operation is +, add the left and right side, store the new value as the new left side
                case "+":
                    this.LeftSide += this.RightSide;
                    // set the right side to 0
                    this.RightSide = 0;
                    // and display the result
                    Calculator_Display.Text = this.LeftSide.ToString();
                    break;
                //when the operation is -, divide the left and right side, store the new value as the new left side
                case "-":
                    this.LeftSide -= this.RightSide;
                    // set the right side to 0
                    this.RightSide = 0;
                    // and display the result
                    Calculator_Display.Text = this.LeftSide.ToString();
                    break;
                //when the operation is X, multiply the left and right side, store the new value as the new left side
                case "X":
                    this.LeftSide *= this.RightSide;
                    // set the right side to 0
                    this.RightSide = 0;
                    // and display the result
                    Calculator_Display.Text = this.LeftSide.ToString();
                    break;
                //when the operation is /, divide the left and right side, store the new value as the new left side
                case "/":
                    //when trying to divide by 0
                    if (this.RightSide == 0)
                    {
                        return;
                    }
                    this.LeftSide /= this.RightSide;
                    // set the right side to 0
                    this.RightSide = 0;
                    // and display the result
                    Calculator_Display.Text = this.LeftSide.ToString();
                    break;
            }
        }

        #endregion
    }
}