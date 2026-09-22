using System;

namespace ESPORT
{
    public class TransferDTO
    {
        public int TransferId { get; set; }
        public int IgracId { get; set; }
        public string Igrac { get; set; }
        public int? PrethodniTimId { get; set; }
        public string PrethodniTim { get; set; }
        public int NoviTimId { get; set; }
        public string NoviTim { get; set; }
        public DateTime DatumPrelaska { get; set; }
        public decimal IznosTransfera { get; set; }
        public string Valuta { get; set; }
        public int? TrajanjeUgovoraMeseci { get; set; }
        public string PosebneKlauzule { get; set; }

        public TransferDTO()
        {
        }

        public TransferDTO(
            int transferId,
            int igracId,
            string igrac,
            int? prethodniTimId,
            string prethodniTim,
            int noviTimId,
            string noviTim,
            DateTime datumPrelaska,
            decimal iznosTransfera,
            string valuta,
            int? trajanjeUgovoraMeseci,
            string posebneKlauzule)
        {
            TransferId = transferId;
            IgracId = igracId;
            Igrac = igrac;
            PrethodniTimId = prethodniTimId;
            PrethodniTim = prethodniTim;
            NoviTimId = noviTimId;
            NoviTim = noviTim;
            DatumPrelaska = datumPrelaska;
            IznosTransfera = iznosTransfera;
            Valuta = valuta;
            TrajanjeUgovoraMeseci = trajanjeUgovoraMeseci;
            PosebneKlauzule = posebneKlauzule;
        }
    }
}