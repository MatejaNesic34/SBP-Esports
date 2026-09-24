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

            KeyColumn("OSOBAID");

            Map(x => x.Nadimak).Column("NADIMAK").Not.Nullable();
            Map(x => x.PrimarnaUloga).Column("PRIMARNA_ULOGA").Nullable();
            Map(x => x.SekundarnaUloga).Column("SEKUNDARNA_ULOGA").Nullable();
            Map(x => x.DominantniStil).Column("DOMINANTNI_STIL").Nullable();
            Map(x => x.Rang).Column("RANG").Nullable();

           
            HasMany(x => x.Ugovori)
                .KeyColumn("IGRAC_ID") 
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.Transferi)
                .KeyColumn("IGRAC_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.Pozajmice)
                .KeyColumn("IGRAC_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.IndividualniRezultati)
                .KeyColumn("IGRAC_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.SponzorskiUgovoriKaoSubjekat)
                .KeyColumn("IGRAC_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();
        }
    }
}
