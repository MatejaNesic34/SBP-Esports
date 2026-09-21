using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class SponzorskiUgovor
    {
        public virtual int UgovorId { get; set; }
        public virtual Sponzor Sponzor { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }
        public virtual decimal Iznos { get; set; }
        public virtual string Valuta { get; set; }
        public virtual string TipPodrske { get; set; }
        public virtual string MarketinskeObaveze { get; set; }

        public virtual UgovorSubjekat Subjekat { get; set; }
    }
}
