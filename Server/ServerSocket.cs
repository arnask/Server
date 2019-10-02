using System.Net;
using System.Net.Sockets;

namespace Server
{
    class ServerSocket
    {
        private IPAddress ip = IPAddress.Parse("127.0.0.1");
        private int port = 85;
        private int backlog = 10;
        public Socket socket = null;

        public ServerSocket()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(ip, port));
            socket.Listen(backlog);
        }
    }
}
