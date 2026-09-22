using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class Igra
    {
        public virtual int IgraId { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Zanr { get; set; }

        // One-to-Many
        public virtual IList<Tim> Timovi { get; set; } = new List<Tim>();
        public virtual IList<Takmicenje> Takmicenja { get; set; } = new List<Takmicenje>();
        public virtual IList<Skaut> Skauti { get; set; } = new List<Skaut>();
    }
}
