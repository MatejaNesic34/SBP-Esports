using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class AnaliticarMap : ClassMap<Analiticar>
    {
        public AnaliticarMap()
        {
            Table("ANALITICAR");
            Map(x => x.OsobaId).Column("OSOBAID");
            Map(x => x.OblastAnalize).Column("OBLAST_ANALIZE");
            Map(x => x.Alati).Column("ALATI");
            Map(x => x.NivoIskustva).Column("NIVO_ISKUSTVA");
        }
    }
}
