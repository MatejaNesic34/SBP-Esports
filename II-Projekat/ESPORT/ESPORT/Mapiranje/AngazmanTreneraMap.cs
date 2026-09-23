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

            // Primarni ključ
            Id(x => x.AngazmanTreneraId).Column("ANGAZMAN_TRENERA_ID").GeneratedBy.Increment();

            // Obična polja / atributi
            Map(x => x.TipUloge).Column("TIP_ULOGE").Not.Nullable();
            Map(x => x.DatumOd).Column("DATUM_OD").Not.Nullable();
            Map(x => x.DatumDo).Column("DATUM_DO").Nullable();

            // ----------------------------------------------------
            // RELACIJE (Many-to-One)
            // ----------------------------------------------------

            // Strani ključ ka Trener (TRENER_ID)
            References(x => x.Trener)
                .Column("TRENER_ID")
                .Not.Nullable()
                .LazyLoad();

            // Strani ključ ka Tim (TIM_ID)
            References(x => x.Tim)
                .Column("TIM_ID")
                .Not.Nullable()
                .LazyLoad();
        }
    }
}
