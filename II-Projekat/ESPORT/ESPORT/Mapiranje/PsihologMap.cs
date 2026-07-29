using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class PsihologMap : ClassMap<Psiholog>
    {
        public PsihologMap()
        {
            Table("PSIHOLOG");
            Map(x => x.OsobaId).Column("OSOBAID");
            Map(x => x.OblastRada).Column("OBLAST_RADA");
            Map(x => x.PeriodiDostupnosti).Column("PERIODI_DOSTUPNOSTI");
        }
    }
}
