using Eindwerk_Domain.Business.Norm.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Business.Repo
{
    public static class OrderRepository
    {
        private static List<Order> _orderLijst;
        public static List<Order> OrderLijst
        {
            get { return _orderLijst; }
            set { _orderLijst = value; }
        }
    }
}
