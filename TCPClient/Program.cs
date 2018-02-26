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
            #region Start up

            string title = @"   _____ _ _            _   
  / ____| (_)          | |  
 | |    | |_  ___ _ __ | |_ 
 | |    | | |/ _ \ '_ \| __|
 | |____| | |  __/ | | | |_ 
  \_____|_|_|\___|_| |_|\__|
";

            Console.WriteLine(title);

            Console.Title = "Client";
            
            #endregion

            Console.WriteLine("Skriv Server IP adresse fx: 192.168.1.3");
            Console.WriteLine("brug evt ipconfig på server computer og se IPV4 adresse");
            string userIPinput = Console.ReadLine();

            ClientClass client = new ClientClass(PORT, userIPinput);
            client.Start();
            Console.Clear();
            Console.WriteLine(title);
            Console.WriteLine("connected");

            Console.ReadLine();
        }
    }
}
