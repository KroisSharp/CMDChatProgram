using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient
{
    class Program
    {
        private static readonly int PORT = 9000;
        static void Main(string[] args)
        {

            ClientClass client = new ClientClass(PORT);
            client.Start();

            Console.ReadLine();
        }
    }
}
