using ESPORT.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class IndividualniRezultatMap : ClassMap<IndividualniRezultat>
    {
        public IndividualniRezultatMap()
        {
            Table("INDIVIDUALNI_REZULTAT");
            Map(x => x.RezultatId).Column("REZULTAT_ID");
            Map(x => x.Igrac).Column("IGRAC_ID");
            Map(x => x.NazivPriznanja).Column("NAZIV_PRIZNANJA");
            Map(x => x.DatumOstvarivanja).Column("DATUM_OSTVARIVANJA");
            Map(x => x.Takmicenje).Column("TAKMICENJE_ID");
            Map(x => x.Opis).Column("OPIS");
        }
    }
}
