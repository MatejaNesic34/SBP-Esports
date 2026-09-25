using ESPORT.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ESPORT.Mapiranje
{
    public class PsihologMap : SubclassMap<Psiholog>
    {
        public PsihologMap()
        {
            Table("PSIHOLOG");

            KeyColumn("OSOBAID");

            Map(x => x.OblastRada).Column("OBLAST_RADA").Nullable();
            Map(x => x.PeriodiDostupnosti).Column("PERIODI_DOSTUPNOSTI").Nullable();
        }
    }
}
