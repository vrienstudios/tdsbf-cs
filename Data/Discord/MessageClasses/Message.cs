using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.MessageClasses
{
    public class Message
    {
        public string id { get; set; }
        public int type { get; set; }
        public string content { get; set; }
        public string channel_id { get; set; }
        public Recipient author { get; set; }
        public Member member { get; set; }
        public List<object> attachments { get; set; }
        public List<object> embeds { get; set; }
        public List<object> mentions { get; set; }
        public List<object> mention_roles { get; set; }
        public bool pinned { get; set; }
        public bool mention_everyone { get; set; }
        public bool tts { get; set; }
        public DateTime timestamp { get; set; }
        public object edited_timestamp { get; set; }
        public int flags { get; set; }

        public Data.Discord.Events.MessageCreate.EVMC toEventMessage()
        {
            Data.Discord.Events.MessageCreate.EVMC evMessage = new Data.Discord.Events.MessageCreate.EVMC
            {
                op = 22,
                s = 22,
                t = "MESSAGE_EV_GRAB",
                d = new Data.Discord.Events.MessageCreate.MESSAGE_CREATE_D
                {
                    author = new Data.Discord.Events.MessageCreate.Author { username = this.author.username, avatar = this.author.avatar, discriminator = this.author.discriminator, id = this.author.id },
                    channel_id = this.channel_id,
                    id = this.id,
                    content = this.content,
                    timestamp = this.timestamp
                }
            };
            return evMessage;
        }

        public class MessageRootObj
        {
            public string t { get; set; }
            public int s { get; set; }
            public int op { get; set; }
            public Message d;
        }
    }
}
