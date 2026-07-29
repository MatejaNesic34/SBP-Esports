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
            Id(x => x.TakmicenjeId).Column("TAKMICENJE_ID").GeneratedBy.Sequence("TAKMICENJE_SEQ");
            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.Organizator).Column("ORGANIZATOR");
            Map(x => x.TipTakmicenja).Column("TIP_TAKMICENJA");
            Map(x => x.Igra).Column("IGRA_ID");
            Map(x => x.Region).Column("REGION");
            Map(x => x.Lokacija).Column("LOKACIJA");
            Map(x => x.FormatTakmicenja).Column("FORMAT_TAKMICENJA");
            Map(x => x.DatumPocetka).Column("DATUM_POCETKA");
            Map(x => x.DatumZavrsetka).Column("DATUM_ZAVRSETKA");
            Map(x => x.NagradniFond).Column("NAGRADNI_FOND");
            Map(x => x.ValutaNagrade).Column("VALUTA_NAGRADE");
            Map(x => x.Status).Column("STATUS");
        }
    }
}
