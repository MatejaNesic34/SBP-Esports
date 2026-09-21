using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ESPORT.Entiteti;

namespace ESPORT.Mapiranja
{
    public class TelefonMap : ClassMap<Telefon>
    {
        public TelefonMap()
        {
            Table("OSOBA_TELEFON");

            // Definisanjem kompozitnog primarnog ključa (osobaid + telefon)
            CompositeId()
                .KeyReference(x => x.OsobaId, "OSOBAID")
                .KeyProperty(x => x.BrojTelefona, "TELEFON");
        }
    }
}