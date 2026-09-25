using ESPORT.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ESPORT.Mapiranje
{
    public class LigaMap : SubclassMap<Liga>
    {
        public LigaMap()
        {
            Table("LIGA");

            KeyColumn("TAKMICENJE_ID");

            Map(x => x.SistemBodovanja).Column("SISTEM_BODOVANJA").Not.Nullable();
        }
    }

}
