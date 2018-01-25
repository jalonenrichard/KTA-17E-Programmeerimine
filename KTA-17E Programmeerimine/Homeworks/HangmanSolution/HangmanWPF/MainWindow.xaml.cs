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
        public MainWindow()
        {
            InitializeComponent();
            WordGenerator wg = new WordGenerator();
            CreateWordGuessLabels(wg.Word);
        }

        /// <summary>
        /// Populate the MainGrid with Labels according to the word length
        /// </summary>
        /// <param name="wordToGuess"></param>
        private void CreateWordGuessLabels(string wordToGuess)
        {
            // Create a grid to store each word letter
            Grid dynamicGrid = new Grid();

            // Grid styling
            dynamicGrid.Width = WindowMain.Width - 25;
            dynamicGrid.HorizontalAlignment = HorizontalAlignment.Center;
            dynamicGrid.VerticalAlignment = VerticalAlignment.Top;

            // Only 1 row for the word
            RowDefinition gridRow = new RowDefinition();
            dynamicGrid.RowDefinitions.Add(gridRow);

            // Go through each letter that the user is trying to guess and populate the grid
            for (int i = 0; i < wordToGuess.Length; i++) {
                // Create a new row for the grid with each new letter
                ColumnDefinition gridCol = new ColumnDefinition();
                dynamicGrid.ColumnDefinitions.Add(gridCol);
                Label label = new Label();

                // Label styling
                //label.Content = wordToGuess[i];
                label.Content = "_";
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

            // Populate the main window with the created grid
            WindowMain.Content = dynamicGrid;
        }

    }
}
