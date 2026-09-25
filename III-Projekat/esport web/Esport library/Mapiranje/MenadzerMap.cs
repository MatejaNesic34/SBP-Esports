using ESPORT.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ESPORT.Mapiranje
{
    public class MenadzerMap : SubclassMap<Menadzer>
    {
        public MenadzerMap()
        {
            Table("MENADZER");

            KeyColumn("OSOBAID");

            Map(x => x.OblastOdgovornosti).Column("OBLAST_ODGOVORNOSTI").Nullable();
        }
    }
}
