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

namespace Eindwerk_WPF
{
    /// <summary>
    /// Interaction logic for GebruikerPagina.xaml
    /// </summary>
    public partial class GebruikerPagina : Page
    {
        public GebruikerPagina()
        {
            InitializeComponent();
            AccountPagina accountPagina = new AccountPagina();
            bool succes = accountPagina.loginSucces;
        }
    }
}
