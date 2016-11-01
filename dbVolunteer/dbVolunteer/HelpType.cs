using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbVolunteer
{
    public class HelpType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Ads> Ads { get; set; }
    }
}
