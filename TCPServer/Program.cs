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

            #region Start up

            string title = @"   _____                          
  / ____|                         
 | (___   ___ _ ____   _____ _ __ 
  \___ \ / _ \ '__\ \ / / _ \ '__|
  ____) |  __/ |   \ V /  __/ |   
 |_____/ \___|_|    \_/ \___|_|   
";

            Console.WriteLine(title);

            Console.Title = "Server";

            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    Console.WriteLine("Servers IPV4 adresse: " + ip);

                }
            }

            Console.WriteLine("Klar");
            #endregion




            ServerClass server = new ServerClass(PORT);
            server.Start();

            Console.ReadLine();
        }
    }
}
