using ESPORT.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ESPORT.Mapiranje
{
    public class UgovorSubjekatMap : ClassMap<UgovorSubjekat>
    {
        public UgovorSubjekatMap()
        {
            Table("UGOVOR_SUBJEKAT");

            // Primarni ključ je ujedno i strani ključ ka SponzorskiUgovor
            Id(x => x.UgovorId).Column("UGOVOR_ID").GeneratedBy.Foreign("Ugovor");

            // Relacija 1:1 sa SponzorskiUgovor preko primarnog ključa
            HasOne(x => x.Ugovor)
                .Constrained()
                .ForeignKey();

            // ----------------------------------------------------
            // RELACIJE (Many-to-One) - Opcioni subjekti ugovora
            // ----------------------------------------------------

            // 1. Tim (TIM_ID)
            References(x => x.Tim)
                .Column("TIM_ID")
                .Nullable()
                .LazyLoad();

            // 2. Igrac (IGRAC_ID)
            References(x => x.Igrac)
                .Column("IGRAC_ID")
                .Nullable()
                .LazyLoad();

            // 3. Takmicenje (TAKMICENJE_ID)
            References(x => x.Takmicenje)
                .Column("TAKMICENJE_ID")
                .Nullable()
                .LazyLoad();
        }
    }
}
