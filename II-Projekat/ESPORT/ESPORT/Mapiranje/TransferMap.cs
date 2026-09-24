using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class TransferMap : ClassMap<Transfer>
    {
        public TransferMap()
        {
            Table("TRANSFER");

            Id(x => x.TransferId).Column("TRANSFER_ID").GeneratedBy.Increment();

            Map(x => x.DatumPrelaska).Column("DATUM_PRELASKA").Not.Nullable();
            Map(x => x.IznosTransfera).Column("IZNOS_TRANSFERA").Not.Nullable();
            Map(x => x.Valuta).Column("VALUTA").Nullable();
            Map(x => x.TrajanjeUgovoraMeseci).Column("TRAJANJE_UGOVORA_MESECI").Nullable();
            Map(x => x.PosebneKlauzule).Column("POSEBNE_KLAUZULE").Nullable();

            
            References(x => x.Igrac)
                .Column("IGRAC_ID")
                .Not.Nullable()
                .LazyLoad();

            References(x => x.PrethodniTim)
                .Column("PRETHODNI_TIM_ID")
                .Nullable()
                .LazyLoad();

            References(x => x.NoviTim)
                .Column("NOVI_TIM_ID")
                .Not.Nullable()
                .LazyLoad();
        }
    }
}
