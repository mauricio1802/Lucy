namespace Domain.Model
{
    public class Portfolio
    {
        // this entity hasn't any primary key
        private int idImage;
        private int idDispatcherServices;
        public int IdImage => idImage;
        public int IdDispatcherServices => idDispatcherServices;
        

        // overrides GetHashCode
        public override int GetHashCode()
        {
            var hashcode = 352033288;
            hashcode = hashcode * -1524434295 + this.idImage.GetHashCode();
            hashcode = hashcode * -1524434295 + this.idDispatcherServices.GetHashCode();
            return hashcode;
        }


        // overrides Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return this.idImage.Equals((obj as Portfolio).idImage) &&
                   this.idDispatcherServices.Equals((obj as Portfolio).idDispatcherServices);
        }

        // empty constructor
        public Portfolio()
        {
            
        }
        // parameters constructor
        public Portfolio(int _idImage, int _idDispatcherServices)
        {
            this.idImage = _idImage;
            this.idDispatcherServices=_idDispatcherServices;
        }


    }
}