using ESPORT.Entiteti;
using FluentNHibernate.Mapping;
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

            Id(x => x.FazaId).Column("FAZA_ID").GeneratedBy.Increment();

            Map(x => x.NazivFaze).Column("NAZIV_FAZE").Not.Nullable();
            Map(x => x.RedniBroj).Column("REDNI_BROJ").Not.Nullable();

           
            References(x => x.Turnir)
                .Column("TAKMICENJE_ID")
                .Not.Nullable()
                .LazyLoad();

            References(x => x.Nadfaza)
                .Column("NADFAZA_ID")
                .Nullable()
                .LazyLoad();

            HasMany(x => x.Podfaze)
                .KeyColumn("NADFAZA_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.TimoviUcesnici)
                .KeyColumn("FAZA_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();
        }
    }
}
