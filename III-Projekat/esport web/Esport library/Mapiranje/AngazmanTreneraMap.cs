using ESPORT.Entiteti;
using FluentNHibernate.Mapping;
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

            Id(x => x.AngazmanTreneraId).Column("ANGAZMAN_TRENERA_ID").GeneratedBy.Increment();

            Map(x => x.TipUloge).Column("TIP_ULOGE").Not.Nullable();
            Map(x => x.DatumOd).Column("DATUM_OD").Not.Nullable();
            Map(x => x.DatumDo).Column("DATUM_DO").Nullable();

           
            References(x => x.Trener)
                .Column("TRENER_ID")
                .Not.Nullable()
                .LazyLoad();

            References(x => x.Tim)
                .Column("TIM_ID")
                .Not.Nullable()
                .LazyLoad();
        }
    }
}
