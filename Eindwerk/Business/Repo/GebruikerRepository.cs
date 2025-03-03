using Eindwerk_Domain.Business.Norm.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Business.Repo
{
    public static class GebruikerRepository
    {
        private static List<Gebruiker> _gebruikerLijst;
        public static List<Gebruiker> GebruikerLijst
        {
            get { return _gebruikerLijst; }
            set { _gebruikerLijst = value; }
        }
    }
}
