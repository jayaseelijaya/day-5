using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    class photobook
    {
        protected int numpages;
        public int GetNumberPages(int numpages)
        {
            Console.WriteLine("number of photobook pages: " + numpages);
            return numpages;
        }


        public photobook(int addpages)
        {
           this.addpages = numpages;
        }
    }
       public class Bigphotobook:photobook
        {
            
            public Bigphotobook(int album)
            {
                album = 64;
            }
        }
    
    
    class photobooktest
    {
    public static void Main()
        {
            photobook obj = new photobook();
            obj.GetNumberPages(16);
            photobook obj1 = new photobook(24);
            Bigphotobook obj2 = new Bigphotobook();
            Console.ReadLine();
        }
    }
}
