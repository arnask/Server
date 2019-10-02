using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Response
    {
        public static void SendResponse(Socket client)
        {
            try
            {
                string filePath = Directory.GetCurrentDirectory() + "\\index.html";
                string message = "HTTP / 1.0";
                TextReader text = new StreamReader(filePath);
                message += text.ReadToEnd();
                text.Close();
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                client.Send(buffer, 0, buffer.Length, SocketFlags.None);
                client.Disconnect(true);
            }
            catch (Exception)
            {
                Console.WriteLine("Message not sent");
            }
        }
    }
}
