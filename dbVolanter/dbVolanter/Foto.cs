using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbVolanter
{
    public class Foto
    {
        public Guid Id { get; set; }
        public ICollection<byte[]> Fotos { get; set; }
        public virtual Face Face { get; set; }
    }
}
