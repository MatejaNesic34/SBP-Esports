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

            Id(x => x.UgovorId).Column("UGOVOR_ID").GeneratedBy.Increment();

            Map(x => x.DatumOd).Column("DATUM_OD").Not.Nullable();
            Map(x => x.DatumDo).Column("DATUM_DO").Nullable();
            Map(x => x.TipUgovora).Column("TIP_UGOVORA").Nullable();
            Map(x => x.Plata).Column("PLATA").Not.Nullable();
            Map(x => x.Bonusi).Column("BONUSI").Nullable();
            Map(x => x.KlauzulaOtkup).Column("KLAUZULA_OTKUP").Nullable();
            Map(x => x.ZabranaNastupa).Column("ZABRANA_NASTUPA").Nullable();
            Map(x => x.StatusIgraca).Column("STATUS_IGRACA").Not.Nullable();

            References(x => x.Igrac)
                .Column("IGRAC_ID")
                .Not.Nullable()
                .LazyLoad();

            References(x => x.Tim)
                .Column("TIM_ID")
                .Not.Nullable()
                .LazyLoad();
        }
    }

}
