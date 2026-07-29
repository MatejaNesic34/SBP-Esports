using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Mapiranje
{
    public class UcesceTimaUFaziMap : ClassMap<UcesceTimaUFazi>
    {
        public UcesceTimaUFaziMap()
        {
            Table("UCESCE_TIMA_U_FAZI");
            Map(x => x.FazaId).Column("FAZA_ID");
            Map(x => x.TimId).Column("TIM_ID");
            Map(x => x.Status).Column("STATUS");
            Map(x => x.OstvareniRezultat).Column("OSTVARENI_REZULTAT");
            Map(x => x.BrojPobeda).Column("BROJ_POBEDA");
            Map(x => x.BrojPoraza).Column("BROJ_PORAZA");
            Map(x => x.OsvojeniBodovi).Column("OSVOJENI_BODOVI");
            Map(x => x.KonacanPlasman).Column("KONACAN_PLASMAN");
        }
    }
}
