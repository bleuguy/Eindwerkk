using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Business.Norm.Tables
{
    public class Order
    {
        private int _orderID;
        private DateTime _datumBetaald;
        private DateTime _datumOrder;
        private int _fkgebruiker;

        public int OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }
        public DateTime DatumBetaald
        {
            get { return _datumBetaald; }
            set { _datumBetaald = value; }
        }
        public DateTime DatumOrder
        {
            get { return _datumOrder; }
            set { _datumOrder = value; }
        }
        public int Fkgebruiker
        {
            get { return _fkgebruiker; }
        }

        public Order(int orderID, DateTime datumbetaald, DateTime datumOrder, int fkgebruiker)
        {
            _orderID = orderID;
            _datumBetaald= datumbetaald;
            _datumOrder = datumOrder;
            _fkgebruiker= fkgebruiker;
        }
        public Order(DateTime datumbetaald, DateTime datumOrder, int fkgebruiker)
        {
            _orderID = 0;
            _datumBetaald = datumbetaald;
            _datumOrder = datumOrder;
            _fkgebruiker = fkgebruiker;
        }
        public override string ToString()
        {
            return _orderID + " - " + _datumBetaald.ToShortDateString() + " - " + _datumOrder.ToShortDateString() + " - " + _fkgebruiker;
        }

    }
}
