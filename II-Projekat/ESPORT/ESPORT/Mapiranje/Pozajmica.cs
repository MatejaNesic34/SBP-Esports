using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class PozajmicaMap : ClassMap<Pozajmica>
    {
        public PozajmicaMap()
        {
            Table("POZAJMICA");
            Id(x => x.PozajmicaId).Column("POZAJMICA_ID").GeneratedBy.Sequence("POZAJMICA_SEQ");
            Map(x => x.Igrac).Column("IGRAC_ID");
            Map(x => x.MaticniTim).Column("MATIČNI_TIM_ID");
            Map(x => x.TimNaPozajmici).Column("TIM_NA_POZAJMICI_ID");
            Map(x => x.DatumOd).Column("DATUM_OD");
            Map(x => x.DatumDo).Column("DATUM_DO");
            Map(x => x.FinansijskiUslovi).Column("FINANSIJSKI_USLOVI");
            Map(x => x.PravoOtkupa).Column("PRAVO_OTKUPA");
        }
    }
}
