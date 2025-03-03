using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Business.Norm.Tables
{
    public class Verzending
    {
        private int _shippingID;
        private string _naam;
        private string _voornaam;
        private string _land;
        private string _straat;
        private int _huisnummer;
        private string _bus;
        private int _postcode;
        private int _fkOrder;
        private int _fkVerzendmethode;

        public int ShippingID
        {
            get { return _shippingID; }
            set { _shippingID = value; }
        }
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }
        public string Land
        {
            get { return _land; }
            set { _land = value; }
        }
        public string Straat
        {
            get { return _straat; }
            set { _straat = value; }
        }
        public int Huisnummer
        {
            get { return _huisnummer; }
            set { _huisnummer = value; }
        }
        public string Bus
        {
            get { return _bus; }
            set { _bus = value; }
        }
        public int Postcode
        {
            get { return _postcode; }
            set { _postcode = value; }
        }
        public int FkOrder
        {
            get { return _fkOrder; }
        }
        public int FkVerzendmethode
        {
            get { return _fkVerzendmethode; }
        }
        public Verzending(int shippingID, string naam, string voornaam, string land, string straat, int huisnummer, string bus, int postcode, int fkOrder, int fkVerzenmethode)
        {
            _shippingID = shippingID;
            _naam = naam;
            _voornaam = voornaam;
            _land = land;
            _straat = straat;
            _huisnummer = huisnummer;
            _bus = bus;
            _postcode = postcode;
            _fkOrder = fkOrder;
            _fkVerzendmethode = fkVerzenmethode;
        }
        public Verzending(string naam, string voornaam, string land, string straat, int huisnummer, string bus, int postcode, int fkOrder, int fkVerzenmethode)
        {
            _shippingID = 0;
            _naam = naam;
            _voornaam = voornaam;
            _land = land;
            _straat = straat;
            _huisnummer = huisnummer;
            _bus = bus;
            _postcode = postcode;
            _fkOrder = fkOrder;
            _fkVerzendmethode = fkVerzenmethode;
        }
        public override string ToString()
        {
            return _shippingID + " - " + _naam + " - " + _voornaam + " - " + _land + " - " + _straat + " - " + _huisnummer + " - " +_bus + " - " + _postcode + " - " + _fkOrder + " - " + _fkVerzendmethode;
        }


    }
}
