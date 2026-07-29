using ESPORT.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class AngazmanZaposlenihMap : ClassMap<AngazmanZaposlenih>
    {
        public AngazmanZaposlenihMap()
        {
            Table("ANGAZMAN_ZAPOSLENIH");
            Map(x => x.AngazmanOsobljaId).Column("ANGAZMAN_OSOBLJA_ID");
            Map(x => x.Osoba).Column("OSOBAID");
            Map(x => x.Tim).Column("TIMID");
            Map(x => x.NazivUloge).Column("NAZIV_ULOGE");
            Map(x => x.DatumOd).Column("DATUM_OD");
            Map(x => x.DatumDo).Column("DATUM_DO");
            Map(x => x.Plata).Column("PLATA");
        }
    }
}
