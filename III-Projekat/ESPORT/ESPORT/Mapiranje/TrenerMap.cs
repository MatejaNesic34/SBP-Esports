using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class TrenerMap : SubclassMap<Trener>
    {
        public TrenerMap()
        {
            Table("TRENER");

            // Povezivanje sa roditeljskom tabelom (Osoba) preko primarnog/stranog ključa
            KeyColumn("OSOBAID");

            // Specifična polja za trenera
            Map(x => x.TipUloge).Column("TIP_ULOGE").Nullable();
            Map(x => x.StilRada).Column("STIL_RADA").Nullable();

            // ----------------------------------------------------
            // VEZE / KOLEKCIJE (One-to-Many za Trenera)
            // ----------------------------------------------------

            // 1. AngazmaniTrenera
            HasMany(x => x.AngazmaniTrenera)
                .KeyColumn("TRENERID") // ili OSOBAID, u zavisnosti od naziva FK u tabeli ANGAZMAN_TRENERA
                .LazyLoad()
                .Cascade.All()
                .Inverse();
        }
    }
}
