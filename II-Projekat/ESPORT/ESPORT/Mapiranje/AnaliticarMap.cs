using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class AnaliticarMap : SubclassMap<Analiticar>
    {
        public AnaliticarMap()
        {
            Table("ANALITICAR");

            // Povezivanje sa roditeljskom tabelom (Osoba) preko primarnog/stranog ključa
            KeyColumn("OSOBAID");

            // Specifična polja za analitičara
            Map(x => x.OblastAnalize).Column("OBLAST_ANALIZE").Nullable();
            Map(x => x.Alati).Column("ALATI").Nullable();
            Map(x => x.NivoIskustva).Column("NIVO_ISKUSTVA").Nullable();
        }
    }
}
