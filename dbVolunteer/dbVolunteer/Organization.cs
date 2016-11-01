using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbVolunteer
{
    public class Organization : IUser
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<Contacts> Contacts { get; set; }
        public virtual ICollection<Ads> MyAds { get; set; }
        public virtual ICollection<Foto> Fotos { get; set; }
    }
}
