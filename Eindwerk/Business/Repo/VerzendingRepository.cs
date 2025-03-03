using Eindwerk_Domain.Business.Norm.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Business.Repo
{
    public static class VerzendingRepository
    {
        private static List<Verzending> _verzendingLijst;
        public static List<Verzending> VerzendingLijst
        {
            get { return _verzendingLijst; }
            set { _verzendingLijst = value; }
        }
    }
}
