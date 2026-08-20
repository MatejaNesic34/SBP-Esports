namespace ESPORT.Entiteti
{


    public class UcesceTimaUFazi
    {
        public virtual FazaTakmicenja FazaId { get; set; }
        public virtual Tim TimId { get; set; }
        public virtual string Status { get; set; }
        public virtual string OstvareniRezultat { get; set; }
        public virtual int BrojPobeda { get; set; }
        public virtual int BrojPoraza { get; set; }
        public virtual int OsvojeniBodovi { get; set; }
        public virtual int? KonacanPlasman { get; set; } // Opciono jer u bazi nema NOT NULL

        // Neophodno za NHibernate kompozitne ključeve
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var u = obj as UcesceTimaUFazi;
            if (u == null) return false;

            if (FazaId == null || u.FazaId == null || TimId == null || u.TimId == null) return false;

            return FazaId.FazaId == u.FazaId.FazaId && TimId.TimId == u.TimId.TimId;
        }

        public override int GetHashCode()
        {
            return (FazaId != null ? FazaId.FazaId.GetHashCode() : 0) ^
                   (TimId != null ? TimId.TimId.GetHashCode() : 0);
        }
    }

    //public class UcesceTimaUFazi
    //{
    //    public virtual UcesceTimaUFaziId Id { get; set; }
    //    public virtual string Status { get; set; }
    //    public virtual string OstvareniRezultat { get; set; }
    //    public virtual int BrojPobeda { get; set; }
    //    public virtual int BrojPoraza { get; set; }
    //    public virtual int OsvojeniBodovi { get; set; }
    //    public virtual int? KonacanPlasman { get; set; }
    //}

    //public class UcesceTimaUFaziId
    //{
    //    public virtual FazaTakmicenja Faza { get; set; }
    //    public virtual Tim Tim { get; set; }

    //    public override bool Equals(object obj)
    //    {
    //        if (obj is UcesceTimaUFaziId other)
    //            return Faza?.FazaId == other.Faza?.FazaId && Tim?.TimId == other.Tim?.TimId;
    //        return false;
    //    }
    //    public override int GetHashCode() => HashCode.Combine(Faza?.FazaId, Tim?.TimId);
    //}
}