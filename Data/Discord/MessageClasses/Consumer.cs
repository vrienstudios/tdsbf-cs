using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.MessageClasses
{
    public class Consumer
    {
        public bool verified { get; set; }
        public string username { get; set; }
        public bool premium { get; set; }
        public object phone { get; set; }
        public bool mobile { get; set; }
        public bool mfa_enabled { get; set; }
        public string id { get; set; }
        public int flags { get; set; }
        public string email { get; set; }
        public string discriminator { get; set; }
        public string avatar { get; set; }
    }
}
