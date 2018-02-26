using System;

namespace TCPClient
{
    internal class Program
    {
        private static readonly int PORT = 9000;

        private static void Main(string[] args)
        {
            Console.Title = "Client";
            var printer = new PrinterClass();
            printer.Title();
            printer.HowTo();


            var userIPinput = Console.ReadLine();

            var client = new ClientClass(PORT, userIPinput);
            client.Start();

            Console.Clear();
            printer.Title();
            Console.WriteLine("connected");

            Console.ReadLine();
        }
    }
}