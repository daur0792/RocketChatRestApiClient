using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Chat
{
    public partial class GetMessageResult
    {
        [JsonProperty("message")]
        public MessageGetMessage Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class MessageGetMessage
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("ts")]
        public DateTimeOffset Ts { get; set; }

        [JsonProperty("u")]
        public UGetMessage U { get; set; }
    }

    public partial class UGetMessage
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}