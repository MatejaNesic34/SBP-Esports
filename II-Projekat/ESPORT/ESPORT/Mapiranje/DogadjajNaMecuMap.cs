using ESPORT.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class DogadjajNaMecuMap : ClassMap<DogadjajNaMecu>
    {
        public DogadjajNaMecuMap()
        {
            Table("DOGADJAJ_NA_MECU");

            Id(x => x.DogadjajId).Column("DOGADJAJ_ID").GeneratedBy.Increment();

            Map(x => x.TipDogadjaja).Column("TIP_DOGADJAJA").Not.Nullable();
            Map(x => x.VremeDogadjaja).Column("VREME_DOGADJAJA").Not.Nullable();
            Map(x => x.Opis).Column("OPIS").Not.Nullable();
            Map(x => x.OdlukaSudije).Column("ODLUKA_SUDIJE").Nullable();

            
            References(x => x.Mec)
                .Column("MEC_ID")
                .Not.Nullable()
                .LazyLoad();
        }
    }
}
