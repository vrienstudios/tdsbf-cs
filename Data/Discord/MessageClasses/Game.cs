using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.MessageClasses
{
    public class Game
    {
        public int type { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public Emoji emoji { get; set; }
        public object created_at { get; set; }
        public string state { get; set; }
        public int? flags { get; set; }
        public Timestamps timestamps { get; set; }
        public string application_id { get; set; }
        public string platform { get; set; }
    }
}
