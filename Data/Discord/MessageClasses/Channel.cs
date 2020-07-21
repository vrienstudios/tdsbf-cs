using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace TDSBF.Data.Discord.MessageClasses
{
    public class Channel
    {
        public int type { get; set; }
        public string topic { get; set; }
        public int rate_limit_per_user { get; set; }
        public int position { get; set; }
        public List<object> permission_overwrites { get; set; }
        public string parent_id { get; set; }
        public bool nsfw { get; set; }
        public string name { get; set; }
        public string last_message_id { get; set; }
        public string id { get; set; }
        public int? user_limit { get; set; }
        public int? bitrate { get; set; }
        public DateTime? last_pin_timestamp { get; set; }

        //{"content":"send","nonce":"733875035466366976","tts":false}
        private class Message
        {
            public String content { get; set; }
            //public String none { get; set; } message ID
            public Boolean? tts { get; set; }

            public Message(string content, bool? tts)
            {
                this.content = content;
                this.tts = tts;
            }

        }

        /// <summary>
        /// Gets n number of messages from channel.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public MessageClasses.Message[] GetPastMessagesArray(int amount)
        {
            System.Threading.Tasks.Task<HttpResponseMessage> response = Storage.client.GetAsync(string.Format("https://discordapp.com/api/v6/channels/{0}/messages?limit={1}", this.id, amount.ToString()));
            if (!response.Result.IsSuccessStatusCode)
                throw new Exception();
            System.Threading.Tasks.Task<string> str = response.Result.Content.ReadAsStringAsync();
            return new List<MessageClasses.Message>(JsonConvert.DeserializeObject<List<MessageClasses.Message>>(str.Result)).ToArray().Reverse().ToArray();
        }

        /// <summary>
        /// Gets n number of messages from channel.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public List<MessageClasses.Message> GetPastMessagesList(int amount)
        {
            System.Threading.Tasks.Task<HttpResponseMessage> response = Storage.client.GetAsync(string.Format("https://discordapp.com/api/v6/channels/{0}/messages?limit={1}", this.id, amount.ToString()));
            if (!response.Result.IsSuccessStatusCode)
                throw new Exception();
            System.Threading.Tasks.Task<string> str = response.Result.Content.ReadAsStringAsync();
            return new List<MessageClasses.Message>(JsonConvert.DeserializeObject<List<MessageClasses.Message>>(str.Result)).ToArray().Reverse().ToList();
        }

        /// <summary>
        /// Post message to channel
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public Boolean PostMessage(String content, Boolean? tts)
        {
            StringContent data = new StringContent(JsonConvert.SerializeObject(new Message(content, tts)), UnicodeEncoding.UTF8, "application/json");
            System.Threading.Tasks.Task<HttpResponseMessage> response = Storage.client.PostAsync(string.Format("https://discordapp.com/api/v6/channels/{0}/messages", this.id), data);
            if (!response.Result.IsSuccessStatusCode)
                return false;
            return true;
        }
    }
}
