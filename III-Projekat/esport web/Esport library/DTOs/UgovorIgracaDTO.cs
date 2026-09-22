using System;

namespace ESPORT
{
    public class UgovorIgracaDTO
    {
        public int UgovorId { get; set; }
        public int IgracId { get; set; }
        public string ImePrezimeIgraca { get; set; }
        public int TimId { get; set; }
        public string NazivTima { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public string TipUgovora { get; set; }
        public decimal Plata { get; set; }
        public decimal Bonusi { get; set; }
        public decimal? KlauzulaOtkup { get; set; }
        public string ZabranaNastupa { get; set; }
        public string StatusIgraca { get; set; }

        public UgovorIgracaDTO() { }

        public UgovorIgracaDTO(int ugovorId, int igracId, string imePrezimeIgraca, int timId, string nazivTima,
                                 DateTime datumOd, DateTime? datumDo, string tipUgovora, decimal plata,
                                 decimal bonusi, decimal? klauzulaOtkup, string zabranaNastupa, string statusIgraca)
        {
            UgovorId = ugovorId;
            IgracId = igracId;
            ImePrezimeIgraca = imePrezimeIgraca;
            TimId = timId;
            NazivTima = nazivTima;
            DatumOd = datumOd;
            DatumDo = datumDo;
            TipUgovora = tipUgovora;
            Plata = plata;
            Bonusi = bonusi;
            KlauzulaOtkup = klauzulaOtkup;
            ZabranaNastupa = zabranaNastupa;
            StatusIgraca = statusIgraca;
        }
    }
}