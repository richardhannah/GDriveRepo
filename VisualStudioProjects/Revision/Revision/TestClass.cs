using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Revision
{
    class TestClass
    {


        public void overload(int i, string s)
        {
            Console.WriteLine("overload 1{0}{1}", i, s);
        }

        public void overload(string s,int i )
        {
            Console.WriteLine("overload 2{0}{1}", i, s);
        }

    }
}
