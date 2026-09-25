using ESPORT.Entiteti;
using FluentNHibernate.Mapping;
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

            Id(x => x.KontaktId).Column("KONTAKT_ID").GeneratedBy.Increment();

            Map(x => x.Ime).Column("IME").Not.Nullable();
            Map(x => x.Prezime).Column("PREZIME").Not.Nullable();
            Map(x => x.Telefon).Column("TELEFON").Nullable();
            Map(x => x.Email).Column("EMAIL").Nullable();

           
            References(x => x.Sponzor)
                .Column("SPONZOR_ID")
                .Not.Nullable()
                .LazyLoad();
        }
    }
}
