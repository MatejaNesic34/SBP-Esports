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

            // Primarni ključ
            Id(x => x.RezultatId).Column("REZULTAT_ID").GeneratedBy.Increment();

            // Obična polja / atributi
            Map(x => x.NazivPriznanja).Column("NAZIV_PRIZNANJA").Not.Nullable();
            Map(x => x.DatumOstvarivanja).Column("DATUM_OSTVARIVANJA").Nullable();
            Map(x => x.Opis).Column("OPIS").Nullable();

            // ----------------------------------------------------
            // RELACIJE (Many-to-One)
            // ----------------------------------------------------

            // Strani ključ ka Igrac (IGRAC_ID)
            References(x => x.Igrac)
                .Column("IGRAC_ID")
                .Not.Nullable()
                .LazyLoad();

            // Strani ključ ka Takmicenje (TAKMICENJE_ID) - opcioni (ON DELETE SET NULL)
            References(x => x.Takmicenje)
                .Column("TAKMICENJE_ID")
                .Nullable()
                .LazyLoad();
        }
    }
}
