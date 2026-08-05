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

            // Primarni ključ
            Id(x => x.TransferId).Column("TRANSFER_ID").GeneratedBy.TriggerIdentity();

            // Obična polja / atributi
            Map(x => x.DatumPrelaska).Column("DATUM_PRELASKA").Not.Nullable();
            Map(x => x.IznosTransfera).Column("IZNOS_TRANSFERA").Not.Nullable();
            Map(x => x.Valuta).Column("VALUTA").Nullable();
            Map(x => x.TrajanjeUgovoraMeseci).Column("TRAJANJE_UGOVORA_MESECI").Nullable();
            Map(x => x.PosebneKlauzule).Column("POSEBNE_KLAUZULE").Nullable();

            // ----------------------------------------------------
            // RELACIJE (Many-to-One)
            // ----------------------------------------------------

            // Strani ključ ka Igrac (IGRAC_ID)
            References(x => x.Igrac)
                .Column("IGRAC_ID")
                .Not.Nullable()
                .LazyLoad();

            // Strani ključ ka Tim - Prethodni tim (PRETHODNI_TIM_ID) - Može biti null
            References(x => x.PrethodniTim)
                .Column("PRETHODNI_TIM_ID")
                .Nullable()
                .LazyLoad();

            // Strani ključ ka Tim - Novi tim (NOVI_TIM_ID)
            References(x => x.NoviTim)
                .Column("NOVI_TIM_ID")
                .Not.Nullable()
                .LazyLoad();
        }
    }
}
