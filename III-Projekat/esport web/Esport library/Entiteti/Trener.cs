using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class Trener : Osoba
    {
        public virtual string TipUloge { get; set; }
        public virtual string StilRada { get; set; }

        // One-to-Many
        public virtual IList<AngazmanTrenera> AngazmaniTrenera { get; set; } = new List<AngazmanTrenera>();
    }
}
