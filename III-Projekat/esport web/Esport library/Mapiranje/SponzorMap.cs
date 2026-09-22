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

            // Primarni ključ
            Id(x => x.SponzorId).Column("SPONZOR_ID").GeneratedBy.Increment();

            // Obična polja / atributi
            Map(x => x.Naziv).Column("NAZIV").Not.Nullable().Unique();
            Map(x => x.Drzava).Column("DRZAVA").Nullable();
            Map(x => x.TipSponzora).Column("TIP_SPONZORA").Nullable();
            Map(x => x.OblastPoslovanja).Column("OBLAST_POSLOVANJA").Nullable();

            // ----------------------------------------------------
            // VEZE / KOLEKCIJE (One-to-Many)
            // ----------------------------------------------------

            // 1. Kontakti sponzora (SponzorKontakt)
            HasMany(x => x.Kontakti)
                .KeyColumn("SPONZOR_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            // 2. Sponzorski ugovori (SponzorskiUgovor)
            HasMany(x => x.Ugovori)
                .KeyColumn("SPONZOR_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();
        }
    }
}
