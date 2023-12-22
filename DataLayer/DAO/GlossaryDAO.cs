namespace DataLayer.DAO
{
    public class GlossaryDAO
    {
        public string Term { get; set; }
        public string Definition { get; set; }
        public GlossaryDAO(string term, string definition)
        {
            Term = term;
            Definition = definition;
        }

        public GlossaryDAO()
        {
        }
    }
    public class CreateGlossaryDAO
    {
        public int TermID { get; set; }
        public string Term { get; set; }
        public string Definition { get; set; }
        public CreateGlossaryDAO(int termID, string term, string definition)
        {
            TermID = termID;
            Term = term;
            Definition = definition;
        }
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((GlossaryDAO)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = (Term != null ? Term.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Definition != null ? Definition.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
