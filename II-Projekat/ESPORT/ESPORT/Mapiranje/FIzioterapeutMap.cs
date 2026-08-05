using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class FizioterapeutMap : SubclassMap<Fizioterapeut>
    {
        public FizioterapeutMap()
        {
            Table("FIZIOTERAPEUT");

            // Primarni ključ koji je ujedno strani ključ ka tabeli OSOBA
            KeyColumn("OSOBAID");

            // Specifična polja za Fizioterapeuta
            Map(x => x.OblastRada).Column("OBLAST_RADA").Nullable();
            Map(x => x.PeriodiDostupnosti).Column("PERIODI_DOSTUPNOSTI").Nullable();
        }
    }
}
