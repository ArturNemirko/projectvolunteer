using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbVolanter
{
    public class Organization
    {
        public Guid Id { get; set; }
        public virtual Address Address { get; set; }
        public virtual Contacts Contacts { get; set; }
        public virtual ICollection<Ads> MyAds { get; set; }
        public virtual ICollection<Foto> MyFotos { get; set; }

    }
}
