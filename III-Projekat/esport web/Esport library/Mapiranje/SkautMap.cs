using ESPORT.Entiteti;
using FluentNHibernate.Mapping;
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

            KeyColumn("OSOBAID");

            References(x => x.Igra)
                .Column("IDIGRE")
                .Nullable()
                .LazyLoad();
        }
    }
}
