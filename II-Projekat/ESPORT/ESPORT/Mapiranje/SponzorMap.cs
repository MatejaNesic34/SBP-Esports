using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class SponzorMap : ClassMap<Sponzor>
    {
        public SponzorMap()
        {
            Table("SPONZOR");
            Id(x => x.SponzorId).Column("SPONZOR_ID").GeneratedBy.Sequence("SPONZOR_SEQ");
            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.Drzava).Column("DRZAVA");
            Map(x => x.TipSponzora).Column("TIP_SPONZORA");
            Map(x => x.OblastPoslovanja).Column("OBLAST_POSLOVANJA");
        }
    }
}
