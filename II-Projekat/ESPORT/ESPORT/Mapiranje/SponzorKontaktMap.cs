using ESPORT.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class SponzorKontaktMap : ClassMap<SponzorKontakt>
    {
        public SponzorKontaktMap()
        {
            Table("SPONZOR_KONTAKT");
            Map(x => x.KontaktId).Column("KONTAKT_ID");
            Map(x => x.Sponzor).Column("SPONZOR_ID");
            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.Telefon).Column("TELEFON");
            Map(x => x.Email).Column("EMAIL");
        }
    }
}
