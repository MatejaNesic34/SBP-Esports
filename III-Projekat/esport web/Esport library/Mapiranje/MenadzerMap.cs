using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ESPORT.Entiteti;

namespace ESPORT.Mapiranje
{
    public class MenadzerMap : SubclassMap<Menadzer>
    {
        public MenadzerMap()
        {
            Table("MENADZER");

            // Povezivanje sa roditeljskom tabelom (Osoba)
            KeyColumn("OSOBAID");

            // Specifično polje za menadžera
            Map(x => x.OblastOdgovornosti).Column("OBLAST_ODGOVORNOSTI").Nullable();
        }
    }
}
