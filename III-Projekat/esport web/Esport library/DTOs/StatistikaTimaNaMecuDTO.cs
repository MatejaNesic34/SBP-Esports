namespace ESPORT
{
    public class StatistikaTimaNaMecuDTO
    {
        public int StatistikaId { get; set; }
        public int MecId { get; set; }
        public int TimId { get; set; }
        public string NazivTima { get; set; }
        public int OsvojeneRunde { get; set; }
        public int UkupnoZlato { get; set; }
        public int BrojUbijenihCiljeva { get; set; }
        public bool PobednikMeca { get; set; }

        public StatistikaTimaNaMecuDTO() { }

        public StatistikaTimaNaMecuDTO(int statistikaId, int mecId, int timId, string nazivTima, int osvojeneRunde, int ukupnoZlato, int brojUbijenihCiljeva, bool pobednikMeca)
        {
            StatistikaId = statistikaId;
            MecId = mecId;
            TimId = timId;
            NazivTima = nazivTima;
            OsvojeneRunde = osvojeneRunde;
            UkupnoZlato = ukupnoZlato;
            BrojUbijenihCiljeva = brojUbijenihCiljeva;
            PobednikMeca = pobednikMeca;
        }
    }
}