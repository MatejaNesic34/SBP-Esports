using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class SkautMap : ClassMap<Skaut>
    {
        public SkautMap()
        {
            Table("SKAUT");
            Map(x => x.OsobaId).Column("OSOBAID");
            Map(x => x.Igra).Column("IDIGRE");
        }
    }
}
