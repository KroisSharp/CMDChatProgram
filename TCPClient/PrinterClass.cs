using System;

namespace TCPClient
{
    internal class PrinterClass
    {
        public void Title()
        {
            var title = @"   _____ _ _            _   
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