using System;
using TDSBF.Data.Discord.MessageClasses;

namespace TDSBF.Data.Discord.Events.Protected
{
    public class MessageAlert : EventArgs
    {

        private Message message;

        public MessageAlert(Message message)
        {
            this.message = message;
        }

        public Message Message
        {
            get { return this.message; }
        }
    }
}
