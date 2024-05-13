using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Cliente_Socket_UDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpClient = new UdpClient();
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);
            udpClient.Connect(endPoint);

            byte[] bufferSendData = Encoding.ASCII.GetBytes("Sending data from Client to Server");
            udpClient.Send(bufferSendData);

            byte[] bufferReceivedData = new byte[256];
            bufferReceivedData = udpClient.Receive(ref endPoint);
            Console.WriteLine("Data received from server: " + Encoding.ASCII.GetString(bufferReceivedData));

            udpClient.Close();

            Console.ReadKey();


        }
    }
}
