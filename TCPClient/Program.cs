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
            Console.Title = "Client";
            PrinterClass printer = new PrinterClass();
            printer.Title();
            printer.HowTo();


            string userIPinput = Console.ReadLine();

            ClientClass client = new ClientClass(PORT, userIPinput);
            client.Start();

            Console.Clear();
            printer.Title();
            Console.WriteLine("connected");

            Console.ReadLine();
        }
    }
}
