using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class AngazmanTrenera
    {
        public virtual int AngazmanTreneraId { get; set; }
        public virtual Trener Trener { get; set; }
        public virtual Tim Tim { get; set; }
        public virtual string TipUloge { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime? DatumDo { get; set; }
    }
}
