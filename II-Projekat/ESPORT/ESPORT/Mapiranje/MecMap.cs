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
            Id(x => x.MecId).Column("MEC_ID").GeneratedBy.Sequence("MEC_SEQ");
            Map(x => x.Takmicenje).Column("TAKMICENJE_ID");
            Map(x => x.RedniBroj).Column("REDNI_BROJ");
            Map(x => x.DatumVremePocetka).Column("DATUM_VREME_POCETKA");
            Map(x => x.FormatMeca).Column("FORMAT_MECA");
            Map(x => x.BrojOdigranihMapa).Column("BROJ_ODIGRANIH_MAPA");
            Map(x => x.Rezultat).Column("REZULTAT");
            Map(x => x.Trajanje).Column("TRAJANJE");
            Map(x => x.LokacijaIgranja).Column("LOKACIJA_IGRANJA");
            Map(x => x.Sudije).Column("SUDIJE");
            Map(x => x.StatusMeca).Column("STATUS_MECA");
        }
    }
}
