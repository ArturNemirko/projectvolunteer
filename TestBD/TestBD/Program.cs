using dbVolanter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBD
{
    class Program
    {
        static void Main(string[] args)
        {
            AddSomeInfo.Add();
            Context con;
            using (con = new Context())
            {
                foreach (var item in con.Face)
                {
                    Console.WriteLine(item.AboutMe);
                }
                
            }
            Console.ReadKey();
        }
    }
}
