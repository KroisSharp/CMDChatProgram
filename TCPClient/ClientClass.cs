using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TCPClient
{
    class ClientClass
    {
        private readonly int PORT;

        //ctor husk at lav navnet om
        public ClientClass(int port)
        {
            this.PORT = port;
        }
        public void Start()
        {
            TcpClient client = new TcpClient("localhost", PORT);

           
            Thread t1 = new Thread(() => DoReadClient(client));
            Thread t2 = new Thread(() => DowriteClient(client));
            t1.Start();
            t2.Start();
           





        }

        public static void DoReadClient(TcpClient client)
        {
            using (NetworkStream ns = client.GetStream())
            using (StreamReader sr = new StreamReader(ns))
            {
                
                while (true)
                {
                    string incstr = sr.ReadLine();
                    Console.WriteLine("Server: " + incstr);
                }

            }
        }

        private static void DowriteClient(TcpClient client)
        {
            using (NetworkStream ns = client.GetStream())
            using (StreamWriter sw = new StreamWriter(ns))
            {
                
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
