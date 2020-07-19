using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.Web
{
    public class D2
    {
        public int heartbeat_interval { get; set; }
        public List<string> _trace { get; set; }
    }

    public class HeartBeat
    {
        public object t { get; set; }
        public object s { get; set; }
        public int op { get; set; }
        public D2 d { get; set; }
    }
}
