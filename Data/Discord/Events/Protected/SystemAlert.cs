using System;
using System.Collections.Generic;
using System.Text;

namespace TDSBF.Data.Discord.Events.Protected
{
    public class SystemAlert : EventArgs
    {
        
        private readonly string message;

        public SystemAlert(string message)
        {
            this.message = message;
        }

        public string Message
        {
            get { return this.message; }
        }
    }
}
