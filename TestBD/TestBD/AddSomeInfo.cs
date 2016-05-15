using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbVolanter;

namespace TestBD
{
    class AddSomeInfo
    {

        public static void Add()
        {
            Context con;
            using (con = new Context())
            {
                Face f = new Face();
                f.AboutMe = "asdb;;jsafsa";
                f.Id = Guid.NewGuid();
                con.Face.Add(f);
                con.SaveChanges();
            }
        }
    }
}