﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPServer
{
    class Program
    {
        private static readonly int PORT = 9000;
        static void Main(string[] args)
        {
            ServerClass server = new ServerClass(PORT);
            server.Start();

            Console.ReadLine();
        }
    }
}
