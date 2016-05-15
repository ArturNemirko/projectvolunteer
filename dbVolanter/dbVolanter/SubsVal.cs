using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbVolanter
{
    public class SubsVal
    {
        public Guid Id { get; set; }
        public virtual ICollection<Face> First { get; set; }
        public virtual ICollection<Face> Second { get; set; }
    }
}
