using Eindwerk_Domain.Business.Norm.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Business.Repo
{
    static internal class CategorieënRepository
    {
        private static List<Categorieën> _categorieënLijst;
        public static List<Categorieën> CategorieënLijst
        {
            get { return _categorieënLijst; }
            set { _categorieënLijst = value; }
        }

    }
}
