using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.IM
{
    public partial class ImMessagesResult
    {
        [JsonProperty("messages")]
        public MessageImMessages[] Messages { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class MessageImMessages
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
        public UImMessages U { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("mentions")]
        public object[] Mentions { get; set; }

        [JsonProperty("channels")]
        public object[] Channels { get; set; }
    }

    public partial class UImMessages
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}