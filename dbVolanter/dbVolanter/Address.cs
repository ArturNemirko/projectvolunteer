using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbVolanter
{
    public class Address
    {
        public Guid Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string FlatNum { get; set; }
        public double GPS_x { get; set; }
        public double GPS_y { get; set; }
        public virtual ICollection<Ads> Ads { get; set; }
    }
}
