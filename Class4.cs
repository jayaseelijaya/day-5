using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
   public class person
    {
        public string Name { get; set; }
        public person(string name)
        {
        Name=name;
        }
        public string Tostring()
        {
            return Name;
        }
        ~person()
        {
           Name = String.Empty;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the persons name:");
            person[] p = new person[3];
            for(int i=0;i<3;i++)
            {
                p[i] = new person(Console.ReadLine());
               
            }
            Console.WriteLine("the persons names are:");
            for (int i = 0; i < 3; i++)
            {
                
                Console.WriteLine(p[i].Tostring());
                
            }
            Console.ReadLine();
        }
    }
}
