using ESPORT.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ESPORT.Mapiranje
{
    public class IgraMap : ClassMap<Igra>
    {
        public IgraMap()
        {
            Table("IGRA");

            Id(x => x.IgraId).Column("IGRAID").GeneratedBy.Increment();

            Map(x => x.Naziv).Column("NAZIV").Not.Nullable().Unique();
            Map(x => x.Zanr).Column("ZANR").Nullable();

            HasMany(x => x.Timovi)
                .KeyColumn("IGRA_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.Takmicenja)
                .KeyColumn("IGRA_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.Skauti)
                .KeyColumn("IDIGRE")
                .LazyLoad()
                .Cascade.All()
                .Inverse();
        }
    }
}
