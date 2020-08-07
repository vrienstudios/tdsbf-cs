using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TDSBF.Data.Discord.Authentication
{
    public enum TokenType
    {
        Bot = 0,
        Bearer = 1,
    }
    public static class GToken
    {
        public static TokenType? tokenType;
        public static String GetTokenType
        {
            get
            {
                return tokenType != null ? tokenType == 0 ? "Bot " : "Bearer " : null;
            }
        }
    }
}
