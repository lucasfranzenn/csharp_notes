using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Servidor_Socket_UDP;

class Program
{
    static void Main(string[] args)
    {
        //Creating UDP Server
        int port = 11000;
        UdpClient udpServer = new UdpClient(port);
        IPEndPoint endPoint = new(IPAddress.Any, port);

        //Receiving data from client
        byte[] bufferFromClient = new byte[256];
        bufferFromClient = udpServer.Receive(ref endPoint);
        Console.WriteLine("Message received from client: " + Encoding.ASCII.GetString(bufferFromClient));

        //Sending data from client
        byte[] bufferToClient = Encoding.ASCII.GetBytes("Hello from UDP Server");
        udpServer.Send(bufferToClient, bufferToClient.Length, endPoint);

        udpServer.Close();

        Console.ReadKey();

    }
}
