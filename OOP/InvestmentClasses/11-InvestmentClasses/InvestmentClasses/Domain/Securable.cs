namespace InvestmentClasses.Domain
{
    public class Securable
    {
        public string Ticker { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var otherSecurable = obj as Securable;
            if(otherSecurable == null)
            {
                return false;
            }

            return (Ticker == otherSecurable.Ticker) &&
                   (Name == otherSecurable.Name);
        }

        public override int GetHashCode()
        {
            int hash = 27;

            hash = (13 * hash) + (Ticker ?? "").GetHashCode();
            hash = (13 * hash) + (Name ?? "").GetHashCode();

            return hash;
        }

        public static bool operator ==(Securable v1, Securable v2)
        {
            return v1.Equals(v2);
        }

        public static bool operator !=(Securable v1, Securable v2)
        {
            return !v1.Equals(v2);
        }
    }
}
