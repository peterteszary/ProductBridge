using ProductBridge.MVVM.View;
using System.Windows;
using System.Windows.Controls;

namespace ProductBridge.View
{
    public partial class WelcomePage : Page
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to AddProductView
            NavigationService?.Navigate(new AddProductView());
        }

        private void SearchProduct_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to SearchProductView
            NavigationService?.Navigate(new SearchProductView());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            // Exit the application
            Application.Current.Shutdown();
        }
    }
}