using Eindwerk_Domain.Business.Norm.Tables;
using Eindwerk_Domain.Business.Repo;
using Eindwerk_Domain.Persistence;
using Eindwerk_Domain.Persistence.Mapper;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Business.Norm
{
    public class Controller
    {
        PersistenceController _persistController;

        public Controller()
        {
            _persistController = new PersistenceController();
            CategorieënRepository.CategorieënLijst = _persistController.GetCategorieën();
            GebruikerRepository.GebruikerLijst = _persistController.GetGebruiker();
            OrderInformatieRepository.OrderInformatieLijst = _persistController.GetOrderInformatie();
            OrderRepository.OrderLijst = _persistController.GetOrder();
            ProductenRepository.ProductenLijst = _persistController.GetProducten();
            VerzendingRepository.VerzendingLijst = _persistController.GetVerzending();
            VerzendMethodeRepository.VerzendMethodeLijst = _persistController.GetVerzendMethode();
        }

        public List<Categorieën> GetCategorieën()
        {
            return CategorieënRepository.CategorieënLijst;
        }
        public List<Gebruiker> GetGebruikers()
        {
            return GebruikerRepository.GebruikerLijst;
        }
        public List<OrderInformatie> GetOrderInformatie()
        {
            return OrderInformatieRepository.OrderInformatieLijst;
        }
        public List<Order> GetOrder()
        {
            return OrderRepository.OrderLijst;
        }
        public List<Producten> GetProducten()
        {
            return ProductenRepository.ProductenLijst;
        }
        public List<Verzending> GetVerzending()
        {
            return VerzendingRepository.VerzendingLijst;
        }
        public List<VerzendMethode> GetVerzendMethode()
        {
            return VerzendMethodeRepository.VerzendMethodeLijst;
        }
        public void AddGebruiker(Gebruiker gebruiker)
        {
            _persistController.AddGebruiker(gebruiker);
        }

        public static class LoginChecker
        {
            static LoginChecker()
            {
                Succes = false; 
            }
            public static bool Succes { get; set; }
        }

        public bool ControleerGebruiker(string email, string wachtwoord)
        {
            return _persistController.ControleerGebruiker(email, wachtwoord);
            //GebruikerRepository.GebruikerLijst = _persistController.GetGebruiker();
        }

    }
}
