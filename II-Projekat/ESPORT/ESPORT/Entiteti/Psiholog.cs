using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class Psiholog : Osoba
    {
        public virtual string OblastRada { get; set; }
        public virtual string PeriodiDostupnosti { get; set; }
    }
}
