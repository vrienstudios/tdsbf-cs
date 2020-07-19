using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.MessageClasses
{
    public class PrivateChannel
    {
        public int type { get; set; }
        public List<Recipient> recipients { get; set; }
        public string last_message_id { get; set; }
        public string id { get; set; }
    }
}
