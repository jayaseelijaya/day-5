using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    public abstract class Animal
    {
        private string Name;
        public void setname(string name)
        {
            this.Name = name;
        }
        public void getname()
        {
            Console.WriteLine("name of the dog is:" + Name);
            
        }


        class Dog : Animal
        {
            public void eat()
            {
                Console.WriteLine("dog is eating");
            }

        }
        public static void Main()
        {
            Dog n = new Dog();
            n.getname(Console.ReadLine());
            n.eat();
        }

    }
}
