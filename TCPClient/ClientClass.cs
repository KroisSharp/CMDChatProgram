using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
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
            using (TcpClient client = new TcpClient("localhost", PORT))
            using (NetworkStream stream = client.GetStream())
            using (StreamReader reader = new StreamReader(stream))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.AutoFlush = true;

                //kode her

                while (true)
                {
                    string userinput = Console.ReadLine();
                    writer.WriteLine(userinput);
                    Console.WriteLine(reader.ReadLine());
                }

            }
        }


    }
}
