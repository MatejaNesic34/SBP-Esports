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

            // Primarni ključ
            Id(x => x.OsobaId).Column("OSOBAID").GeneratedBy.TriggerIdentity();

            // Obična polja / atributi sa .Column()
            Map(x => x.Ime).Column("IME").Not.Nullable();
            Map(x => x.Prezime).Column("PREZIME").Not.Nullable();
            Map(x => x.DatumRodjenja).Column("DATUM_RODJENJA").Nullable();
            Map(x => x.Drzava).Column("DRZAVA").Nullable();
            Map(x => x.Email).Column("EMAIL").Nullable();
            Map(x => x.DatumPrvogAngazovanja).Column("DATUM_PRVOG_ANGAZOVANJA").Nullable();
            Map(x => x.StatusAngazmana).Column("STATUS_ANGAZMANA").Nullable();

            // ----------------------------------------------------
            // VEZE / KOLEKCIJE
            // ----------------------------------------------------

            // 1. Element Collection
            //HasMany(x => x.Telefoni)
            //    .KeyColumn("OSOBAID")
            //    .Table("OSOBA_TELEFON")
            //    .Element("TELEFON")
            //    .Cascade.All()
            //    .LazyLoad();

            // U OsobaMap.cs zamenite prethodni HasMany(x => x.Telefoni) sa:
            HasMany(x => x.Telefoni)
                .KeyColumn("OSOBAID")
                .Cascade.All()
                .Inverse()
                .LazyLoad();

            // 2. One-to-Many: Licence
            HasMany(x => x.Licence)
                .KeyColumn("OSOBAID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            // 3. One-to-Many: AngazmaniZaposlenog
            HasMany(x => x.AngazmaniZaposlenog)
                .KeyColumn("OSOBAID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();
        
        }
    }
}
