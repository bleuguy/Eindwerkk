using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Eindwerk_Domain;
using static Eindwerk_Domain.Business.Norm.Controller;

namespace Eindwerk_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

        public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();
                MainFrame.Navigate(new HomePagina());
            }

            private void NavigateToHome(object sender, RoutedEventArgs e)
            {
                MainFrame.Navigate(new HomePagina());
            }

            private void NavigateToProducten(object sender, RoutedEventArgs e)
            {
                MainFrame.Navigate(new ProductPagina());
            }

            private void NavigateToAccount(object sender, RoutedEventArgs e)
            {
            if (LoginChecker.Succes == true)
            {
                MainFrame.Navigate(new GebruikerPagina());
            }
            else if (LoginChecker.Succes == false)
            {
                MainFrame.Navigate(new AccountPagina());
            }
            }
        

            private void NavigateToCart(object sender, RoutedEventArgs e)
            {
                MainFrame.Navigate(new ShoppingCartPagina());
            }
        }
    }
