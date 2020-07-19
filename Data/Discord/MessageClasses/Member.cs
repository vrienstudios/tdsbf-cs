using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.MessageClasses
{
    public class Member
    {
        public User user { get; set; }
        public List<string> roles { get; set; }
        public DateTime? premium_since { get; set; }
        public string nick { get; set; }
        public bool mute { get; set; }
        public DateTime joined_at { get; set; }
        public string hoisted_role { get; set; }
        public bool deaf { get; set; }
    }
}
