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
            Map(x => x.DogadjajId).Column("DOGADJAJ_ID");
            Map(x => x.Mec).Column("MEC_ID");
            Map(x => x.TipDogadjaja).Column("TIP_DOGADJAJA");
            Map(x => x.VremeDogadjaja).Column("VREME_DOGADJAJA");
            Map(x => x.Opis).Column("OPIS");
            Map(x => x.OdlukaSudije).Column("ODLUKA_SUDIJE");
        }
    }
}
