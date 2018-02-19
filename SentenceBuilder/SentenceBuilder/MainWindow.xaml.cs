/* Augusto Serrao
   Deepti Aggarwal
   Hartaj Dhillon
   Gagandeep Singh
   Shoaib Hassan
*/

using System.Windows;
using System.Windows.Controls;

namespace SentenceBuilder
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

        // Click event method for buttons which contain only words
        private void Button_Word_Click(object sender, RoutedEventArgs e)
        {
            // Get string from content of the button clicked
            Button btnClicked = (Button)sender;

            tbxSentence.Text += " " + btnClicked.Content.ToString();
        }

        // Click event method for buttons which contain puctuation
        private void Button_Punctuation_Click(object sender, RoutedEventArgs e)
        {
            Button btnClicked = sender as Button;

            tbxSentence.Text += (string)btnClicked.Content;
        }

        // Click event method for clear button
        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            tbxSentence.Text = "";
        }        
    }
}
