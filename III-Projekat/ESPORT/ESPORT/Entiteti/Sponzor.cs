using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class Sponzor
    {
        public virtual int SponzorId { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Drzava { get; set; }
        public virtual string TipSponzora { get; set; }
        public virtual string OblastPoslovanja { get; set; }

        // One-to-Many
        public virtual IList<SponzorKontakt> Kontakti { get; set; } = new List<SponzorKontakt>();
        public virtual IList<SponzorskiUgovor> Ugovori { get; set; } = new List<SponzorskiUgovor>();
    }
}
