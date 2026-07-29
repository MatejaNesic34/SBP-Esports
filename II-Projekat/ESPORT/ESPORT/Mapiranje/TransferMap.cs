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
            Id(x => x.TransferId).Column("TRANSFER_ID").GeneratedBy.Sequence("TRANSFER_SEQ");
            Map(x => x.Igrac).Column("IGRAC_ID");
            Map(x => x.PrethodniTim).Column("PRETHODNI_TIM_ID");
            Map(x => x.NoviTim).Column("NOVI_TIM_ID");
            Map(x => x.DatumPrelaska).Column("DATUM_PRELASKA");
            Map(x => x.IznosTransfera).Column("IZNOS_TRANSFERA");
            Map(x => x.Valuta).Column("VALUTA");
            Map(x => x.TrajanjeUgovoraMeseci).Column("TRAJANJE_UGOVORA_MESECI");
            Map(x => x.PosebneKlauzule).Column("POSEBNE_KLAUZULE");
        }
    }
}
