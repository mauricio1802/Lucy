namespace Domain.Model
{
    public class Rewards
    {
        private int id;
        private bool value;
        private int idCualitiesTag;
        private int idDispatcherServices;

        // Id property
        public int Id => id;
        // Value property
        public bool Value => value;
        // IdCualitiesTag property
        public int IdCualitiesTag => idCualitiesTag;
        // IdDispatcherServices property
        public int IdDispatcherServices =>  idDispatcherServices;
        
        // empty constructor
        public Rewards()
        {
            
        }

        // parameters constructor
        public Rewards(int _id, bool _value,int _idCualititiesTag,int _idDispatcherServices)
        {
            this.id = _id;
            this.value = _value;
            this.idCualitiesTag = _idCualititiesTag;
            this.idDispatcherServices = _idDispatcherServices;
        }

        // override Equals
        public override bool Equals(object obj)
        {
             if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return this.id.Equals((obj as Rewards).id) &&
                   this.value.Equals((obj as Rewards).value) &&
                   this.idCualitiesTag.Equals((obj as Rewards).idCualitiesTag) &&
                   this.idDispatcherServices.Equals((obj as Rewards).idDispatcherServices);                   
        
        }

        // overrides GetHashCode
        public override int GetHashCode()
        {
            var hashcode = 352033288;
            hashcode = hashcode * -1524434295 + this.id.GetHashCode();
            hashcode = hashcode * -1524434295 + this.idCualitiesTag.GetHashCode();
            hashcode = hashcode * -1524434295 + this.value.GetHashCode();
            hashcode = hashcode * -1524434295 + this.idDispatcherServices.GetHashCode();
            return hashcode;
        }

    }
}