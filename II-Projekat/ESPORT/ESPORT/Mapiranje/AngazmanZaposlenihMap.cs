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

            // Primarni ključ
            Id(x => x.AngazmanOsobljaId).Column("ANGAZMAN_OSOBLJA_ID").GeneratedBy.Increment();

            // Obična polja / atributi
            Map(x => x.NazivUloge).Column("NAZIV_ULOGE").Not.Nullable();
            Map(x => x.DatumOd).Column("DATUM_OD").Not.Nullable();
            Map(x => x.DatumDo).Column("DATUM_DO").Nullable();
            Map(x => x.Plata).Column("PLATA").Nullable();

            // ----------------------------------------------------
            // RELACIJE (Many-to-One)
            // ----------------------------------------------------

            // Strani ključ ka Osoba (OSOBAID)
            References(x => x.Osoba)
                .Column("OSOBAID")
                .Not.Nullable()
                .LazyLoad();

            // Strani ključ ka Tim (TIMID)
            References(x => x.Tim)
                .Column("TIMID")
                .Not.Nullable()
                .LazyLoad();
        }
    }
}
