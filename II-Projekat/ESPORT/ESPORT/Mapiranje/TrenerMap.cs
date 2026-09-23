using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class TrenerMap : SubclassMap<Trener>
    {
        public TrenerMap()
        {
            Table("TRENER");

            KeyColumn("OSOBAID");

            Map(x => x.TipUloge).Column("TIP_ULOGE").Nullable();
            Map(x => x.StilRada).Column("STIL_RADA").Nullable();

            HasMany(x => x.AngazmaniTrenera)
                .KeyColumn("TRENER_ID") 
                .LazyLoad()
                .Cascade.All()
                .Inverse();
        }
    }
}
