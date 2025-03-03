using Eindwerk_Domain.Business.Norm.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Business.Repo
{
    public static class OrderInformatieRepository
    {
        private static List<OrderInformatie> _orderInformatieLijst;
        public static List<OrderInformatie> OrderInformatieLijst
        {
            get { return _orderInformatieLijst; }
            set { _orderInformatieLijst = value; }
        }
    }
}
