namespace Domain.Model
{
    public class DispatcherServices
    {
        private int id;
        private int idWorker;
        private int idCategory;
        private int priorityPoints;


        // Id property
        public int Id => id;
        // IdWorker property
        public int IdWorker => idWorker;
        // IdCategory property
        public int IdCategory => idCategory;
        // PriorityPoints
        public int PriorityPoints => priorityPoints;

        // empty  constructor
        public DispatcherServices()
        {
            
        }

        // paramters constructor
        public DispatcherServices(int _id,int _idWorker, int _idCategory, int _priorityPoints)
        {
            this.id = _id;
            this.priorityPoints = _priorityPoints;
            this.idWorker = _idWorker;
            this.idCategory = _idCategory;
        }

        // overrides GetHashCode
        public override int GetHashCode()
        {
            var hashcode = 352033288;
            hashcode = hashcode * -1524434295 + this.id.GetHashCode();
            hashcode = hashcode * -1524434295 + this.priorityPoints.GetHashCode();
            hashcode = hashcode * -1524434295 + this.idWorker.GetHashCode();
            hashcode = hashcode * -1524434295 + this.idCategory.GetHashCode();
            return hashcode;
        }

        // overrides Equals
        public override bool Equals(object obj)
        {
             if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return this.id.Equals((obj as DispatcherServices).id) &&
                   this.idCategory.Equals((obj as DispatcherServices).idCategory) &&
                   this.idWorker.Equals((obj as DispatcherServices).idWorker) &&
                   this.priorityPoints.Equals((obj as DispatcherServices).priorityPoints);
        }


    }
}