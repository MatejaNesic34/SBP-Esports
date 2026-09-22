using ESPORT.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class SponzorKontaktMap : ClassMap<SponzorKontakt>
    {
        public SponzorKontaktMap()
        {
            Table("SPONZOR_KONTAKT");

            // Primarni ključ
            Id(x => x.KontaktId).Column("KONTAKT_ID").GeneratedBy.Increment();

            // Obična polja / atributi
            Map(x => x.Ime).Column("IME").Not.Nullable();
            Map(x => x.Prezime).Column("PREZIME").Not.Nullable();
            Map(x => x.Telefon).Column("TELEFON").Nullable();
            Map(x => x.Email).Column("EMAIL").Nullable();

            // ----------------------------------------------------
            // RELACIJE (Many-to-One)
            // ----------------------------------------------------

            // Strani ključ ka Sponzor (SPONZOR_ID)
            References(x => x.Sponzor)
                .Column("SPONZOR_ID")
                .Not.Nullable()
                .LazyLoad();
        }
    }
}
