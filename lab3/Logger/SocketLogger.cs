using Newtonsoft.Json;
using System.Text;

namespace ConsoleApp.Logger
{
    public class SocketLogger : ILogger
    {
        private readonly ClientSocket socket;

        public SocketLogger(string host, int port)
        {
            this.socket = new ClientSocket(host, port);
        }

        public virtual void Log(params string[] messages)
        {
            foreach (string message in messages)
            {
                var serializedMessage = SerializeMessage(message);
                socket.Send(serializedMessage);
            }
        }

        public virtual void Dispose()
        {
            this.socket.Close();
            GC.SuppressFinalize(this);
        }

        private byte[] SerializeMessage(string message)
        {
            var messageData = new { Message = message, timestamp = DateTime.Now };
            var jsonMessage = JsonConvert.SerializeObject(messageData);
            var serializedMessage = Encoding.ASCII.GetBytes(jsonMessage);
            return serializedMessage;
        }
    }
}
