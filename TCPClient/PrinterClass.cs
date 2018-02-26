using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient
{
    class PrinterClass
    {
        public void Title()
        {
            string title = @"   _____ _ _            _   
  / ____| (_)          | |  
 | |    | |_  ___ _ __ | |_ 
 | |    | | |/ _ \ '_ \| __|
 | |____| | |  __/ | | | |_ 
  \_____|_|_|\___|_| |_|\__|
";

            Console.WriteLine(title);
        }

        public void HowTo()
        {
            Console.WriteLine("Skriv Server IP adresse fx: 192.168.1.3");
            Console.WriteLine("brug evt ipconfig på server computer og se IPV4 adresse");
        }
    }
}
