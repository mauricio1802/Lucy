using System;
using System.Drawing;
namespace Domain.Model
{
    // This class take the Lucy prfix in the name to avoid confusion with the standar Image class of .Net
    public class LucyImage
    {
        private int id;
        private string caption;
        private string creationDateTime;
        private Image image;

        // Id property
        public int Id => id;

        // Caption property
        public string Caption => caption;

        // CreationDateTime property
        public string CreationDateTime => creationDateTime;

        // Image property
        public Image Image => image;

        // overrides GetHashCode
        public override int GetHashCode()
        {
            var hashcode = 352033288;
            hashcode = hashcode * -1524434295 + this.id.GetHashCode();
            hashcode = hashcode * -1524434295 + this.caption.GetHashCode();
            hashcode = hashcode * -1524434295 + this.creationDateTime.GetHashCode();
            hashcode = image == null ? 0 : hashcode * -1524434295 + this.caption.GetHashCode();
            return hashcode;
        }

        // override Equlas
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            if (this.image == null && (obj as LucyImage).image != null)
            {
                return false;
            }

            else
            {
                return this.id.Equals((obj as LucyImage).id) &&
                       this.caption.Equals((obj as LucyImage).caption) &&
                       this.creationDateTime.Equals((obj as LucyImage).creationDateTime);
                       // Equals dont make use of this.image.equals(obj) comparison
            }
        }

        // default constructor
        public LucyImage()
        {
         this.creationDateTime = DateTime.Now.Date.ToShortDateString();   
        }

        // paramaters constructor
        public LucyImage(int _id,string _caption, Image _image)
        {
            this.id = _id;
            this.caption = _caption;
            this.creationDateTime = DateTime.Now.Date.ToShortDateString();
            this.image =_image;
        }

}
}