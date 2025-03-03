using Eindwerk_Domain.Business.Norm.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Business.Repo
{
    public static class VerzendMethodeRepository
    {
        private static List<VerzendMethode> _verzendMethodeLijst;
        public static List<VerzendMethode> VerzendMethodeLijst
        {
            get { return _verzendMethodeLijst; }
            set { _verzendMethodeLijst = value; }
        }
    }
}
