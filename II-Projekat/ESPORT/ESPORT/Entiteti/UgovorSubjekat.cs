using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class UgovorSubjekat
    {
        public virtual SponzorskiUgovor Ugovor { get; set; }
        public virtual Tim Tim { get; set; }
        public virtual Igrac Igrac { get; set; }
        public virtual Takmicenje Takmicenje { get; set; }
    }
}
