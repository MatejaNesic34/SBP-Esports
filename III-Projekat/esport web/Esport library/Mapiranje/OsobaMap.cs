using ESPORT.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ESPORT.Mapiranje
{
    public class OsobaMap : ClassMap<Osoba>
    {
        public OsobaMap()
        {
            Table("OSOBA");

            Id(x => x.OsobaId).Column("OSOBAID").GeneratedBy.Increment();

            Map(x => x.Ime).Column("IME").Not.Nullable();
            Map(x => x.Prezime).Column("PREZIME").Not.Nullable();
            Map(x => x.DatumRodjenja).Column("DATUM_RODJENJA").Nullable();
            Map(x => x.Drzava).Column("DRZAVA").Nullable();
            Map(x => x.Email).Column("EMAIL").Nullable();
            Map(x => x.DatumPrvogAngazovanja).Column("DATUM_PRVOG_ANGAZOVANJA").Nullable();
            Map(x => x.StatusAngazmana).Column("STATUS_ANGAZMANA").Nullable();

            
            HasMany(x => x.Telefoni)
                .KeyColumn("OSOBAID")
                .Cascade.All()
                .Inverse()
                .LazyLoad();

            HasMany(x => x.Licence)
                .KeyColumn("OSOBAID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.AngazmaniZaposlenog)
                .KeyColumn("OSOBAID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();
        
        }
    }
}
