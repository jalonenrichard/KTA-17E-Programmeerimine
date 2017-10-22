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
        public MainWindow()
        {
            InitializeComponent();
        }

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
        /// When the "=" button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Operation_Equals_Click(object sender, RoutedEventArgs e)
        {
            CalculateEquation();
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

        #endregion

        #region Clear Button

        /// <summary>
        /// Clears the Calculator Display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            //Set the Text of Calculator_Display TextBlock to an empty string
            this.Calculator_Display.Text = string.Empty;
        }

        #endregion

        #region Private Helpers
        
        /// <summary>
        /// Change the Calculator display text adding the numbers our user has pressed
        /// </summary>
        /// <param name="textValue">The pressed number button content as a string</param>
        private void InsertTextValue(string textValue)
        {
            //If the added number is 0 and the display text is already empty...
            if (textValue == "0" && this.Calculator_Display.Text == string.Empty)
            {
                //Do nothing
                return;
            }
            //Otherwise add the string to the existing display text
            this.Calculator_Display.Text += textValue;
        }

        /// <summary>
        /// Calculate the given equation and output the result
        /// </summary>
        private void CalculateEquation()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
