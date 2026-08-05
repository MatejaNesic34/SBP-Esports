using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class IgracMap : SubclassMap<Igrac>
    {
        public IgracMap()
        {
            Table("IGRAC");

            // Povezivanje sa roditeljskom tabelom (Osoba) preko primarnog/stranog ključa
            KeyColumn("OSOBAID");

            // Specifične kolone za igrača
            Map(x => x.Nadimak).Column("NADIMAK").Not.Nullable();
            Map(x => x.PrimarnaUloga).Column("PRIMARNA_ULOGA").Nullable();
            Map(x => x.SekundarnaUloga).Column("SEKUNDARNA_ULOGA").Nullable();
            Map(x => x.DominantniStil).Column("DOMINANTNI_STIL").Nullable();
            Map(x => x.Rang).Column("RANG").Nullable();

            // ----------------------------------------------------
            // VEZE / KOLEKCIJE (One-to-Many za Igrača)
            // ----------------------------------------------------

            // 1. Ugovori
            HasMany(x => x.Ugovori)
                .KeyColumn("IGRACID") // ili OSOBAID, zavisi kako se zove FK u tabeli UGOVOR_IGRACA
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            // 2. Transferi
            HasMany(x => x.Transferi)
                .KeyColumn("IGRACID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            // 3. Pozajmice
            HasMany(x => x.Pozajmice)
                .KeyColumn("IGRACID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            // 4. IndividualniRezultati
            HasMany(x => x.IndividualniRezultati)
                .KeyColumn("IGRACID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            // 5. SponzorskiUgovoriKaoSubjekat
            HasMany(x => x.SponzorskiUgovoriKaoSubjekat)
                .KeyColumn("IGRACID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();
        }
    }
}
