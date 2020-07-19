using System.Threading;
using TDSBF.Data;

namespace TDSBF
{
    public static class Functions
    {
        public static void PostOp1(int heartbeat_interval)
        {
            while (true)
            {
                Storage.ws.Send(Storage.op1);
                Thread.Sleep(heartbeat_interval);
            }
        }
    }
}
