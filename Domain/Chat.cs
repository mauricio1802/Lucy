namespace Domain
{
    public class Chat
    {
        private int id;
        private int idUser1;
        private int idUser2;

        // id property
        public int Id => id;
        // idUser1 property
        public int IdUser1 => idUser1;
        // idUser2 property
        public int IdUser2 => idUser2;

        // empty constructor
        public Chat()
        {
            
        }

        // parameters constructor
        public Chat(int _id,int _idUser1,int _idUser2)
        {
            this.id = _id;
            this.idUser1 = _idUser1;
            this.idUser2 = _idUser2;
        }

        // overrides Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return this.id.Equals((obj as Chat).id) &&
                   this.idUser1.Equals((obj as Chat).idUser1) &&
                   this.idUser2.Equals((obj as Chat).idUser2);
        }

        // overrides GetHashCode
        public override int GetHashCode()
        {
            var hashcode = 352033288;
            hashcode = hashcode * -1524434295 + this.id.GetHashCode();
            hashcode = hashcode * -1524434295 + this.idUser1.GetHashCode();
            hashcode = hashcode * -1524434295 + this.idUser2.GetHashCode();
            return hashcode;
        }
    }
}