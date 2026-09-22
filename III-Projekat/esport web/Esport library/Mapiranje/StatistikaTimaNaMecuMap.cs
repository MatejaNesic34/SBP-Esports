using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ESPORT.Entiteti;

namespace ESPORT.Mapiranje
{
    public class StatistikaTimaNaMecuMap : ClassMap<StatistikaTimaNaMecu>
    {
        public StatistikaTimaNaMecuMap()
        {
            Table("STATISTIKA_TIMA_NA_MECU");

            // Kompozitni primarni ključ sastavljen od dva strana ključa (MEC_ID i TIM_ID)
            CompositeId()
                .KeyReference(x => x.MecId, "MEC_ID")
                .KeyReference(x => x.TimId, "TIM_ID");

            // Obična polja / atributi
            Map(x => x.Kills).Column("KILLS").Not.Nullable();
            Map(x => x.Deaths).Column("DEATHS").Not.Nullable();
            Map(x => x.Assists).Column("ASSISTS").Not.Nullable();
            Map(x => x.Damage).Column("DAMAGE").Not.Nullable();
            Map(x => x.ObjectiveScore).Column("OBJECTIVE_SCORE").Not.Nullable();
            Map(x => x.Gold).Column("GOLD").Not.Nullable();
        }
    }

}
