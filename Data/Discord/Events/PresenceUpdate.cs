using System;
using System.Collections.Generic;
using System.Text;
using TDSBF.Data.Discord.MessageClasses;

namespace TDSBF.Data.Discord
{
    public class PRD
    {
        public User user { get; set; }
        public string status { get; set; }
        public List<string> roles { get; set; }
        public object premium_since { get; set; }
        public string nick { get; set; }
        public string guild_id { get; set; }
        public Game game { get; set; }
        public ClientStatus client_status { get; set; }
        public List<Activity> activities { get; set; }
    }

    public class PresenceUpdate
    {
        public string t { get; set; }
        public int s { get; set; }
        public int op { get; set; }
        public PRD d { get; set; }
    }
}
