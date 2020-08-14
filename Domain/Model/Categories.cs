using System;

namespace Domain
{
    public class Categories
    {

        private int id;
        private string name;


        // ID property
        public int ID => id;
        
        // Name property
        public string Name => name;


        // override Equals
        public override bool Equals(object obj)
        {   
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return this.id.Equals((obj as Categories).id) && this.name.Equals((obj as Categories).name);
        }
        
        // override GetHashCode
        public override int GetHashCode()
        {
            var hashcode = 352033288;
            hashcode  = hashcode * -1524434295 + this.id.GetHashCode();
            hashcode  = hashcode * -1524434295 + this.name.GetHashCode();
            return hashcode;
        }

        // Empty Constructor
        public Categories()
        {
            
        }

        // Paramaters Constructor
        public Categories(int _id, string _name)
        {
            this.id = _id;
            this.name =_name;
        }
    }
}