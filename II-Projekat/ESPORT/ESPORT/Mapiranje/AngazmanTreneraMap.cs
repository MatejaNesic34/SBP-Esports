using ESPORT.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class AngazmanTreneraMap : ClassMap<AngazmanTrenera>
    {
        public AngazmanTreneraMap()
        {
            Table("ANGAZMAN_TRENERA");
            Id(x => x.AngazmanTreneraId).Column("ANGAZMAN_TRENERA_ID").GeneratedBy.Sequence("ANGAZMAN_TRENERA_SEQ");
            Map(x => x.Trener).Column("TRENER_ID");
            Map(x => x.Tim).Column("TIM_ID");
            Map(x => x.TipUloge).Column("TIP_ULOGE");
            Map(x => x.DatumOd).Column("DATUM_OD");
            Map(x => x.DatumDo).Column("DATUM_DO");
        }
    }
}
