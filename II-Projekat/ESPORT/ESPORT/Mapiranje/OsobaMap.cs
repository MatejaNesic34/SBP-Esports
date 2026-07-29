using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class OsobaMap : ClassMap<Osoba>
    {
        public OsobaMap()
        {
            Table("OSOBA");
            Map(x => x.OsobaId).Column("OSOBAID");
            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.DatumRodjenja).Column("DATUM_RODJENJA");
            Map(x => x.Drzava).Column("DRZAVA");
            Map(x => x.Email).Column("EMAIL");
            Map(x => x.DatumPrvogAngazovanja).Column("DATUM_PRVOG_ANGAZOVANJA");
            Map(x => x.StatusAngazmana).Column("STATUS_ANGAZMANA");
        }
    }
}
