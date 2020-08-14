using System.ComponentModel;
using System;
using System.Text.RegularExpressions;

namespace Domain.Model
{
    public class User
    {
        private int id;
        private string username;
        private string email;
        private int phoneNumber;
        private string creationDateTime;

        //Id property
        public int Id => id;
        // Email property
        public string Email => email;
        // UserName property
        public string UserName => username;
        // PhoneNumber property
        public int PhoneNumber => phoneNumber;
        // Creation time property
        public string CreationDateTime { get { return creationDateTime; } }

        // default constructor
        public User()
        {
            this.creationDateTime = DateTime.Now.Date.ToShortDateString();
        }

        // parameters constructor
        public User(int _id, int _phoneNumber, string _userName, string _email)
        {
            if (!Validate(email))
                throw new InvalidEnumArgumentException("Invalid email address passed as parameter");
            this.id = _id;
            this.phoneNumber = _phoneNumber;
            this.username = _userName;
            this.email = _email;

        }

        // override Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return this.id.Equals((obj as User).id) &&
                   this.phoneNumber.Equals((obj as User).phoneNumber) &&
                   this.email.Equals((obj as User).email) &&
                   this.username.Equals((obj as User).username) &&
                   this.creationDateTime.Equals((obj as User).creationDateTime);
        }

        // overrides GetHasCode
        public override int GetHashCode()
        {
            var hashcode = 352033288;
            hashcode = hashcode * -1524434295 + this.id.GetHashCode();
            hashcode = hashcode * -1524434295 + this.email.GetHashCode();
            hashcode = hashcode * -1524434295 + this.CreationDateTime.GetHashCode();
            hashcode = hashcode * -1524434295 + this.username.GetHashCode();
            hashcode = hashcode * -1524434295 + this.phoneNumber.GetHashCode();
            return hashcode;

        }

        // method to verify a valid emailAddress
        private bool Validate(string _emailAddress)
        {
            var regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            bool isValid = Regex.IsMatch(_emailAddress, regex, RegexOptions.IgnoreCase);
            return isValid;
        }

    }
}