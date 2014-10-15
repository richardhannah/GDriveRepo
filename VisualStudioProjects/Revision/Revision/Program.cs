using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList x;
            ArrayList y;
            int i = 1;
            string s = "hello";
            TestClass myClass = new TestClass();

            x = new ArrayList();
            y = new ArrayList();

            x.Add(12345);
            y.Add(12345);
            
            

            if (x == y)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }

            if (x.Equals(y))
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }

            myClass.overload(i, s);
            myClass.overload(s, i);

            Console.Read();
        }
    }
}
