using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Business.Norm.Tables
{
    public class OrderInformatie
    {
        private int _aantal;
        private int _fkorder;
        private int _fkproduct;

        public int Aantal
        {
            get { return _aantal; }
            set { _aantal = value; }
        }
        public int Fkorder
        {
            get { return _fkorder; }
        }
        public int Fkproduct
        {
            get { return _fkproduct; }
        }
        public OrderInformatie(int aantal, int fkorder, int fkproduct)
        {
            _aantal = aantal;
            _fkorder = fkorder;
            _fkproduct = fkproduct;
        }
        public override string ToString()
        {
            return _aantal + ": " + _fkorder + " - " + _fkproduct;
        }

    }
}
