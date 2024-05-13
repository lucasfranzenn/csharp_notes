using System.Net.Sockets;
using System.Text;

namespace Cliente_Socket_TCP
{
    internal class Program
    {
        static void Main()
        {
            //Creating TCP Client
            TcpClient tcpClient = new TcpClient("localhost", 13);
            NetworkStream ns = tcpClient.GetStream();

            //Sending data to server
            byte[] bufferSendToServer = Encoding.ASCII.GetBytes("Hello world from client");
            ns.Write(bufferSendToServer, 0, bufferSendToServer.Length);

            //Receiving data from server
            byte[] bufferReceivedFromServer = new byte[256];
            int bytesRead = ns.Read(bufferReceivedFromServer, 0, bufferReceivedFromServer.Length);
            Console.WriteLine("Data received from server: " + Encoding.ASCII.GetString(bufferReceivedFromServer, 0, bufferReceivedFromServer.Length));

            //Closing...
            ns.Close();
            tcpClient.Close();
        }
    }
}
