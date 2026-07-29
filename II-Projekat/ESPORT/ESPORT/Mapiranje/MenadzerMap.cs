using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class MenadzerMap : ClassMap<Menadzer>
    {
        public MenadzerMap()
        {
            Table("MENADZER");
            Map(x => x.OsobaId).Column("OSOBAID");
            Map(x => x.OblastOdgovornosti).Column("OBLAST_ODGOVORNOSTI");
        }
    }
}
