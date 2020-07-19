using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.MessageClasses
{
    public class Recipient
    {
        public string username { get; set; }
        public string id { get; set; }
        public string discriminator { get; set; }
        public bool bot { get; set; }
        public string avatar { get; set; }
        public int public_flags { get; set; }

        public void integrateUser(object user)
        {
            switch (user)
            {
                case Consumer u1:
                    this.username = u1.username;
                    this.id = u1.id;
                    this.discriminator = u1.discriminator;
                    this.avatar = u1.avatar;
                    break;

                case User u2:
                    this.username = u2.username;
                    this.id = u2.id;
                    this.discriminator = u2.discriminator;
                    this.avatar = u2.avatar;
                    break;
            }
        }
    }
}
