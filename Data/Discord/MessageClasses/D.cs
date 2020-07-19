using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.MessageClasses
{
    public class D
    {
        public int v { get; set; }
        public UserSettings user_settings { get; set; }
        public List<UserGuildSettings> user_guild_settings { get; set; }
        public UserFeedSettings user_feed_settings { get; set; }
        public User user { get; set; }
        public object tutorial { get; set; }
        public string session_id { get; set; }
        public List<Relationship> relationships { get; set; }
        public List<ReadState> read_state { get; set; }
        public List<PrivateChannel> private_channels { get; set; }
        public List<Presence> presences { get; set; }
        public Notes notes { get; set; }
        public List<Guild> guilds { get; set; }
        public List<List<object>> guild_experiments { get; set; }
        public int friend_suggestion_count { get; set; }
        public List<List<object>> experiments { get; set; }
        public Consent consents { get; set; }
        public List<object> connected_accounts { get; set; }
        public string analytics_token { get; set; }
        public List<string> _trace { get; set; }
    }
}
