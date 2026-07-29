using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class TurnirMap : ClassMap<Turnir>
    {
        public TurnirMap()
        {
            Table("TURNIR");
            Map(x => x.TakmicenjeId).Column("TAKMICENJE_ID");
            Map(x => x.TipKostura).Column("TIP_KOSTURA");
            Map(x => x.PravilaNapredovanja).Column("PRAVILA_NAPREDOVANJA");
            Map(x => x.BrojMecevaPoRundi).Column("BROJ_MECEVA_PO_RUNDI");
        }
    }
}
