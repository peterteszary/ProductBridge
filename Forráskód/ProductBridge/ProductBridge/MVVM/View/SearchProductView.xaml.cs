using System.Windows;
using System.Windows.Controls;

namespace ProductBridge.MVVM.View
{
    /// <summary>
    /// Interaction logic for SearchProductView.xaml
    /// </summary>
    public partial class SearchProductView : Page
    {
        // Mockup product data
        private List<Product> products = new List<Product>
        {
            new Product { Name = "Product 1", ID = "1", SKU = "SKU1", Category = "Category A" },
            new Product { Name = "Product 2", ID = "2", SKU = "SKU2", Category = "Category B" },
            new Product { Name = "Product 3", ID = "3", SKU = "SKU3", Category = "Category A" }
        };

        public SearchProductView()
        {
            InitializeComponent();
            // Display mockup product data
            productListBox.ItemsSource = products;
        }

        // Search button click event handler
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement search logic here
            // You can filter products based on the values entered in the textboxes
            // For example:
            var filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.Name.Contains(txtProductName.Text) &&
                    product.ID.Contains(txtProductID.Text) &&
                    product.SKU.Contains(txtProductSKU.Text) &&
                    product.Category.Contains(txtProductCategory.Text))
                {
                    filteredProducts.Add(product);
                }
            }
            // Display filtered products
            productListBox.ItemsSource = filteredProducts;
        }

        // Delete button click event handler
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement delete logic here
            // You can access the selected product from the ListBox.SelectedItem property
            // For example:
            if (productListBox.SelectedItem != null)
            {
                var selectedProduct = (Product)productListBox.SelectedItem;
                products.Remove(selectedProduct);
                productListBox.ItemsSource = null;
                productListBox.ItemsSource = products;
            }
        }

        // Modify button click event handler
        private void ModifyButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement modify logic here
            // You can access the selected product from the ListBox.SelectedItem property
            // For example:
            if (productListBox.SelectedItem != null)
            {
                var selectedProduct = (Product)productListBox.SelectedItem;
                // Open a new window or navigate to a different page for modifying the selected product
                // Pass the selected product as a parameter to the window or page constructor
                // For example:
                // var modifyWindow = new ModifyProductWindow(selectedProduct);
                // modifyWindow.Show();
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string SKU { get; set; }
        public string Category { get; set; }
    }
}