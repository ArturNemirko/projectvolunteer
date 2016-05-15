using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbVolanter
{
    public class Description
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public virtual ICollection<Ads> Ads { get; set; }
    }
}
