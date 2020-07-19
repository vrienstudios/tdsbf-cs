using System;
using System.Collections.Generic;
using System.Text;
using TDSBF.Data.Discord.Events.Protected;
using TDSBF.Data.Discord.Events.Protected.MessageEvents;

namespace TDSBF
{
    public static class Events
    {
        public static event OnMessageHandler OnMessageRecieve;
        public static void OnMessageRecieveFire(MessageAlert e) //::Fire();
        {
            if (OnMessageRecieve != null)
                OnMessageRecieve(e);
        }
        public delegate void OnMessageHandler(MessageAlert e);


    }
}
