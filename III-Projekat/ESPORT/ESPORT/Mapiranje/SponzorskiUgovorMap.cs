using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class SponzorskiUgovorMap : ClassMap<SponzorskiUgovor>
    {
        public SponzorskiUgovorMap()
        {
            Table("SPONZORSKI_UGOVOR");

            // Primarni ključ
            Id(x => x.UgovorId).Column("UGOVOR_ID").GeneratedBy.TriggerIdentity();

            // Obična polja / atributi
            Map(x => x.DatumOd).Column("DATUM_OD").Not.Nullable();
            Map(x => x.DatumDo).Column("DATUM_DO").Not.Nullable();
            Map(x => x.Iznos).Column("IZNOS").Not.Nullable();
            Map(x => x.Valuta).Column("VALUTA").Nullable();
            Map(x => x.TipPodrske).Column("TIP_PODRSKE").Not.Nullable();
            Map(x => x.MarketinskeObaveze).Column("MARKETINSKE_OBAVEZE").Nullable();

            // ----------------------------------------------------
            // RELACIJE (Many-to-One)
            // ----------------------------------------------------

            // Strani ključ ka Sponzor (SPONZOR_ID)
            References(x => x.Sponzor)
                .Column("SPONZOR_ID")
                .Not.Nullable()
                .LazyLoad();

            // ----------------------------------------------------
            // RELACIJE (One-to-One / HasOne)
            // ----------------------------------------------------

            // Relacija ka UgovorSubjekat
            HasOne(x => x.Subjekat)
                .PropertyRef(x => x.Ugovor)
                .Cascade.All();
        }
    }
}
