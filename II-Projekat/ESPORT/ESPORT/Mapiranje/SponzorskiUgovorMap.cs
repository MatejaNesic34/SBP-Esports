using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class SponzorskiUgovorMap : ClassMap<SponzorskiUgovor>
    {
        public SponzorskiUgovorMap()
        {
            Table("SPONZORSKI_UGOVOR");

            Id(x => x.UgovorId).Column("UGOVOR_ID").GeneratedBy.Increment();

            Map(x => x.DatumOd).Column("DATUM_OD").Not.Nullable();
            Map(x => x.DatumDo).Column("DATUM_DO").Not.Nullable();
            Map(x => x.Iznos).Column("IZNOS").Not.Nullable();
            Map(x => x.Valuta).Column("VALUTA").Nullable();
            Map(x => x.TipPodrske).Column("TIP_PODRSKE").Not.Nullable();
            Map(x => x.MarketinskeObaveze).Column("MARKETINSKE_OBAVEZE").Nullable();

          
            References(x => x.Sponzor)
                .Column("SPONZOR_ID")
                .Not.Nullable()
                .LazyLoad();

            
            HasOne(x => x.Subjekat)
                .PropertyRef(x => x.Ugovor)
                .Cascade.All();
        }
    }
}
