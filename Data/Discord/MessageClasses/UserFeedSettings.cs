using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.MessageClasses
{
    public class UserFeedSettings
    {
        public List<object> unsubscribed_users { get; set; }
        public List<object> unsubscribed_games { get; set; }
        public List<object> subscribed_users { get; set; }
        public List<object> subscribed_games { get; set; }
        public List<string> autosubscribed_users { get; set; }
    }
}
