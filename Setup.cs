using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using WebSocketSharp;
using TDSBF.Extensions;
using System.Diagnostics;
using TDSBF.Data;
using Newtonsoft.Json;
using TDSBF.Data.Discord;
using TDSBF.Data.Discord.Web;
using System.Threading;
using TDSBF.Data.Discord.Authentication;
//#define true TRUE
namespace TDSBF
{
    public class Totality
    {
        public String GetToken { get { return Data.Storage.Token; } }
        public User GetCurrentUser { get { return Storage.ReadyEvent.d.user; } }
        private Boolean SetReadyState { get; set; }
        public Boolean GetReadyState { get { return SetReadyState; } }

        private Boolean WebSocketConnect(int timeout) //unsigned
        {
            int attempts = 0;
            while(attempts < timeout)
            {
                try { 
                    Data.Storage.ws.Connect();
                }
                catch {
                    Data.Storage.TDSBFMessage = String.Format("1 Failed to connect, retrying: {0}/{1}", attempts, timeout);
                }
                attempts++;
                }
            return attempts > timeout ? false : true;
        }

        public void Setup(String token, TokenType tokenType) //std::string
        {
            Data.Storage.Token = token;
            Thread wsThread = new Thread(() => WsInit()); //std::function wsThr;
            GToken.tokenType = tokenType;
            wsThread.Name = "wsThread_0";

            wsThread.Start();
            Thread.Sleep(100);
            while (!Storage.ws.IsConnected)
                Thread.Sleep(100);
        }

        public void Setup(String token) //std::string
        {
            Data.Storage.Token = token;
            Thread wsThread = new Thread(() => WsInit()); //std::function wsThr;
            wsThread.Name = "wsThread_0";

            wsThread.Start();
            Thread.Sleep(100);
            while (!Storage.ws.IsConnected)
                Thread.Sleep(100);
        }

        private void WsInit() //&Websocket
        {
            Data.Storage.ws = new WebSocket("wss://gateway.discord.gg/?v=6&encoding=json");
            Data.Storage.op2 = Data.Storage.op2.ReplaceMultiple(new string[] { "&1", Data.Storage.Token, "&2", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString() });
            Data.Storage.client = new System.Net.Http.HttpClient();
            Data.Storage.client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", $"{GToken.GetTokenType}{Data.Storage.Token}"); // Discord authenticats via token

            Data.Storage.TDSBFMessage = "2 Connecting";
            Storage.ws.Connect();
            Data.Storage.TDSBFMessage = "3 Connected";
            Data.Storage.ws.OnOpen += Ws_OnOpen;
            Data.Storage.ws.OnMessage += Ws_OnMessage;
            Data.Storage.ws.OnClose += Ws_OnClose;
        }

        private void Ws_OnClose(object sender, CloseEventArgs e)
        {
            Storage.TDSBFMessage = String.Format("{0}::{1}", e.Code, e.Reason);
        }

        static ReadyEvent Parse(string data)
        {
            try
            {
                ReadyEvent RO = JsonConvert.DeserializeObject<ReadyEvent>(data);
                return RO;
            }
            catch
            {
                return null;
            }
        }

        private void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            ReadyEvent RE = Parse(e.Data);
            while(RE != null)
            {
                if (!Storage.Continue)
                {
                    switch (RE.op)
                    {
                        case 10:
                            HeartBeat heart = JsonConvert.DeserializeObject<HeartBeat>(e.Data);
                            Thread thr = new Thread(() => Functions.PostOp1(heart.d.heartbeat_interval));
                            thr.Start();
                            Storage.ws.Send(Storage.op2);
                            Storage.ReadyEvent = null;
                            Storage.Continue = true;
                            break;
                    }
                    break;
                }
                else
                {
                    switch (RE.t) // T is the name of the event.
                    {
                        case "READY":
                            Storage.TDSBFMessage = "Ready event recieved";
                            Storage.ReadyEventRecieved = true; // I wish true equaled TRUE .__.
                            Storage.ReadyEvent = RE;
                            SetReadyState = true;
                            RE = null;
                            break;
                        case "MESSAGE_CREATE":
                            Data.Discord.MessageClasses.Message.MessageRootObj message = JsonConvert.DeserializeObject<Data.Discord.MessageClasses.Message.MessageRootObj>(e.Data);
                            Data.Discord.Events.Protected.MessageEvents.OnMessageRecieved.Message = message.d;
                            RE = null;
                            break;
                        default:
                            RE = null;
                            break;
                    }
                }
            }
        }

        private void Ws_OnOpen(object sender, EventArgs e)
        {
            Storage.ws.Send(Storage.op1);
        }

        ~Totality()
        {
            //TODO: Write destructor.
        }
    }
}
