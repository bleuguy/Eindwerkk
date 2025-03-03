using Eindwerk_Domain.Business.Norm;
using Google.Protobuf.WellKnownTypes;
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
using MySql.Data.MySqlClient;
using Eindwerk_Domain.Business;
using Eindwerk_Domain.Business.Norm.Tables;

namespace Eindwerk_WPF
{
    /// <summary>
    /// Interaction logic for AccountPagina.xaml
    /// </summary>
    public partial class AccountPagina : Page
    {
        private string username, password;
        private Controller _controller;
        private string connectionString = "server=localhost; user id=root; password=1234; database=eindwerk";
        public bool loginSucces = false;

        public AccountPagina()
        {
            _controller = new Controller();
            InitializeComponent();
            EmptyTextBoxes();            
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string email = txtUsernameBox.Text.Trim();
            string wachtwoord = txtPasswordBox.Password.Trim();
            _controller = new Controller();


            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(wachtwoord))
            {
                MessageBox.Show("Vul zowel e-mail als wachtwoord in.");
                return;
            }

            _controller.ControleerGebruiker(email, wachtwoord);
            if (Controller.ControleerGebruiker(email, wachtwoord))
            {
                MessageBox.Show("Successvol ingelogd!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                Controller.LoginChecker.Succes = true;
                this.NavigationService.Navigate(new HomePagina());
            }
            else
            {
                MessageBox.Show("Ongeldig e-mailadres of wachtwoord.");
            }
        }
        

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegistreerPagina());
        }
        private void EmptyTextBoxes()
        {
            txtPasswordBox.Clear();
            txtUsernameBox.Clear();
        }
    }
}
