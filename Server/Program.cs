using System;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerSocket server = new ServerSocket();
            Socket serverSocket = server.socket;
            while (true)
            {
                Console.WriteLine("Waiting for connection...");
                Socket clientSocket = serverSocket.Accept();
                if (clientSocket.Connected == true)
                {
                    Console.WriteLine("Client is connected");
                    Response.SendResponse(clientSocket);
                    clientSocket.Close();
                }
            }
        }
    }
}
