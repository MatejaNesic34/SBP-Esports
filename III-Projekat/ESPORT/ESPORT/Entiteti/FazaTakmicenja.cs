using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class FazaTakmicenja
    {
        public virtual int FazaId { get; set; }
        public virtual Turnir Turnir { get; set; }
        public virtual string NazivFaze { get; set; }
        public virtual int RedniBroj { get; set; }
        public virtual FazaTakmicenja Nadfaza { get; set; }

        // One-to-Many
        public virtual IList<FazaTakmicenja> Podfaze { get; set; } = new List<FazaTakmicenja>();
        public virtual IList<UcesceTimaUFazi> TimoviUcesnici { get; set; } = new List<UcesceTimaUFazi>();
    }
}
