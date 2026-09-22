using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ESPORT.Entiteti;

namespace ESPORT.Mapiranje
{
    public class TimMap : ClassMap<Tim>
    {
        public TimMap()
        {
            Table("TIM");

            // Primarni ključ
            Id(x => x.TimId).Column("TIMID").GeneratedBy.Increment();

            // Obična polja / atributi
            Map(x => x.Naziv).Column("NAZIV").Not.Nullable();
            Map(x => x.DatumOsnivanja).Column("DATUM_OSNIVANJA").Nullable();
            Map(x => x.DrzavaRegistracije).Column("DRZAVA_REGISTRACIJE").Nullable();
            Map(x => x.StatusTima).Column("STATUS_TIMA").Nullable();
            Map(x => x.NivoTakmicenja).Column("NIVO_TAKMICENJA").Nullable();

            // ----------------------------------------------------
            // RELACIJE (Many-to-One)
            // ----------------------------------------------------

            // Strani ključ ka Igra (IGRA_ID)
            References(x => x.IgraId)
                .Column("IGRA_ID")
                .Not.Nullable()
                .LazyLoad();

            // ----------------------------------------------------
            // VEZE / KOLEKCIJE (One-to-Many)
            // ----------------------------------------------------

            // 1. UgovoriIgraca
            HasMany(x => x.UgovoriIgraca)
                .KeyColumn("TIMID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            //// 2. Transferi - Odlasci (matični tim)
            //HasMany(x => x.Odlasci)
            //    .KeyColumn("STARI_TIM_ID") // Zamenite tačnim nazivom FK kolone u tabeli TRANSFER
            //    .LazyLoad()
            //    .Cascade.All()
            //    .Inverse();

            //// 3. Transferi - Dolasci (novi tim)
            //HasMany(x => x.Dolasci)
            //    .KeyColumn("NOVI_TIM_ID")  // Zamenite tačnim nazivom FK kolone u tabeli TRANSFER
            //    .LazyLoad()
            //    .Cascade.All()
            //    .Inverse();

            // 2. Transferi - Odlasci (prethodni tim)
            HasMany(x => x.Odlasci)
                .KeyColumn("PRETHODNI_TIM_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            // 3. Transferi - Dolasci (novi tim)
            HasMany(x => x.Dolasci)
                .KeyColumn("NOVI_TIM_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            //// 4. Pozajmice - PozajmiceIzTima
            //HasMany(x => x.PozajmiceIzTima)
            //    .KeyColumn("MATICNI_TIM_ID") // Zamenite tačnim nazivom FK kolone u tabeli POZAJMICA
            //    .LazyLoad()
            //    .Cascade.All()
            //    .Inverse();

            //// 5. Pozajmice - PozajmiceUTim
            //HasMany(x => x.PozajmiceUTim)
            //    .KeyColumn("DESTINACIJSKI_TIM_ID") // Zamenite tačnim nazivom FK kolone u tabeli POZAJMICA
            //    .LazyLoad()
            //    .Cascade.All()
            //    .Inverse();

            // 4. Pozajmice - PozajmiceIzTima (matični tim)
            HasMany(x => x.PozajmiceIzTima)
                .KeyColumn("MATIČNI_TIM_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            // 5. Pozajmice - PozajmiceUTim (tim na pozajmici)
            HasMany(x => x.PozajmiceUTim)
                .KeyColumn("TIM_NA_POZAJMICI_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            // 6. Osoblje (AngazmanZaposlenih)
            HasMany(x => x.Osoblje)
                .KeyColumn("TIMID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            // 7. Treneri (AngazmanTrenera)
            HasMany(x => x.Treneri)
                .KeyColumn("TIMID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            // 8. UcescaNaTakmicenjima
            HasMany(x => x.UcescaNaTakmicenjima)
                .KeyColumn("TIMID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            // 9. StatistikeNaMecevima
            HasMany(x => x.StatistikeNaMecevima)
                .KeyColumn("TIMID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            // 10. SponzorskiUgovoriKaoSubjekat
            HasMany(x => x.SponzorskiUgovoriKaoSubjekat)
                .KeyColumn("TIMID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();



        }
    }
}
