using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbVolanter
{
    public class Context : DbContext
    {
        static Context()
        {
            //Database.SetInitializer(new ContextInitializer());
        }

        public Context()
            : base("name = Connection")
        { }


        
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<Description> Description { get; set; }
        public DbSet<Face> Face { get; set; }
        public DbSet<Foto> Foto { get; set; }
        public DbSet<HelpType> HelpType { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<SubsVal> SubsVal { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Ads> Ads { get; set; }
    }
}
