using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class SponzorMap : ClassMap<Sponzor>
    {
        public SponzorMap()
        {
            Table("SPONZOR");

            Id(x => x.SponzorId).Column("SPONZOR_ID").GeneratedBy.Increment();

            Map(x => x.Naziv).Column("NAZIV").Not.Nullable().Unique();
            Map(x => x.Drzava).Column("DRZAVA").Nullable();
            Map(x => x.TipSponzora).Column("TIP_SPONZORA").Nullable();
            Map(x => x.OblastPoslovanja).Column("OBLAST_POSLOVANJA").Nullable();

           
            HasMany(x => x.Kontakti)
                .KeyColumn("SPONZOR_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.Ugovori)
                .KeyColumn("SPONZOR_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();
        }
    }
}
