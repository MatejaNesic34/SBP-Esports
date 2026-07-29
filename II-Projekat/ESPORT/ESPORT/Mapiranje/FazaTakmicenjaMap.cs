using ESPORT.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class FazaTakmicenjaMap : ClassMap<FazaTakmicenja>
    {
        public FazaTakmicenjaMap()
        {
            Table("FAZA_TAKMICENJA");
            Map(x => x.FazaId).Column("FAZA_ID");
            Map(x => x.Turnir).Column("TAKMICENJE_ID");
            Map(x => x.NazivFaze).Column("NAZIV_FAZE");
            Map(x => x.RedniBroj).Column("REDNI_BROJ");
            Map(x => x.Nadfaza).Column("NADFAZA_ID");
        }
    }
}
