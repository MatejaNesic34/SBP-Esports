using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class TimMap : ClassMap<Tim>
    {
        public TimMap()
        {
            Table("TIM");

            Id(x => x.TimId).Column("TIMID").GeneratedBy.Increment();

            Map(x => x.Naziv).Column("NAZIV").Not.Nullable();
            Map(x => x.DatumOsnivanja).Column("DATUM_OSNIVANJA").Nullable();
            Map(x => x.DrzavaRegistracije).Column("DRZAVA_REGISTRACIJE").Nullable();
            Map(x => x.StatusTima).Column("STATUS_TIMA").Nullable();
            Map(x => x.NivoTakmicenja).Column("NIVO_TAKMICENJA").Nullable();


            References(x => x.IgraId)
                .Column("IGRA_ID")
                .Not.Nullable()
                .LazyLoad();


            HasMany(x => x.UgovoriIgraca)
                .KeyColumn("TIM_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();


            HasMany(x => x.Odlasci)
                .KeyColumn("PRETHODNI_TIM_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.Dolasci)
                .KeyColumn("NOVI_TIM_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();


            HasMany(x => x.PozajmiceIzTima)
                .KeyColumn("MATIČNI_TIM_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.PozajmiceUTim)
                .KeyColumn("TIM_NA_POZAJMICI_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.Osoblje)
                .KeyColumn("TIMID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.UcescaNaTakmicenjima)
                .KeyColumn("TIM_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.StatistikeNaMecevima)
                .KeyColumn("TIM_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.SponzorskiUgovoriKaoSubjekat)
                .KeyColumn("TIM_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

        }
    }
}
