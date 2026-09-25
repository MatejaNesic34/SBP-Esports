using ESPORT.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ESPORT.Mapiranje
{
    public class PozajmicaMap : ClassMap<Pozajmica>
    {
        public PozajmicaMap()
        {
            Table("POZAJMICA");

            Id(x => x.PozajmicaId).Column("POZAJMICA_ID").GeneratedBy.Increment();

            Map(x => x.DatumOd).Column("DATUM_OD").Not.Nullable();
            Map(x => x.DatumDo).Column("DATUM_DO").Not.Nullable();
            Map(x => x.FinansijskiUslovi).Column("FINANSIJSKI_USLOVI").Nullable();
            Map(x => x.PravoOtkupa).Column("PRAVO_OTKUPA").Not.Nullable();

            
            References(x => x.Igrac)
                .Column("IGRAC_ID")
                .Not.Nullable()
                .LazyLoad();

            References(x => x.MaticniTim)
                .Column("MATIČNI_TIM_ID")
                .Not.Nullable()
                .LazyLoad();

            References(x => x.TimNaPozajmici)
                .Column("TIM_NA_POZAJMICI_ID")
                .Not.Nullable()
                .LazyLoad();
        }
    }
}
