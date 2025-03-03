using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Business.Norm.Tables
{
    public class Categorieën
    {
        public int _categorieID;
        public string _categorieNaam;
        public string _omschrijving;

        public int CategorieID
        {
            get { return _categorieID; }
            set { _categorieID = value; }
        }
        public string CategorieNaam
        {
            get { return _categorieNaam; }
            set { _categorieNaam = value; }
        }
        public string Omschrijving
        {
            get { return _omschrijving; }
            set { _omschrijving = value; }
        }

        public Categorieën(int categorieID,  string categorieNaam, string omschrijving)
        {
            _categorieID = categorieID;
            _categorieNaam = categorieNaam;
            _omschrijving = omschrijving;
        }
        public Categorieën(string categorieNaam, string omschrijving)
        {
            _categorieID = 0;
            _categorieNaam = categorieNaam;
            _omschrijving = omschrijving;
        }

        public override string ToString()
        {
           return _categorieID + " - " + _categorieNaam + " - " + _omschrijving;
        }

    }
}
