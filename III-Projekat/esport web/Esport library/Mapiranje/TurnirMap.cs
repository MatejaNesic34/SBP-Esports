using ESPORT.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ESPORT.Mapiranje
{
    public class TurnirMap : SubclassMap<Turnir>
    {
        public TurnirMap()
        {
            Table("TURNIR");

            KeyColumn("TAKMICENJE_ID");

            Map(x => x.TipKostura).Column("TIP_KOSTURA").Not.Nullable();
            Map(x => x.PravilaNapredovanja).Column("PRAVILA_NAPREDOVANJA").Nullable();
            Map(x => x.BrojMecevaPoRundi).Column("BROJ_MECEVA_PO_RUNDI").Nullable();

           
            HasMany(x => x.Faze)
                .KeyColumn("TAKMICENJE_ID") 
                .LazyLoad()
                .Cascade.All()
                .Inverse();
        }
    }
}
