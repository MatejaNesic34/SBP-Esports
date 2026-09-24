using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class Turnir : Takmicenje
    {
        public virtual string TipKostura { get; set; }
        public virtual string PravilaNapredovanja { get; set; }
        public virtual string BrojMecevaPoRundi { get; set; }

        public virtual IList<FazaTakmicenja> Faze { get; set; } = new List<FazaTakmicenja>();
    }
}
