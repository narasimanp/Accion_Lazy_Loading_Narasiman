using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy_Loading
{
    class Test
    {
        int[] _array;
        public Test()
        {
            Console.WriteLine("Test()");
            _array = new int[10];
        }
        public int Length
        {
            get
            {
                return _array.Length;
            }
        }

        class Program
        {
            static void Main()
            {
                Lazy<Test> lazy = new Lazy<Test>();

                Console.WriteLine("IsValueCreated = {0}", lazy.IsValueCreated);
               
                Test test = lazy.Value;

                Console.WriteLine("IsValueCreated = {0}", lazy.IsValueCreated);

                Console.WriteLine("Length = {0}", test.Length);
                Console.ReadLine();
            }
        }
    }
}
