using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace day_5
{//dispose pattern
    public class Customer : IDisposable
    {
        public StringReader _reader;
        //to deduntant calls
        private bool disposed = false;

        public Customer(string value)
        {
            this._reader = new StringReader(value);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (_reader != null)
                    {
                        this._reader.Dispose();
                    }
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        } }
      public class Class1
        {
            public static void Main()
            {
                Customer c = new Customer("true");
              Console.ReadLine();
            }
        }
    } 
