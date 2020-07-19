using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.MessageClasses
{
    public class Presence
    {
        public User user { get; set; }
        public string status { get; set; }
        public long last_modified { get; set; }
        public Game game { get; set; }
        public ClientStatus client_status { get; set; }
        public List<object> activities { get; set; }
    }
}
