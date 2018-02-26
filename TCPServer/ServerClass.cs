using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace TCPServer
{
    internal class ServerClass
    {
        private readonly int PORT;


        public ServerClass(int port)
        {
            PORT = port;
        }

        public void Start()
        {
            var listener = TcpListener.Create(PORT);
            listener.Start();

            while (true)
            {
                var client = listener.AcceptTcpClient();
                Task.Run(() => DoClient(client));
            }
        }

        private static void DoClient(TcpClient client)
        {
            Console.WriteLine("Client connected");
            var t1 = new Thread(() => DoReadClient(client));
            var t2 = new Thread(() => DowriteClient(client));
            t1.Start();
            t2.Start();
        }


        public static void DoReadClient(TcpClient client)
        {
            using (var ns = client.GetStream())
            using (var sr = new StreamReader(ns))
            {
                while (true)
                {
                    var incstr = sr.ReadLine();
                    Console.WriteLine("Client: " + incstr);
                }
            }
        }

        private static void DowriteClient(TcpClient client)
        {
            using (var ns = client.GetStream())
            using (var sw = new StreamWriter(ns))
            {
                sw.AutoFlush = true;
                while (true)
                {
                    var userinput = Console.ReadLine();
                    sw.WriteLine(userinput);
                }
            }
        }
    }
}