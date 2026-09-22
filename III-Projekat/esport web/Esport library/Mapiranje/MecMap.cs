using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class MecMap : ClassMap<Mec>
    {
        public MecMap()
        {
            Table("MEC");

            // Primarni ključ
            Id(x => x.MecId).Column("MEC_ID").GeneratedBy.Increment();

            // Obična polja / atributi
            Map(x => x.RedniBroj).Column("REDNI_BROJ").Not.Nullable();
            Map(x => x.DatumVremePocetka).Column("DATUM_VREME_POCETKA").Not.Nullable();
            Map(x => x.FormatMeca).Column("FORMAT_MECA").Not.Nullable();
            Map(x => x.BrojOdigranihMapa).Column("BROJ_ODIGRANIH_MAPA").Not.Nullable();
            Map(x => x.Rezultat).Column("REZULTAT").Nullable();
            Map(x => x.Trajanje).Column("TRAJANJE").Nullable();
            Map(x => x.LokacijaIgranja).Column("LOKACIJA_IGRANJA").Nullable();
            Map(x => x.Sudije).Column("SUDIJE").Nullable();
            Map(x => x.StatusMeca).Column("STATUS_MECA").Nullable();

            // ----------------------------------------------------
            // RELACIJE (Many-to-One)
            // ----------------------------------------------------

            // Strani ključ ka Takmicenje (TAKMICENJE_ID)
            References(x => x.Takmicenje)
                .Column("TAKMICENJE_ID")
                .Not.Nullable()
                .LazyLoad();

            // ----------------------------------------------------
            // VEZE / KOLEKCIJE (One-to-Many)
            // ----------------------------------------------------

            // 1. StatistikeTimova (StatistikaTimaNaMecu)
            HasMany(x => x.StatistikeTimova)
                .KeyColumn("MEC_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            // 2. Dogadjaji (DogadjajNaMecu)
            HasMany(x => x.Dogadjaji)
                .KeyColumn("MEC_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();
        }
    }
}
