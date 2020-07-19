using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.MessageClasses
{
    public class Relationship
    {
        public User user { get; set; }
        public int type { get; set; }
        public string id { get; set; }
    }
}
