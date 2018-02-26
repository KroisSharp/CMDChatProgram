using System;

namespace TCPServer
{
    internal class Program
    {
        private static readonly int PORT = 9000;

        private static void Main(string[] args)
        {
            Console.Title = "Server";
            var printer = new PrinterClass();
            printer.title();
            printer.findipv4();


            var server = new ServerClass(PORT);
            server.Start();

            Console.ReadLine();
        }
    }
}