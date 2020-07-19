using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.MessageClasses
{
    public class ReadState
    {
        public int mention_count { get; set; }
        public DateTime last_pin_timestamp { get; set; }
        public object last_message_id { get; set; }
        public string id { get; set; }
    }
}
