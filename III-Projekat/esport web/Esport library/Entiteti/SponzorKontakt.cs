using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class SponzorKontakt
    {
        public virtual int KontaktId { get; set; }
        public virtual Sponzor Sponzor { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string Email { get; set; }
    }
}
