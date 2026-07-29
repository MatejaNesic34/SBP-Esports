using ESPORT.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class Ugovor_IgracaMap : ClassMap<UgovorIgraca>
    {
        public Ugovor_IgracaMap()
        {
            Table("UGOVOR_IGRACA");
            Map(x => x.UgovorId).Column("UGOVOR_ID");
            Map(x => x.Igrac).Column("IGRAC_ID");
            Map(x => x.Tim).Column("TIM_ID");
            Map(x => x.DatumOd).Column("DATUM_OD");
            Map(x => x.DatumDo).Column("DATUM_DO");
            Map(x => x.TipUgovora).Column("TIP_UGOVORA");
            Map(x => x.Plata).Column("PLATA");
            Map(x => x.Bonusi).Column("BONUSI");
            Map(x => x.KlauzulaOtkup).Column("KLAUZULA_OTKUP");
            Map(x => x.ZabranaNastupa).Column("ZABRANA_NASTUPA");
            Map(x => x.StatusIgraca).Column("STATUS_IGRACA");
        }
    }

}
