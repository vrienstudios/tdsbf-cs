using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.MessageClasses
{
    public class UserSettings
    {
        public int timezone_offset { get; set; }
        public string theme { get; set; } // picks one of the two themes Discord has.
        public bool stream_notifications_enabled { get; set; } // Wether users will get notifications that users are streaming.
        public string status { get; set; } // Online, Invisible, Idle, etc
        public bool show_current_game { get; set; } // Wether the current game will be shown or not.
        public List<object> restricted_guilds { get; set; } // Unknown
        public bool render_reactions { get; set; }
        public bool render_embeds { get; set; }
        public bool message_display_compact { get; set; }
        public string locale { get; set; }
        public bool inline_embed_media { get; set; }
        public bool inline_attachment_media { get; set; }
        public List<object> guild_positions { get; set; }
        public List<object> guild_folders { get; set; }
        public bool gif_auto_play { get; set; }
        public FriendSourceFlags friend_source_flags { get; set; }
        public int explicit_content_filter { get; set; }
        public bool enable_tts_command { get; set; }
        public bool disable_games_tab { get; set; }
        public bool developer_mode { get; set; }
        public bool detect_platform_accounts { get; set; }
        public bool default_guilds_restricted { get; set; }
        public object custom_status { get; set; }
        public bool convert_emoticons { get; set; }
        public bool contact_sync_enabled { get; set; }
        public bool animate_emoji { get; set; }
        public bool allow_accessibility_detection { get; set; }
        public int afk_timeout { get; set; }
    }
}
