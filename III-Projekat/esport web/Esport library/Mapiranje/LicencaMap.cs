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

            Id(x => x.LicencaId).Column("LICENCAID").GeneratedBy.Increment();
            Map(x => x.Naziv).Column("NAZIV").Not.Nullable();
            Map(x => x.InstitucijaIzdavac).Column("INSTITUCIJA_IZDAVAC").Not.Nullable();
            Map(x => x.DatumSticanja).Column("DATUM_STICANJA").Not.Nullable();

            References(x => x.OsobaId)
                .Column("OSOBAID")
                .Not.Nullable()
                .LazyLoad();
        }
    }
}
