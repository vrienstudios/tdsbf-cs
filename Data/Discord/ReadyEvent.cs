using System;
using System.Collections.Generic;
using System.Text;
using TDSBF.Data.Discord.MessageClasses;

namespace TDSBF.Data.Discord
{
    public class ReadyEvent
    {
        public string t { get; set; }
        public string s { get; set; }
        public int op { get; set; }
        public D d { get; set; }
    }
}
