using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class Telefon
    {
        public virtual Osoba OsobaId { get; set; }
        public virtual string BrojTelefona {  get; set; }



        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as Telefon;
            if (t == null) return false;

            if (OsobaId == null || t.OsobaId == null) return false;

            return OsobaId.OsobaId == t.OsobaId.OsobaId && BrojTelefona == t.BrojTelefona;
        }

        public override int GetHashCode()
        {
            return (OsobaId != null ? OsobaId.OsobaId.GetHashCode() : 0) ^ 
                   (BrojTelefona != null ? BrojTelefona.GetHashCode() : 0);
        }
    }
}
