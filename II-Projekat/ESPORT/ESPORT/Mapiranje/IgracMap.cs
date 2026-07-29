using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class IgracMap : ClassMap<Igrac>
    {
        public IgracMap()
        {
            Table("IGRAC");
            Map(x => x.OsobaId).Column("OSOBAID");
            Map(x => x.Nadimak).Column("NADIMAK");
            Map(x => x.PrimarnaUloga).Column("PRIMARNA_ULOGA");
            Map(x => x.SekundarnaUloga).Column("SEKUNDARNA_ULOGA");
            Map(x => x.DominantniStil).Column("DOMINANTNI_STIL");
            Map(x => x.Rang).Column("RANG");
        }
    }
}
