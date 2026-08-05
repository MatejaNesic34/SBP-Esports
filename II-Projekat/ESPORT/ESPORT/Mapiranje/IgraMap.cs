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

            // Primarni ključ
            Id(x => x.IgraId).Column("IGRAID").GeneratedBy.TriggerIdentity();

            // Svojstva / Kolone
            Map(x => x.Naziv).Column("NAZIV").Not.Nullable().Unique();
            Map(x => x.Zanr).Column("ZANR").Nullable();

            // ----------------------------------------------------
            // VEZE / KOLEKCIJE (One-to-Many)
            // ----------------------------------------------------

            // 1. Igra -> Timovi
            HasMany(x => x.Timovi)
                .KeyColumn("IGRAID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            // 2. Igra -> Takmicenja
            HasMany(x => x.Takmicenja)
                .KeyColumn("IGRAID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            // 3. Igra -> Skauti
            HasMany(x => x.Skauti)
                .KeyColumn("IGRAID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();
        }
    }
}
