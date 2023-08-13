using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PasswordChecker
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void OnCheckPassword(object sender, RoutedEventArgs e)
        {
            string password = PasswordTextBox.Password; // Use Password property

            if (password.Length < 8)
            {
                ResultTextBlock.Text = "Password must be at least 8 characters long.";
                return;
            }

            // Additional checks based on the rules...

            ResultTextBlock.Text = "Password is valid.";
        }

        private void ResultTextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
