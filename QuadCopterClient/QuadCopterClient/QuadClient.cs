using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace QuadCopterClient
{
    class QuadClient : TcpClient
    {

        


        public QuadClient(string cServer, int cPort) : base(cServer,cPort)
        {
          
        }

       

        public void SendMessge(string msg)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);

            // Get a client stream for reading and writing.
            //  Stream stream = client.GetStream();

            NetworkStream stream = GetStream();

            // Send the message to the connected TcpServer. 
            stream.Write(data, 0, data.Length);

            Console.WriteLine("Sent: {0}", msg);
        }


        
    }
}
