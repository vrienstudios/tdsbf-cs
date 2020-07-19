using System;

namespace TDSBF.Data.Discord.Events.Protected.MessageEvents
{
    static class OnMessageParameters
    {
        public static MessageParamEnum MessageParameters;
        private static Boolean? limitChannel;
        private static Boolean? limitGuild;
        private static Boolean? customParams;
    }
}
