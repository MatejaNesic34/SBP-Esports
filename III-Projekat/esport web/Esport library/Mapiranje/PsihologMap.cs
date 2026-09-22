using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ESPORT.Entiteti;

namespace ESPORT.Mapiranje
{
    public class PsihologMap : SubclassMap<Psiholog>
    {
        public PsihologMap()
        {
            Table("PSIHOLOG");

            // Primarni ključ koji je ujedno strani ključ ka tabeli OSOBA
            KeyColumn("OSOBAID");

            // Specifična polja za Psihologa
            Map(x => x.OblastRada).Column("OBLAST_RADA").Nullable();
            Map(x => x.PeriodiDostupnosti).Column("PERIODI_DOSTUPNOSTI").Nullable();
        }
    }
}
