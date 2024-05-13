using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Runtime.CompilerServices;

namespace Servidor_Socket_TVP
{
    internal class Program
    {
        static void Main()
        {
            TcpListener tcpListener = new(IPAddress.Any, 13);
            tcpListener.Start();

            Console.WriteLine("Waiting connection...");

            TcpClient client = tcpListener.AcceptTcpClient();

            Console.WriteLine("Connection established...");

            NetworkStream ns = client.GetStream();

            try
            {
                //Receiving data from client
                byte[] bufferFromClient = new byte[256];
                int readBytes = ns.Read(bufferFromClient, 0, bufferFromClient.Length);
                Console.WriteLine("Data received from client: " + Encoding.ASCII.GetString(bufferFromClient, 0, bufferFromClient.Length));

                //Sending data to client
                byte[] bufferToClient = Encoding.ASCII.GetBytes("Hello World from server!");
                ns.Write(bufferToClient, 0, bufferToClient.Length);

                ns.Close();
                client.Close();
                tcpListener.Stop();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}