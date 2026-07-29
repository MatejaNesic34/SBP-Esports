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
            Map(x => x.LicencaId).Column("LICENCAID");
            Map(x => x.Osoba).Column("OSOBAID");
            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.InstitucijaIzdavac).Column("INSTITUCIJA_IZDAVAC");
            Map(x => x.DatumSticanja).Column("DATUM_STICANJA");
        }
    }
}
