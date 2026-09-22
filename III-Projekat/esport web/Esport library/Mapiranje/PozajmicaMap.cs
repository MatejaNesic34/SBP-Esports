using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPORT.Entiteti;
using FluentNHibernate.Mapping;

namespace ESPORT.Mapiranje
{
    public class PozajmicaMap : ClassMap<Pozajmica>
    {
        public PozajmicaMap()
        {
            Table("POZAJMICA");

            // Primarni ključ
            Id(x => x.PozajmicaId).Column("POZAJMICA_ID").GeneratedBy.TriggerIdentity();

            // Obična polja / atributi
            Map(x => x.DatumOd).Column("DATUM_OD").Not.Nullable();
            Map(x => x.DatumDo).Column("DATUM_DO").Not.Nullable();
            Map(x => x.FinansijskiUslovi).Column("FINANSIJSKI_USLOVI").Nullable();
            Map(x => x.PravoOtkupa).Column("PRAVO_OTKUPA").Not.Nullable();

            // ----------------------------------------------------
            // RELACIJE (Many-to-One)
            // ----------------------------------------------------

            // Strani ključ ka Igrac (IGRAC_ID)
            References(x => x.Igrac)
                .Column("IGRAC_ID")
                .Not.Nullable()
                .LazyLoad();

            // Strani ključ ka Tim - Matični tim (MATIČNI_TIM_ID)
            References(x => x.MaticniTim)
                .Column("MATIČNI_TIM_ID")
                .Not.Nullable()
                .LazyLoad();

            // Strani ključ ka Tim - Tim na pozajmici (TIM_NA_POZAJMICI_ID)
            References(x => x.TimNaPozajmici)
                .Column("TIM_NA_POZAJMICI_ID")
                .Not.Nullable()
                .LazyLoad();
        }
    }
}
