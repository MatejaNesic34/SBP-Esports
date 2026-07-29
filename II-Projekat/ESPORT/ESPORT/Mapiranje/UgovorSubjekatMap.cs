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
            Map(x => x.Ugovor).Column("UGOVOR_ID");
            Map(x => x.Tim).Column("TIM_ID");
            Map(x => x.Igrac).Column("IGRAC_ID");
            Map(x => x.Takmicenje).Column("TAKMICENJE_ID");
        }
    }
}
