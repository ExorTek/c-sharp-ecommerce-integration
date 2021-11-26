using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete;
using DataAccess.Concrete.StoredProcedure;
using Entities.Concrete;

namespace ConsoleTestUI
{
    class Program
    {
        static void Main(string[] args)
        {

            SpUserDal user = new SpUserDal();
           var a = user.GetAll(new ETradeTools());
           foreach (var b in a)
           {
               Console.WriteLine(b);
           }

           Console.ReadKey();
        }
    }
}
