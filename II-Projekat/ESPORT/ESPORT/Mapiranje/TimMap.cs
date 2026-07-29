using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class TimMap : ClassMap<Tim>
    {
        public TimMap()
        {
            Table("TIM");
            Map(x => x.TimId).Column("TIMID");
            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.Igra).Column("IGRA_ID");
            Map(x => x.DatumOsnivanja).Column("DATUM_OSNIVANJA");
            Map(x => x.DrzavaRegistracije).Column("DRZAVA_REGISTRACIJE");
            Map(x => x.StatusTima).Column("STATUS_TIMA");
            Map(x => x.NivoTakmicenja).Column("NIVO_TAKMICENJA");
        }
    }
}
