using System;

namespace ESPORT
{
    public class PozajmicaDTO
    {
        public int PozajmicaId { get; set; }
        public int IgracId { get; set; }
        public string Igrac { get; set; }
        public int MaticniTimId { get; set; }
        public string MaticniTim { get; set; }
        public int TimNaPozajmiciId { get; set; }
        public string TimNaPozajmici { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string FinansijskiUslovi { get; set; }
        public int PravoOtkupa { get; set; }

        public PozajmicaDTO()
        {
        }

        public PozajmicaDTO(
            int pozajmicaId,
            int igracId,
            string igrac,
            int maticniTimId,
            string maticniTim,
            int timNaPozajmiciId,
            string timNaPozajmici,
            DateTime datumOd,
            DateTime datumDo,
            string finansijskiUslovi,
            int pravoOtkupa)
        {
            PozajmicaId = pozajmicaId;
            IgracId = igracId;
            Igrac = igrac;
            MaticniTimId = maticniTimId;
            MaticniTim = maticniTim;
            TimNaPozajmiciId = timNaPozajmiciId;
            TimNaPozajmici = timNaPozajmici;
            DatumOd = datumOd;
            DatumDo = datumDo;
            FinansijskiUslovi = finansijskiUslovi;
            PravoOtkupa = pravoOtkupa;
        }
    }
}