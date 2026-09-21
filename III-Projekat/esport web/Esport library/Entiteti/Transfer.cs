using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class Transfer
    {
        public virtual int TransferId { get; set; }
        public virtual Igrac Igrac { get; set; }
        public virtual Tim PrethodniTim { get; set; }
        public virtual Tim NoviTim { get; set; }
        public virtual DateTime DatumPrelaska { get; set; }
        public virtual decimal IznosTransfera { get; set; }
        public virtual string Valuta { get; set; }
        public virtual int? TrajanjeUgovoraMeseci { get; set; }
        public virtual string PosebneKlauzule { get; set; }
    }
}
