using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class Analiticar : Osoba
    {
        public virtual string OblastAnalize { get; set; }
        public virtual string Alati { get; set; }
        public virtual string NivoIskustva { get; set; }
    }
}
