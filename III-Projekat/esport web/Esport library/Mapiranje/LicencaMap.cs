using ESPORT.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class LicencaMap : ClassMap<Licenca>
    {
        public LicencaMap()
        {
            Table("LICENCA");

            // Primarni ključ
            Id(x => x.LicencaId).Column("LICENCAID").GeneratedBy.TriggerIdentity();

            // Obična polja / atributi
            Map(x => x.Naziv).Column("NAZIV").Not.Nullable();
            Map(x => x.InstitucijaIzdavac).Column("INSTITUCIJA_IZDAVAC").Not.Nullable();
            Map(x => x.DatumSticanja).Column("DATUM_STICANJA").Not.Nullable();

            // ----------------------------------------------------
            // RELACIJA (Many-to-One)
            // ----------------------------------------------------

            // Povezivanje sa klasom Osoba preko stranog ključa OSOBAID
            References(x => x.OsobaId)
                .Column("OSOBAID")
                .Not.Nullable()
                .LazyLoad();
        }
    }
}
