using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbVolunteer
{
    public class Face : IUser
    {
        public Guid Id { get; set; }

        public String Name { get; set; }
        public String Surname { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<Foto> Fotos { get; set; }
        public virtual ICollection<Contacts> Contacts { get; set; }
        public virtual ICollection<Ads> MyAds { get; set; }
        public double Raiting { get; set; }
        public virtual ICollection<Ads> TakePart { get; set; }
        public string AboutMe { get; set; }
        public bool Ban { get; set; } 

    }
}
