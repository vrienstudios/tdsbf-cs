using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.MessageClasses
{
    public class UserGuildSettings
    {
        public bool suppress_everyone { get; set; }
        public bool muted { get; set; }
        public object mute_config { get; set; }
        public bool mobile_push { get; set; }
        public int message_notifications { get; set; }
        public string guild_id { get; set; }
        public List<object> channel_overrides { get; set; }
    }
}
