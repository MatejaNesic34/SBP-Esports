using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class Pozajmica
    {
        public virtual int PozajmicaId { get; set; }
        public virtual Igrac Igrac { get; set; }
        public virtual Tim MaticniTim { get; set; }
        public virtual Tim TimNaPozajmici { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }
        public virtual string FinansijskiUslovi { get; set; }
        public virtual int PravoOtkupa { get; set; }
    }
}
