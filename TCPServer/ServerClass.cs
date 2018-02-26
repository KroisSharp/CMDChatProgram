﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TCPServer
{
    class ServerClass
    {
        private readonly int PORT;

        //lav vores threads her start dem i doclient


        //husk at ændre navn
        public ServerClass(int port)
        {
            this.PORT = port;
        }
        public void Start()
        {

            TcpListener listener = TcpListener.Create(PORT);
            listener.Start();

            while (true)
            {
                {

                    TcpClient client = listener.AcceptTcpClient();
                    Task.Run(() => DoClient(client));

                }
            }

        }
        private static void DoClient(TcpClient client)
        {
            Console.WriteLine("DoClient");
            Thread t1 = new Thread(() => DoReadClient(client));
            Thread t2 = new Thread(() => DowriteClient(client));
            t1.Start();
            t2.Start();
            Console.WriteLine("efter thread");

        }


        //thead til at køre read

        public static void DoReadClient(TcpClient client)
        {
            using (NetworkStream ns = client.GetStream())
            using (StreamReader sr = new StreamReader(ns))
            {
                Console.WriteLine("DoReadClient thread køre");
                while (true)
                {
                    string incstr = sr.ReadLine();
                    Console.WriteLine(incstr);
                }

            }
        }

        private static void DowriteClient(TcpClient client)
        {
            using (NetworkStream ns = client.GetStream())
            using (StreamWriter sw = new StreamWriter(ns))
            {
                Console.WriteLine("DoWriteClient thead køre");
                sw.AutoFlush = true;
                while (true)
                {
                    string userinput = Console.ReadLine();
                    sw.WriteLine(userinput);
                }
            }

        }
    }
}
