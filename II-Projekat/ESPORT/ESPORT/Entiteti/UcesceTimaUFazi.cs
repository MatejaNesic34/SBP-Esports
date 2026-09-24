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
        public virtual int? KonacanPlasman { get; set; } 

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

}