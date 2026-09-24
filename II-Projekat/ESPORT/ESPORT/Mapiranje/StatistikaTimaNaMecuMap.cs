using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class StatistikaTimaNaMecuMap : ClassMap<StatistikaTimaNaMecu>
    {
        public StatistikaTimaNaMecuMap()
        {
            Table("STATISTIKA_TIMA_NA_MECU");

            CompositeId()
                .KeyReference(x => x.MecId, "MEC_ID")
                .KeyReference(x => x.TimId, "TIM_ID");

            Map(x => x.Kills).Column("KILLS").Not.Nullable();
            Map(x => x.Deaths).Column("DEATHS").Not.Nullable();
            Map(x => x.Assists).Column("ASSISTS").Not.Nullable();
            Map(x => x.Damage).Column("DAMAGE").Not.Nullable();
            Map(x => x.ObjectiveScore).Column("OBJECTIVE_SCORE").Not.Nullable();
            Map(x => x.Gold).Column("GOLD").Not.Nullable();
        }
    }

}
