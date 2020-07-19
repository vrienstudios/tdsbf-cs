using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.Events
{
    public class DMsgDelete
    {
        public string id { get; set; }
        public string channel_id { get; set; }
    }

    public class MessageDelete
    {
        public string t { get; set; }
        public int s { get; set; }
        public int op { get; set; }
        public DMsgDelete d { get; set; }
    }
}
