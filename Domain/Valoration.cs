namespace Domain.Model
{
    public class Valoration
    {
        private int id;
        private string comment;
        private int idUserCreator;
        private int idUserObjective;

        // Id property
        public int Id => id;

        // IdUserCreator property
        public int IdUserCreator => id;

        // IdUserObjective
        public int IdUserObjective => id;

        // empty constructor
        public Valoration()
        {

        }

        // paramters constructor
        public Valoration(int _id, string _comment, int _idUserCreator, int _idUserObjective)
        {
            this.id = _id;
            this.comment = _comment;
            this.idUserCreator = _idUserCreator;
            this.idUserObjective = _idUserObjective;
        }

        // overides GetHashCode
        public override int GetHashCode()
        {
            var hashcode = 352033288;
            hashcode = hashcode * -1524434295 + this.id.GetHashCode();
            hashcode = hashcode * -1524434295 + this.comment.GetHashCode();
            hashcode = hashcode * -1524434295 + this.idUserCreator.GetHashCode();
            hashcode = hashcode * -1524434295 + this.idUserObjective.GetHashCode();
            return hashcode;
        }

        // override Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return this.id.Equals((obj as Valoration).id) &&
                    this.idUserCreator.Equals((obj as Valoration).idUserCreator) &&
                    this.idUserObjective.Equals((obj as Valoration).idUserObjective) &&
                    this.comment.Equals((obj as Valoration).comment);

        }


    }
}