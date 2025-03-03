using Eindwerk_Domain.Business.Norm.Tables;
using Eindwerk_Domain.Persistence.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Persistence
{
    internal class PersistenceController
    {
        private string _connectionString;
        public PersistenceController()
        {
            _connectionString = "server = localhost; user id = root; password=1234;database=eindwerk";
        }
        public PersistenceController(string connstring)
        {
            _connectionString = connstring;
        }


        public List<Categorieën> GetCategorieën()
        {
            CategroriënMapper mapper = new CategroriënMapper();
            return mapper.GetCategorieënFromDB();
        }
        public List<Gebruiker> GetGebruiker()
        {
            GebruikerMapper mapper = new GebruikerMapper();
            return mapper.GetGebruikerFromDB();
        }
        public List<OrderInformatie> GetOrderInformatie()
        {
            OrderInformatieMapper mapper = new OrderInformatieMapper();
            return mapper.GetOrderInformatieFromDB();
        }
        public List<Order> GetOrder()
        {
            OrderMapper mapper = new OrderMapper();
            return mapper.GetOrderFromDB();
        }
        public List<Producten> GetProducten()
        {
            ProductenMapper mapper = new ProductenMapper();
            return mapper.GetProductenFromDB();
        }
        public List<Verzending> GetVerzending()
        {
            VerzendingMapper mapper = new VerzendingMapper();
            return mapper.GetVerzendingFromDB();
        }
        public List<VerzendMethode> GetVerzendMethode()
        {
            VerzendMethodeMapper mapper = new VerzendMethodeMapper();
            return mapper.GetVerzendMethodeFromDB();
        }
        public void ControleerGebruiker(string email, string wachtwoord)
        {
            GebruikerMapper mapper = new GebruikerMapper();
            mapper.ControleerGebruiker(email, wachtwoord);
        }
    }
}
