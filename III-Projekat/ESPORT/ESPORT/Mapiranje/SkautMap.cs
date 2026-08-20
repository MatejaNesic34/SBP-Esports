using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class SkautMap : SubclassMap<Skaut>
    {
        public SkautMap()
        {
            Table("SKAUT");

            // Primarni ključ koji je ujedno i strani ključ ka tabeli OSOBA
            KeyColumn("OSOBAID");

            // ----------------------------------------------------
            // RELACIJE (Many-to-One)
            // ----------------------------------------------------

            // Strani ključ ka Igra (IDIGRE) - opcioni (ON DELETE SET NULL)
            References(x => x.Igra)
                .Column("IDIGRE")
                .Nullable()
                .LazyLoad();
        }
    }
}
