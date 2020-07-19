using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.MessageClasses
{
    public class Guild
    {
        public object application_id { get; set; }
        public List<Presence> presences { get; set; } // Rich Presences of every user in the server.
        public string system_channel_id { get; set; }
        public DateTime joined_at { get; set; }
        public bool large { get; set; }
        public int afk_timeout { get; set; }
        public int premium_subscription_count { get; set; }
        public int member_count { get; set; } // Amount of members in the guild
        public object vanity_url_code { get; set; } // the "Vanity" url to a server (if applicable)
        public string afk_channel_id { get; set; }
        public string region { get; set; }
        public List<Member> members { get; set; }
        public List<Role> roles { get; set; }
        public int explicit_content_filter { get; set; } // Content filter level.
        public List<Emoji> emojis { get; set; }
        public int default_message_notifications { get; set; }
        public string name { get; set; }
        public string preferred_locale { get; set; }
        public int premium_tier { get; set; } // Server boost!
        public object rules_channel_id { get; set; }
        public int system_channel_flags { get; set; }
        public object discovery_splash { get; set; }
        public List<object> voice_states { get; set; }
        public object splash { get; set; }
        public List<object> features { get; set; }
        public List<Channel> channels { get; set; }
        public string icon { get; set; }
        public bool lazy { get; set; }
        public int verification_level { get; set; }
        public object description { get; set; }
        public int mfa_level { get; set; }
        public object banner { get; set; }
        public string id { get; set; }
        public string owner_id { get; set; }
    }
}
