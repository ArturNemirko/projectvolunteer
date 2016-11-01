using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbVolunteer
{
    public class Ads
    {
        public Guid Id { get; set; }
        public virtual HelpType HelpType { get; set; }
        public virtual Description Description { get; set; }
        public virtual Address Address { get; set; }

        public String Organizer { get; set; }

        public DateTime TimeOfStart { get; set; }

        public virtual SubsVal SubsVal { get; set; }

        public int MaxValCount { get; set; }
        public bool IsOpen { get; set; }
        public string Coments { get; set; }



    }
}
