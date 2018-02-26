using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPServer
{
    class Program
    {
        private static readonly int PORT = 9000;
        static void Main(string[] args)
        {
            Console.Title = "Server";
            PrinterClass printer = new PrinterClass();
            printer.title();
            printer.findipv4();





            ServerClass server = new ServerClass(PORT);
            server.Start();

            Console.ReadLine();
        }
    }
}
