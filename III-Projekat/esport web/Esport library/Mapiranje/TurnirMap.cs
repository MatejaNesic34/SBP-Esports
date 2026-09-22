using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPORT.Entiteti;
using FluentNHibernate.Mapping;

namespace ESPORT.Mapiranje
{
    public class TurnirMap : SubclassMap<Turnir>
    {
        public TurnirMap()
        {
            Table("TURNIR");

            // Povezivanje sa roditeljskom tabelom (Takmicenje)
            KeyColumn("TAKMICENJE_ID");

            // Specifična polja za Turnir
            Map(x => x.TipKostura).Column("TIP_KOSTURA").Not.Nullable();
            Map(x => x.PravilaNapredovanja).Column("PRAVILA_NAPREDOVANJA").Nullable();
            Map(x => x.BrojMecevaPoRundi).Column("BROJ_MECEVA_PO_RUNDI").Nullable();

            // ----------------------------------------------------
            // VEZE / KOLEKCIJE (One-to-Many za Turnir)
            // ----------------------------------------------------

            // 1. Faze (FazaTakmicenja)
            HasMany(x => x.Faze)
                .KeyColumn("TAKMICENJE_ID") // ili TAKMICENJE_ID, u zavisnosti od naziva FK kolone u tabeli FAZA_TAKMICENJA
                .LazyLoad()
                .Cascade.All()
                .Inverse();
        }
    }
}
