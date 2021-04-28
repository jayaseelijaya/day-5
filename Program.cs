using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    class Program
    {
        Program()
        {
            Console.WriteLine("constructor called");
        }
        ~Program()
        {
            Console.WriteLine("destructor");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.ReadLine();
        }
    }
}
