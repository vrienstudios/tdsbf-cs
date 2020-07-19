﻿using System;
using System.Collections.Generic;
using System.Text;
using TDSBF.Data.Discord.MessageClasses;

namespace TDSBF.Data.Discord.Events
{
    public class RD
    {
        public string user_id { get; set; }
        public string message_id { get; set; }
        public Emoji emoji { get; set; }
        public string channel_id { get; set; }
    }

    public class MessageReactionAdd
    {
        public string t { get; set; }
        public int s { get; set; }
        public int op { get; set; }
        public RD d { get; set; }
    }
}
