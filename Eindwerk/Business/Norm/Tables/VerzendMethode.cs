using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Business.Norm.Tables
{
    public class VerzendMethode
    {
        private int _idverzending;
        private string _omschrijving;
        private double _prijs;

        public int Idverzending
        {
            get { return _idverzending; }
            set { _idverzending = value; }
        }
        public string Omschrijving
        {
            get { return _omschrijving; }
            set { _omschrijving = value; }
        }
        public double Prijs
        {
            get { return _prijs; }
            set { _prijs = value; }
        }
        public VerzendMethode(int idverzending, string omschrijving, double prijs)
        {
            _idverzending= idverzending;
            _omschrijving = omschrijving;
            _prijs= prijs;
        }
        public VerzendMethode(string omschrijving, double prijs)
        {
            _idverzending = 0;
            _omschrijving = omschrijving;
            _prijs = prijs;
        }
        public override string ToString()
        {
            return _idverzending + " - " + _omschrijving + " - " + _prijs;
        }


    }
}
