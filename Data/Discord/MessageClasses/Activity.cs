using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.MessageClasses
{
    public class Activity
    {
        public int type { get; set; }
        public string state { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public int flags { get; set; }
        public Emoji emoji { get; set; }
        public object created_at { get; set; }
        public Timestamps timestamps { get; set; }
        public string sync_id { get; set; }
        public string session_id { get; set; }
        public Party party { get; set; }
        public string details { get; set; }
        public Assets assets { get; set; }
    }
}
