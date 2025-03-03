using Eindwerk_Domain.Business.Norm.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Business.Repo
{
    public static class ProductenRepository
    {
        private static List<Producten> _productenLijst;
        public static List<Producten> ProductenLijst
        {
            get { return _productenLijst; }
            set { _productenLijst = value; }
        }
    }
}
