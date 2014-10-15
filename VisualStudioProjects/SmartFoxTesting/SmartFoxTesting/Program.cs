using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sfs2X;
using System.Threading;

namespace SmartFoxTesting
{
    class Program
    {
        static SmartFox testFox;

        static void Main(string[] args)
        {

            testFox = new SmartFox();

            try { 
                testFox.Connect("127.0.0.1",9933); 
            }
            catch
            {

                

            }
            Thread.Sleep(1000);
            if (testFox.IsConnected || testFox.IsConnecting)
            {
                Console.WriteLine("connection successful");
                getConnectionInfo();


            }
            else
            {
                Console.WriteLine("connection failed");
            }

            Console.ReadLine();
        }

        static void getConnectionInfo()
        {
            Console.WriteLine("Current IP: {0}", testFox.CurrentIp);
            Console.WriteLine("Current port: {0}", testFox.CurrentPort);
            Console.WriteLine("Current zone: {0}", testFox.CurrentZone);

        }


    }
}
