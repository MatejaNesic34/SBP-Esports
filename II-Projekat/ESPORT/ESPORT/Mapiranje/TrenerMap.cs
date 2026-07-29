using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class TrenerMap : ClassMap<Trener>
    {
        public TrenerMap()
        {
            Table("TRENER");
            Map(x => x.OsobaId).Column("OSOBAID");
            Map(x => x.TipUloge).Column("TIP_ULOGE");
            Map(x => x.StilRada).Column("STIL_RADA");
        }
    }
}
