using ESPORT.Entiteti;
using FluentNHibernate.Mapping;
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

            CompositeId()
                .KeyReference(x => x.FazaId, "FAZA_ID")
                .KeyReference(x => x.TimId, "TIM_ID");

            Map(x => x.Status).Column("STATUS").Nullable();
            Map(x => x.OstvareniRezultat).Column("OSTVARENI_REZULTAT").Nullable();
            Map(x => x.BrojPobeda).Column("BROJ_POBEDA").Not.Nullable();
            Map(x => x.BrojPoraza).Column("BROJ_PORAZA").Not.Nullable();
            Map(x => x.OsvojeniBodovi).Column("OSVOJENI_BODOVI").Not.Nullable();
            Map(x => x.KonacanPlasman).Column("KONACAN_PLASMAN").Nullable();
        }
    }
}
