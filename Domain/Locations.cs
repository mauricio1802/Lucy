namespace Domain
{
    public class Locations
    {
        private int id;
        private string province;
        private string municipality;
        private string neighborhood;

        // Id property
        public int Id => id;
        // Province property
        public string Province => province;
        // Municipality property
        public string Municipality => municipality;
        // Neighborhood property
        public string Neighborhood => neighborhood;

        // empty constructor
        public Locations()
        {
            
        }

        // parameters constructor
        public Locations(int _id,string _province,string _municipality,string neighborhood=null)
        {
            this.id = _id;
            this.province = _province;
            this.municipality = _municipality;
            this.neighborhood = neighborhood;
        }

        // overrides Equals
        public override  bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return this.id.Equals((obj as Locations).id) &&
                   this.province.Equals((obj as Locations).province) &&
                   this.municipality.Equals((obj as Locations).municipality) &&
                   (this.neighborhood!=null && (obj as Locations).neighborhood!=null) ? this.neighborhood.Equals((obj as Locations).neighborhood) : false;                   

        }

        // overrides GetHasCode
        public override int GetHashCode()
        {
            var hashcode = 352033288;
            hashcode = hashcode * -1524434295 + this.id.GetHashCode();
            hashcode = hashcode * -1524434295 + this.municipality.GetHashCode();
            hashcode = hashcode * -1524434295 + this.province.GetHashCode();
            return hashcode;
        }

    }
}