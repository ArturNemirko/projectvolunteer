using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbVolunteer
{
    public interface IUser
    {
        Guid Id { get; set; }
        String Name { get; set; }
        ICollection<Contacts> Contacts { get; set; }
        ICollection<Ads> MyAds { get; set; }
        Address Address { get; set; }
        ICollection<Foto> Fotos { get; set; }
    }
}
