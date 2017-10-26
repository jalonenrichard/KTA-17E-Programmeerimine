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

namespace TicTacToeProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Private Members
        /// <summary>
        /// Holds the current state of cells in the active game
        /// </summary>
        private MarkType[] _results;

        /// <summary>
        /// True if it is player 1 (X) turn, false if player 2 (O) turn
        /// </summary>
        private bool _player1Turn;

        /// <summary>
        /// True if game has ended
        /// </summary>
        private bool _gameEnded;
        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
            //When the window is loaded, start a new game
            NewGame();
        }
        #endregion

        /// <summary>
        /// Handles a button click event
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">Events of the click</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Start a new game when a button is clicked and the game has ended
            if (_gameEnded)
            {
                NewGame();
                return;
            }

            // Cast the sender object as a Button, because we know it will always be a button since we set the Click eventlisteners only to buttons in the xaml file
            var button = (Button)sender;

            // Get the column the sender button is on
            var column = Grid.GetColumn(button);
            // Get the row the sender button is on
            var row = Grid.GetRow(button);

            // An unique index for each cell/button, Row 0 Column 0 would be 0, Row 0 Column 1 would be 1 + 0 = 1, etc etc
            var index = column + (row * 3);

            // If the Button already has a value, do nothing
            if (_results[index] != MarkType.Free)
            {
                return;
            }

            // Set the cell value based on whose turn it is (Same as if else statement, but using Linq instead)
            // If it's player1 turn, Set the cell marktype to X, else set it to O
            _results[index] = _player1Turn ? MarkType.Cross : MarkType.Nought;

            // Set the cell content to X or O
            button.Content = _player1Turn ? "X" : "O";

            // If it's player 2 turn, change the text color
            if (!_player1Turn)
            {
                button.Foreground = Brushes.Red;
            }

            // Change the player turn (toggle a boolean)
            _player1Turn ^= true;

            // Check if there is a winner
            CheckForWinner();

        }

        #region Private Helpers
        /// <summary>
        /// Starts a new game and sets all default values
        /// </summary>
        private void NewGame()
        {
            // Create a new blank array of empty cells
            _results = new MarkType[9];
            // Go through each cell
            for (var i = 0; i < _results.Length; i++)
            {
                // Set all the cells to be free/empty
                _results[i] = MarkType.Free;
            }

            // Player 1 starts the game
            _player1Turn = true;

            // Iterate every button on the grid
            Container.Children.Cast<Button>().ToList().ForEach(button =>
            {
                // Set the default values for the buttons to start a new game
                // Set each buttons content to be empty
                button.Content = string.Empty;
                // Set the starting background for each button to white
                button.Background = Brushes.White;
                // Set the starting button text color to blue
                button.Foreground = Brushes.Blue;
            });

            // The game hasn't finished (new game)
            _gameEnded = false;
        }

        /// <summary>
        /// Check if there's a winner by getting 3 straight values
        /// </summary>
        private void CheckForWinner()
        {
            #region Horizontal win conditions
            // Check horizontal win conditions
            //
            // Row 1
            //
            if (_results[0] != MarkType.Free && (_results[0] & _results[1] & _results[2]) == _results[0])
            {
                //Game ends
                _gameEnded = true;

                //Highlight winning cells
                Button0_0.Background = Button1_0.Background = Button2_0.Background = Brushes.Green;
            }
            //
            // Row 2
            //
            else if (_results[3] != MarkType.Free && (_results[3] & _results[4] & _results[5]) == _results[3])
            {
                //Game ends
                _gameEnded = true;

                //Highlight winning cells
                Button0_1.Background = Button1_1.Background = Button2_1.Background = Brushes.Green;
            }
            //
            // Row 3
            //
            else if (_results[6] != MarkType.Free && (_results[6] & _results[7] & _results[8]) == _results[6])
            {
                //Game ends
                _gameEnded = true;

                //Highlight winning cells
                Button0_2.Background = Button1_2.Background = Button2_2.Background = Brushes.Green;
            }
            #endregion
            #region Vertical win conditions
            // Check vertical win conditions
            //
            // Column 1
            //
            else if (_results[0] != MarkType.Free && (_results[0] & _results[3] & _results[6]) == _results[0])
            {
                //Game ends
                _gameEnded = true;

                //Highlight winning cells
                Button0_0.Background = Button0_1.Background = Button0_2.Background = Brushes.Green;
            }
            //
            // Column 2
            //
            else if (_results[1] != MarkType.Free && (_results[1] & _results[4] & _results[7]) == _results[1])
            {
                //Game ends
                _gameEnded = true;

                //Highlight winning cells
                Button1_0.Background = Button1_1.Background = Button1_2.Background = Brushes.Green;
            }
            //
            // Column 3
            //
            else if (_results[2] != MarkType.Free && (_results[2] & _results[5] & _results[8]) == _results[2])
            {
                //Game ends
                _gameEnded = true;

                //Highlight winning cells
                Button2_0.Background = Button2_1.Background = Button2_2.Background = Brushes.Green;
            }
            #endregion
            #region Diagonal win conditions
            // Check diagonal win conditions
            //
            // Diagonal 1
            //
            else if (_results[0] != MarkType.Free && (_results[0] & _results[4] & _results[8]) == _results[0])
            {
                //Game ends
                _gameEnded = true;

                //Highlight winning cells
                Button0_0.Background = Button1_1.Background = Button2_2.Background = Brushes.Green;
            }
            //
            // Diagonal 2
            //
            else if (_results[2] != MarkType.Free && (_results[2] & _results[4] & _results[6]) == _results[2])
            {
                //Game ends
                _gameEnded = true;

                //Highlight winning cells
                Button2_0.Background = Button1_1.Background = Button0_2.Background = Brushes.Green;
            }
            #endregion
            // When there is no winner
            else if (!_results.Any(result => result == MarkType.Free))
            {
                //Game ends
                _gameEnded = true;

                //Turn all cells oranage (everyone lost) OMEGALUL
                // Iterate every button on the grid
                Container.Children.Cast<Button>().ToList().ForEach(button =>
                {
                    // Set the starting background for each button to orange
                    button.Background = Brushes.Orange;
                });
            }
        }
    }
    #endregion
}
