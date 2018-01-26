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
        #region properties

        /// <summary>
        /// Current game of hangman
        /// </summary>
        private HangmanGame hangmanGame { get; set; }

        /// <summary>
        /// List of all the labels containing a character of the word to be guessed
        /// </summary>
        private List<Label> labelList { get; set; }

        /// <summary>
        /// List of all the buttons containing an alphabet letter
        /// </summary>
        private List<Button> buttonList { get; set; }

        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            StartNewGame();
        }

        #region GUI populating methods

        /// <summary>
        /// Starts a new game of hangman and refreshes the UI
        /// </summary>
        private void StartNewGame()
        {
            // Create a new list to store the labels for revealing purposes/any other later use purposes
            labelList = new List<Label>();
            // Create a new list to store the buttons containing letters of the alphabet for later use
            buttonList = new List<Button>();
            // Start a new game of hangman
            hangmanGame = new HangmanGame();
            // Create the guessing GUI (labels for each letter in the word)
            CreateWordGuessLabels(hangmanGame.WordToGuess);
            // Create the Alphabet GUI (buttons for each letter in the alphabet)
            CreateAphabetButtons();
        }

        /// <summary>
        /// Populate the MainGrid with Labels according to the word length
        /// </summary>
        /// <param name="wordToGuess"></param>
        private void CreateWordGuessLabels(string wordToGuess)
        {
            // Create a grid to store each word letter
            Grid dynamicGrid = WordGrid;

            // Clear the grid
            dynamicGrid.Children.Clear();
            dynamicGrid.RowDefinitions.Clear();
            dynamicGrid.ColumnDefinitions.Clear();

            // Grid styling
            dynamicGrid.Width = WindowMain.Width - 25;
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

                // Name each label to identify and reveal later
                label.Name = "GuessChar" + i.ToString();

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
                // Add the label to the list of labels so we can access it later
                labelList.Add(label);
            }
        }

        /// <summary>
        /// Create buttons for each letter of the alphabet to guess the word
        /// </summary>
        private void CreateAphabetButtons()
        {
            // Create a new grid to store the alphabet buttons
            Grid dynamicGrid = AlphabetGrid;

            // Clear the grid
            dynamicGrid.Children.Clear();
            dynamicGrid.RowDefinitions.Clear();
            dynamicGrid.ColumnDefinitions.Clear();

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

                // Button style
                Button button = new Button();
                button.Content = letter;
                button.Click += AlphabetButton_Click;
                button.Width = 40;
                button.Height = 40;
                button.Margin = new Thickness(1, 1, 1, 1);
                button.Opacity = 0.8;
                button.BorderBrush = Brushes.White;
                button.FontSize = 20;

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
                // add the button to the list of buttons for later use
                buttonList.Add(button);
            }
        }

        /// <summary>
        /// Reveal a specific character of the word the user is trying to guess
        /// </summary>
        /// <param name="characterLocationList">indexes of the letters in the word</param>
        /// <param name="buttonContent">character to reveal</param>
        public void RevealCharacters(List<int> characterLocationList, Button button)
        {
            char c = button.Content.ToString()[0];
            // Check if the list contains anything
            if (characterLocationList != null && characterLocationList.Count > 0)
            {
                // Set the background color of button to green (correct guess)
                button.Background = Brushes.Green;
                // Go through the list
                foreach (int i in characterLocationList)
                {
                    // and 'reveal' the characters
                    labelList[i].Content = c;
                }

                // Check if the word has been guessed
                int charsUnguessed = 0;
                foreach (Label label in labelList)
                {
                    if (label.Content.ToString()[0] == '_')
                    {
                        charsUnguessed++;
                    }
                }
                // If it has been guessed
                if (charsUnguessed == 0)
                {
                    // Show the results
                    ShowResults();
                }
            }
            // Guessed wrong (set background of the button to Red)
            else
            {
                button.Background = Brushes.Red;
                hangmanGame.AddToMistakeCunter();
                // If the user has guessed wrong 10 times
                if (hangmanGame.GameOver)
                {
                    ShowResults();
                }
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
            return charToCheck == '-' || charToCheck == '\'' || charToCheck == ' ';
        }

        /// <summary>
        /// Show the results to the users when the game is finished
        /// </summary>
        private void ShowResults()
        {
            // if the user lost the game
            if (hangmanGame.GameOver)
            {
                // Show a message box with the results and clear the alphabet button grid so they cannot continue playing
                MessageBox.Show($"Game over\nWord: {hangmanGame.WordToGuess} \nGuesses:  {hangmanGame.NumberOfGuesses} \nMistakes: {hangmanGame.MistakeCounter}");
                AlphabetGrid.Children.Clear();
            }
            // if the user won the game
            else
            {
                // Show a message box with the results and clear the alphabet button grid so they cannot continue playing
                MessageBox.Show($"YOU WIN\nWord: {hangmanGame.WordToGuess} \nGuesses:  {hangmanGame.NumberOfGuesses} \nMistakes: {hangmanGame.MistakeCounter}");
                AlphabetGrid.Children.Clear();
            }

        }

        #endregion

        #region Button ClickListeners

        /// <summary>
        /// New Game button clicklistener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            StartNewGame();
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

            // If the button has already been pressed
            if (button.Background == Brushes.Green || button.Background == Brushes.Red) { return; }

            // Send the pressed character content to the hangman game object
            hangmanGame.CharacterGuessed(button.Content.ToString());
            // Reveal the characters if they exist in the word
            RevealCharacters(hangmanGame.charLocations, button);
        }

        #endregion

    }
}
