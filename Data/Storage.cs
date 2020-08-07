using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using TDSBF.Data.Discord;
using TDSBF.Data.Discord.Events.Protected;
using WebSocketSharp;

namespace TDSBF.Data
{
    public static class Storage
    {
        public static Boolean ReadyEventRecieved = false;
        public static Boolean Continue = false;
        public static Boolean ThrowExcept = true;
        public static string Token = string.Empty;
        private static string _TDSBFMessage { get; set; }
        public static string TDSBFMessage { get { return _TDSBFMessage; } set { _TDSBFMessage = value; OnSystemAlert(new SystemAlert(value)); } }
        public static string op2 = @"{""op"": 2, ""d"": { ""token"": ""&1"", ""properties"": { ""$os"": ""linux"", ""$browser"": ""etzyy - wrapper"", ""$device"": ""tdsbf"" }, ""compress"": false, ""large_threshold"": 250, ""status"": ""online"", ""since"": &2, ""afk"": false} }";
        public static WebSocket ws;
        public static ReadyEvent ReadyEvent { get; set; }
        public static HttpClient client = new HttpClient();
        public static HttpRequestMessage req = new HttpRequestMessage();


        // Readonly
        public static readonly string op1 = @"{""op"": 1, ""d"": 251}"; // ""presence"": { ""game"": { ""name"": ""test"", ""type"": 0 } }



        static void OnSystemAlert(SystemAlert e)
        {
            if (SysAlert != null)
                SysAlert(e);
        }
        public delegate void SysAlertHandler(SystemAlert e);
        public static event SysAlertHandler SysAlert;
    }
}
