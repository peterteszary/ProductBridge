using ProductBridge.View;
using System.Windows;
using System.Windows.Controls;


namespace ProductBridge.MVVM.View
{
    /// <summary>
    /// Interaction logic for LoginPageView.xaml
    /// </summary>
    public partial class LoginPageView : Page
    {
        public LoginPageView()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            // Navigálás a WelcomePage-re
            NavigationService?.Navigate(new WelcomePage());
        }

    }
}
