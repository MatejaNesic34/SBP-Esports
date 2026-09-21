using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class LigaMap : SubclassMap<Liga>
    {
        public LigaMap()
        {
            Table("LIGA");

            // Povezivanje sa roditeljskom tabelom (Takmicenje) preko primarnog/stranog ključa
            KeyColumn("TAKMICENJE_ID");

            // Specifično polje za Ligu
            Map(x => x.SistemBodovanja).Column("SISTEM_BODOVANJA").Not.Nullable();
        }
    }

}
