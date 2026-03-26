using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulWork1
{
    internal class MessagePublisher
    {
        public event EventHandler<MessageEventArgs>? MessageReceived;
        private string? _message;
        public void Send(string message)
        {
            if (MessageReceived != null)
            {
                _message = message;
                MessageReceived?.Invoke(this, new MessageEventArgs { Message = message});
            }
        }
    }
}
