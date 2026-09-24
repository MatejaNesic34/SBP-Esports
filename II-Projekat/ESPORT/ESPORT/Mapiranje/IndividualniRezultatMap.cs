using ESPORT.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class IndividualniRezultatMap : ClassMap<IndividualniRezultat>
    {
        public IndividualniRezultatMap()
        {
            Table("INDIVIDUALNI_REZULTAT");

            Id(x => x.RezultatId).Column("REZULTAT_ID").GeneratedBy.Increment();

            Map(x => x.NazivPriznanja).Column("NAZIV_PRIZNANJA").Not.Nullable();
            Map(x => x.DatumOstvarivanja).Column("DATUM_OSTVARIVANJA").Nullable();
            Map(x => x.Opis).Column("OPIS").Nullable();

            
            References(x => x.Igrac)
                .Column("IGRAC_ID")
                .Not.Nullable()
                .LazyLoad();

            References(x => x.Takmicenje)
                .Column("TAKMICENJE_ID")
                .Nullable()
                .LazyLoad();
        }
    }
}
