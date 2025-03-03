using Eindwerk_Domain.Business.Norm.Tables;
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
using Eindwerk_Domain.Business;
using Eindwerk_Domain.Business.Norm;

namespace Eindwerk_WPF
{
    /// <summary>
    /// Interaction logic for ProductPagina.xaml
    /// </summary>
    public partial class ProductPagina : Page
    {
        private Controller _persistController;
        public ProductPagina()
        {
            InitializeComponent();
            _persistController = new Controller();
        }



        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added to cart");
        }
        private void AddToCart_Click2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This Item is not available yet");
        }
        private void AddToCart_Click3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This Item is not available yet");
        }


    }


}

