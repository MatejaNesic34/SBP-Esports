using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class AngazmanZaposlenih
    {
        public virtual int AngazmanOsobljaId { get; set; }
        public virtual Osoba Osoba { get; set; }
        public virtual Tim Tim { get; set; }
        public virtual string NazivUloge { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime? DatumDo { get; set; }
        public virtual decimal? Plata { get; set; }
    }
}
