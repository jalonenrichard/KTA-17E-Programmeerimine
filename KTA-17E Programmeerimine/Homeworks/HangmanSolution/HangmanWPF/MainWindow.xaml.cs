using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HangmanWPF
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Current game of hangman
        /// </summary>
        private HangmanGame hangmanGame { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            // Start a new game of hangman
            hangmanGame = new HangmanGame();
            // Create the guessing GUI (labels for each letter in the word)
            CreateWordGuessLabels(hangmanGame.WordToGuess);
            // Create the Alphabet GUI (buttons for each letter in the alphabet)
            CreateAphabetButtons();
        }

        #region GUI populating methods

        /// <summary>
        /// Populate the MainGrid with Labels according to the word length
        /// </summary>
        /// <param name="wordToGuess"></param>
        private void CreateWordGuessLabels(string wordToGuess)
        {
            // Create a grid to store each word letter
            Grid dynamicGrid = WordGrid;

            // Grid styling
            dynamicGrid.Width = WindowMain.Width;
            dynamicGrid.Margin = new Thickness(10, 25, 10, 25);
            dynamicGrid.HorizontalAlignment = HorizontalAlignment.Center;
            dynamicGrid.VerticalAlignment = VerticalAlignment.Top;

            // Create only 1 row for the word
            RowDefinition gridRow = new RowDefinition();
            dynamicGrid.RowDefinitions.Add(gridRow);

            // Go through each letter that the user is trying to guess and populate the grid
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                // Create a new column for each new letter
                ColumnDefinition gridCol = new ColumnDefinition();
                dynamicGrid.ColumnDefinitions.Add(gridCol);

                // Create the label to store the letter
                Label label = new Label();

                // Label styling
                // if the character is - or ', reveal it right away
                if (IsSpecialChar(wordToGuess[i]))
                {
                    label.Content = wordToGuess[i];
                }
                else
                {
                    label.Content = "_";
                }
                label.VerticalAlignment = VerticalAlignment.Center;
                label.HorizontalAlignment = HorizontalAlignment.Center;
                label.FontSize = 30;
                label.FontWeight = FontWeights.Bold;

                // Label positioning
                // First row always
                Grid.SetRow(label, 0);
                // Each label goes to a new separate column
                Grid.SetColumn(label, i);

                // Add the label to the grid
                dynamicGrid.Children.Add(label);
            }
        }

        /// <summary>
        /// Create buttons for each letter of the alphabet to guess the word
        /// </summary>
        private void CreateAphabetButtons()
        {
            // Create a new grid to store the alphabet buttons
            Grid dynamicGrid = AlphabetGrid;

            // Grid styling
            //dynamicGrid.Width = WindowMain.Width;
            dynamicGrid.HorizontalAlignment = HorizontalAlignment.Center;
            dynamicGrid.VerticalAlignment = VerticalAlignment.Bottom;

            // Letters go in 2 rows
            RowDefinition gridRow = new RowDefinition();
            dynamicGrid.RowDefinitions.Add(gridRow);
            RowDefinition gridRow2 = new RowDefinition();
            dynamicGrid.RowDefinitions.Add(gridRow2);

            // Count variable to populate the columns
            int count = 0;
            // Go through each letter of the alphabet and populate the grid
            foreach (Alphabet letter in Enum.GetValues(typeof(Alphabet)))
            {
                ColumnDefinition gridColumn = new ColumnDefinition();
                gridColumn.Width = GridLength.Auto;
                dynamicGrid.ColumnDefinitions.Add(gridColumn);
                Button button = new Button();
                button.Content = letter;
                button.Click += AlphabetButton_Click;
                button.Width = 40;
                button.Height = 40;
                button.Margin = new Thickness(1, 1, 1, 1);

                // populate the first row
                if (count < 13)
                {
                    Grid.SetRow(button, 0);
                    Grid.SetColumn(button, count);
                }
                // halfway through the alphabet switch to second row
                else
                {
                    Grid.SetRow(button, 1);
                    Grid.SetColumn(button, count - 13);
                }
                count++;
                // add the button to the grid
                dynamicGrid.Children.Add(button);
            }
        }

        #endregion

        #region private helper methods

        /// <summary>
        /// Check if the character is a special character so we can reveal it right away
        /// </summary>
        /// <param name="charToCheck"></param>
        private bool IsSpecialChar(char charToCheck)
        {
            return charToCheck == '-' || charToCheck == '\'';
        }

        /// <summary>
        /// Onclicklistener for our buttons
        /// </summary>
        /// <param name="sender">the button that was pressed</param>
        /// <param name="e"></param>
        private void AlphabetButton_Click(object sender, RoutedEventArgs e)
        {
            // Since we know the AlphabetButton_Click is called only by buttons, it is safe to cast it as one
            Button button = (Button)sender;
            // Send the pressed character content to the hangman game object
            hangmanGame.CharacterGuessed(button.Content.ToString());
        }
        
        #endregion

    }
}
