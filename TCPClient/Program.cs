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
            Console.WriteLine("Klar");
            #endregion


            ClientClass client = new ClientClass(PORT);
            client.Start();

            Console.ReadLine();
        }
    }
}
