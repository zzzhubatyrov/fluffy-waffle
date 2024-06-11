using System.Windows;
using System.Windows.Controls;
using TESTAPP.ViewModel;

namespace TESTAPP.View
{
    /// <summary>
    /// Interaction logic for RegistryView.xaml
    /// </summary>
    public partial class RegistryView : Page
    {
        public RegistryView()
        {
            InitializeComponent();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is RegistryViewModel viewModel)
            {
                viewModel.Password = ((PasswordBox)sender).Password;
            }
        }

        private void ConfirmPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is RegistryViewModel viewModel)
            {
                viewModel.ConfirmPassword = ((PasswordBox)sender).Password;
            }
        }
    }
}
