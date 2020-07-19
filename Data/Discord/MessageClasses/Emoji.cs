using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.MessageClasses
{
    public class Emoji
    {
        public List<object> roles { get; set; }
        public bool? require_colons { get; set; }
        public string name { get; set; }
        public bool? managed { get; set; }
        public string id { get; set; }
        public bool? available { get; set; }
        public bool? animated { get; set; }
    }
}
