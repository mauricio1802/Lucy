namespace Domain.Model
{
    public class OrderWork
    {
        private int id;
        private string orderWorkName;
        private int idState;
        private int idUserCustomer;
        private int idUserWorker;

        // Id property
        public int Id => id;
        // OrderWorkName property
        public string OrderWorkName => orderWorkName;
        // IdState property
        public int IdState => idState;
        // IdUserCustomer property
        public int IdUserCustomer => idUserCustomer;

        // override Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return this.id.Equals((obj as OrderWork).id) &&
                   this.idUserCustomer.Equals((obj as OrderWork).idUserCustomer) &&
                   this.idState.Equals((obj as OrderWork).idState) &&
                   this.orderWorkName.Equals((obj as OrderWork).orderWorkName) &&
                   this.idUserWorker.Equals((obj as OrderWork).idUserWorker);
        }
        // override GetHashCode
        public override int GetHashCode()
        {
            var hashcode = 352033288;
            hashcode = hashcode * -1524434295 + this.id.GetHashCode();
            hashcode = hashcode * -1524434295 + this.idState.GetHashCode();
            hashcode = hashcode * -1524434295 + this.idUserCustomer.GetHashCode();
            hashcode = hashcode * -1524434295 + this.idUserWorker.GetHashCode();
            hashcode = hashcode * -1524434295 + this.orderWorkName.GetHashCode();
            return hashcode;
        }

        // empty constructor
        public OrderWork()
        {
            
        }

        // parameters  constructor
        public OrderWork(int _id,int _idState,int  _idUserCustomer,int _idUserWorker,string _orderWorkName)
        {
            this.id = _id;
            this.idState = _idState;
            this.idUserCustomer = _idUserCustomer;
            this.idUserWorker = _idUserWorker;
            this.orderWorkName = _orderWorkName;
        }
    }
}