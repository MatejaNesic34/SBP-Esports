using ESPORT.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class UgovorSubjekatMap : ClassMap<UgovorSubjekat>
    {
        public UgovorSubjekatMap()
        {
            Table("UGOVOR_SUBJEKAT");

            Id(x => x.UgovorId).Column("UGOVOR_ID").GeneratedBy.Foreign("Ugovor");

            HasOne(x => x.Ugovor)
                .Constrained()
                .ForeignKey();
            
            References(x => x.Tim)
                .Column("TIM_ID")
                .Nullable()
                .LazyLoad();

            References(x => x.Igrac)
                .Column("IGRAC_ID")
                .Nullable()
                .LazyLoad();

            References(x => x.Takmicenje)
                .Column("TAKMICENJE_ID")
                .Nullable()
                .LazyLoad();
        }
    }
}
