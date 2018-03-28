using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client2
{

    //how to data send form client to server And how to response sever to client
    class Client2
    {
        static void Main(string[] args)
        {
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1994);// it is combination of IP + Port address 
           // sck.Connect(endpoint);  
                               

            sck.Connect("127.0.0.1",1994);// sending data initiates a message that the other point is then able to receive.

            Console.Write("Enter the MSg:->");

            string msg = Console.ReadLine();
            byte[] msgBuffer = Encoding.Default.GetBytes(msg);

            sck.Send(msgBuffer, 0, msgBuffer.Length, 0); // once a socket is connected to an end point, sending data initiates a message that the other point is then able to receive.

            byte[] buffer = new byte[255];
            int rec = sck.Receive(buffer, 0, buffer.Length, 0);
            Array.Resize(ref buffer, rec);

            Console.WriteLine("recived:{0}", Encoding.Default.GetString(buffer));

            sck.Close();
            Console.Read();
        }
    }
}