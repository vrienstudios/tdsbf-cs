using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.MessageClasses
{
    public class Role
    {
        public int position { get; set; }
        public int permissions { get; set; }
        public string name { get; set; }
        public bool mentionable { get; set; }
        public bool managed { get; set; }
        public string id { get; set; }
        public bool hoist { get; set; }
        public int color { get; set; }
    }
}
