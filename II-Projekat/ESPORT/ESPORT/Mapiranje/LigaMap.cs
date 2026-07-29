using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class LigaMap : ClassMap<Liga>
    {
        public LigaMap()
        {
            Table("LIGA");
            Map(x => x.TakmicenjeId).Column("TAKMICENJE_ID");
            Map(x => x.SistemBodovanja).Column("SISTEM_BODOVANJA");
        }
    }

}
