using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class FizioterapeutMap : ClassMap<Fizioterapeut>
    {
        public FizioterapeutMap()
        {
            Table("FIZIOTERAPEUT");
            Map(x => x.OsobaId).Column("OSOBAID");
            Map(x => x.OblastRada).Column("OBLAST_RADA");
            Map(x => x.PeriodiDostupnosti).Column("PERIODI_DOSTUPNOSTI");
        }
    }
}
