using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    class daymonthpro
    {
        public static void Main()
        {
            System.DateTime dt= new System.DateTime(2021, 4, 28, 3, 16, 45, 8);

            Console.WriteLine(String.Format("{0}", dt));
            Console.WriteLine(String.Format("{0:ddddddd,MMMM,yyyy}", dt));
            Console.WriteLine(String.Format("{0:MMMM}", dt));
            Console.ReadLine();
        }
    }
}

