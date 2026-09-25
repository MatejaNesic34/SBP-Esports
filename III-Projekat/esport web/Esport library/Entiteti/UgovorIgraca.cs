using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class UgovorIgraca
    {
        public virtual int UgovorId { get; set; }
        public virtual Igrac Igrac { get; set; }
        public virtual Tim Tim { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime? DatumDo { get; set; }
        public virtual string TipUgovora { get; set; }
        public virtual decimal Plata { get; set; }
        public virtual decimal Bonusi { get; set; }
        public virtual decimal? KlauzulaOtkup { get; set; }
        public virtual string ZabranaNastupa { get; set; }
        public virtual string StatusIgraca { get; set; }
    }
}
