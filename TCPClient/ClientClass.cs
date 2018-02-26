using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace TCPClient
{
    internal class ClientClass
    {
        private readonly string IPADRESSE;
        private readonly int PORT;


        public ClientClass(int port, string ipadresse)
        {
            PORT = port;
            IPADRESSE = ipadresse;
        }

        public void Start()
        {
            var client = new TcpClient(IPADRESSE, PORT);
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
                    Console.WriteLine("Server: " + incstr);
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