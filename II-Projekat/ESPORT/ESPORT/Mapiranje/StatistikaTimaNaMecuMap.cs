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
            Map(x => x.MecId).Column("MEC_ID");
            Map(x => x.TimId).Column("TIM_ID");
            Map(x => x.Kills).Column("KILLS");
            Map(x => x.Deaths).Column("DEATHS");
            Map(x => x.Assists).Column("ASSISTS");
            Map(x => x.Damage).Column("DAMAGE");
            Map(x => x.ObjectiveScore).Column("OBJECTIVE_SCORE");
            Map(x => x.Gold).Column("GOLD");
        }
    }

}
