using System.Windows;
using System.Windows.Controls;

namespace my_wpf_app
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Calculate button clicked!!!");
        }
        private void Number_click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string value = button.Tag.ToString(); // Get the Tag value
            InputBox.Text += value; // Append the value to the input box
        }

        private void Operator_click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string operatorValue = button.Tag.ToString(); // Get the operator value
                                                          // Handle operator logic here
        }
    }
}