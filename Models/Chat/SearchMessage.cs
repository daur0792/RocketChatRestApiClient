using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Chat
{
    public partial class SearchMessageResult
    {
        [JsonProperty("messages")]
        public MessageSearchMessage[] Messages { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class MessageSearchMessage
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
        public USearchMessage U { get; set; }

        [JsonProperty("mentions")]
        public object[] Mentions { get; set; }

        [JsonProperty("channels")]
        public object[] Channels { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public partial class USearchMessage
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}