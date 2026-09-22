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

            // Primarni ključ
            Id(x => x.FazaId).Column("FAZA_ID").GeneratedBy.Increment();

            // Obična polja / atributi
            Map(x => x.NazivFaze).Column("NAZIV_FAZE").Not.Nullable();
            Map(x => x.RedniBroj).Column("REDNI_BROJ").Not.Nullable();

            // ----------------------------------------------------
            // RELACIJE (Many-to-One)
            // ----------------------------------------------------

            // Strani ključ ka Turnir (TAKMICENJE_ID)
            References(x => x.Turnir)
                .Column("TAKMICENJE_ID")
                .Not.Nullable()
                .LazyLoad();

            // Self-referencing: Roditeljska faza (NADFAZA_ID)
            References(x => x.Nadfaza)
                .Column("NADFAZA_ID")
                .Nullable()
                .LazyLoad();

            // ----------------------------------------------------
            // VEZE / KOLEKCIJE (One-to-Many)
            // ----------------------------------------------------

            // 1. Self-referencing: Lista podfaza (preko iste NADFAZA_ID kolone)
            HasMany(x => x.Podfaze)
                .KeyColumn("NADFAZA_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            // 2. TimoviUcesnici (UcesceTimaUFazi)
            HasMany(x => x.TimoviUcesnici)
                .KeyColumn("FAZA_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();
        }
    }
}
