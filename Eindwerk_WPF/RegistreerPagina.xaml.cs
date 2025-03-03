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
using Eindwerk_Domain.Persistence.Mapper;
using Eindwerk_Domain.Business;
using Eindwerk_Domain.Business.Norm.Tables;
using Eindwerk_Domain.Business.Norm;

namespace Eindwerk_WPF
{
    /// <summary>
    /// Interaction logic for RegistreerPagina.xaml
    /// </summary>
    public partial class RegistreerPagina : Page
    {
        private Controller _controller;
        public RegistreerPagina()
        {
            InitializeComponent();
            _controller = new Controller();
        }

        private void RegistreerButton_Click(object sender, RoutedEventArgs e)
        {
            string naam = NaamTextBox.Text;
            string voornaam = VoornaamTextBox.Text;
            string email = EmailTextBox.Text;
            string telefoonnummer = TelefoonnummerTextBox.Text;
            DateTime geboortedatum = GeboortedatumDatePicker.SelectedDate ?? DateTime.Today;
            string wachtwoord = WachtwoordPasswordBox.Password;

            // check of vakjes leeg of niet
            if (string.IsNullOrWhiteSpace(naam) || string.IsNullOrWhiteSpace(voornaam) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(telefoonnummer) ||
                string.IsNullOrWhiteSpace(wachtwoord))
            {
                ErrorMessageTextBlock.Text = "Vul alstublieft alle velden in.";
                return;
            }

            // Check als email al gebruikt
            var gebruikers = _controller.GetGebruikers();
            if (gebruikers.Exists(g => g.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
            {
                ErrorMessageTextBlock.Text = "Dit e-mailadres is al geregistreerd.";
                return;
            }


            Gebruiker nieuweGebruiker = new Gebruiker(naam, voornaam, email, int.Parse(telefoonnummer), geboortedatum, wachtwoord);
            try
            {
                _controller.AddGebruiker(nieuweGebruiker);
                this.NavigationService.Navigate(new HomePagina());
                MessageBox.Show("Registratie succesvol!", "Success", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het registreren van de gebruiker.", "Error", MessageBoxButton.OK);
            }
        }
    }
}
