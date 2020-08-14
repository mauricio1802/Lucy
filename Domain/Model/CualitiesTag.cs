namespace Domain.Model
{
    public class CualitiesTag
    {
        private int id;
        private string tagValue;
        

        // Id porperty
        public int Id => id;
        // TagValue porperty
        public string TagValue => tagValue;

        // override GetHashCode
        public override int GetHashCode()
        {
            var hashcode = 352033288;
            hashcode = hashcode * -1524434295 + this.id.GetHashCode();
            hashcode = hashcode * -1524434295 + this.tagValue.GetHashCode();
            return hashcode;
        }

        // override Equals
        public override bool Equals(object obj)
        {   
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return this.id.Equals((obj as CualitiesTag).id) && this.tagValue.Equals((obj as CualitiesTag).tagValue);
        }

        // Empty constructor
        public CualitiesTag()
        {
            

        }

        // Parameters constructor
        public CualitiesTag(int _id, string _tagValue)
        {
            this.id = _id;
            this.tagValue = _tagValue;
        }
    }
}