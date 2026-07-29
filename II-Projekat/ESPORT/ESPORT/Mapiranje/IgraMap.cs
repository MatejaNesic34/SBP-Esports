using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class IgraMap : ClassMap<Igra>
    {
        public IgraMap()
        {
            Table("IGRA");
            Map(x => x.IgraId).Column("IGRAID");
            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.Zanr).Column("ZANR");
        }
    }
}
