using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class TakmicenjeMap : ClassMap<Takmicenje>
    {
        public TakmicenjeMap()
        {
            Table("TAKMICENJE");

            // Primarni ključ
            Id(x => x.TakmicenjeId).Column("TAKMICENJE_ID").GeneratedBy.TriggerIdentity();

            // Obična polja / atributi
            Map(x => x.Naziv).Column("NAZIV").Not.Nullable();
            Map(x => x.Organizator).Column("ORGANIZATOR").Not.Nullable();
            Map(x => x.TipTakmicenja).Column("TIP_TAKMICENJA").Not.Nullable();
            Map(x => x.Region).Column("REGION").Nullable();
            Map(x => x.Lokacija).Column("LOKACIJA").Nullable();
            Map(x => x.FormatTakmicenja).Column("FORMAT_TAKMICENJA").Nullable();
            Map(x => x.DatumPocetka).Column("DATUM_POCETKA").Not.Nullable();
            Map(x => x.DatumZavrsetka).Column("DATUM_ZAVRSETKA").Not.Nullable();
            Map(x => x.NagradniFond).Column("NAGRADNI_FOND").Nullable();
            Map(x => x.ValutaNagrade).Column("VALUTA_NAGRADE").Nullable();
            Map(x => x.Status).Column("STATUS").Nullable();

            // ----------------------------------------------------
            // RELACIJA (Many-to-One)
            // ----------------------------------------------------

            // Strani ključ ka Igra (IGRA_ID)
            References(x => x.Igra)
                .Column("IGRA_ID")
                .Not.Nullable()
                .LazyLoad();

            // ----------------------------------------------------
            // VEZE / KOLEKCIJE (One-to-Many)
            // ----------------------------------------------------

            // 1. Mecevi
            HasMany(x => x.Mecevi)
                .KeyColumn("TAKMICENJE_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            // 2. IndividualnaPriznanja (IndividualniRezultat)
            HasMany(x => x.IndividualnaPriznanja)
                .KeyColumn("TAKMICENJE_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            // 3. SponzorskiUgovoriKaoSubjekat
            HasMany(x => x.SponzorskiUgovoriKaoSubjekat)
                .KeyColumn("TAKMICENJE_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();
        }
    }
}
