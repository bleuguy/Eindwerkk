using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Business.Norm.Tables
{
    public class Producten
    {
        private int _productID;
        private int _prijs;
        private string _omschrijving;
        private string _naamProduct;
        private int _fkCategorie;
        private string _image;

        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }
        public int Prijs
        {
            get { return _prijs; }
            set { _prijs = value; }
        }
        public string Omschrijving
        {
            get { return _omschrijving; }
            set { _omschrijving = value; }
        }
        public string NaamProduct
        {
            get { return _naamProduct; }
            set { _naamProduct = value; }
        }
        public int FkCategorie
        {
            get { return _fkCategorie; }
        }
        public string Image
        {
            get { return _image; }
        }

        public Producten(int productID, int prijs, string omschrijving, string naamProduct, int fkCategorie, string image)
        {
            _productID = productID;
            _prijs = prijs;
            _omschrijving= omschrijving;
            _naamProduct = naamProduct;
            _fkCategorie= fkCategorie;
            _image= image;
        }
        public Producten(int prijs, string omschrijving, string naamProduct, int fkCategorie, string image)
        {
            _productID = 0;
            _prijs = prijs;
            _omschrijving = omschrijving;
            _naamProduct = naamProduct;
            _fkCategorie = fkCategorie;
            _image= image;
        }
        public override string ToString()
        {
            return _productID + " - " + _prijs + " - " + _omschrijving + " - " + _naamProduct + " - " + _fkCategorie + " - " + _image;
        }

    }
}
