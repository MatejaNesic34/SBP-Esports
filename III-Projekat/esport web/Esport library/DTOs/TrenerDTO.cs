using System;

namespace ESPORT
{
    public class TrenerDTO
    {
        public int OsobaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Nadimak { get; set; }
        public string TipUloge { get; set; }
        public string StilRada { get; set; }
        public string StatusAngazmana { get; set; }

        public TrenerDTO() { }

        public TrenerDTO(int id, string ime, string prezime, string nadimak, string tipUloge, string stilRada, string status)
        {
            this.OsobaId = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Nadimak = nadimak;
            this.TipUloge = tipUloge;
            this.StilRada = stilRada;
            this.StatusAngazmana = status;
        }
    }
}