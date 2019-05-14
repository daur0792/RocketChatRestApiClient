using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Channel
{
    public partial class ChannelMessagesResult
    {
        [JsonProperty("messages")]
        public Message[] Messages { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class Message
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("t", NullValueHandling = NullValueHandling.Ignore)]
        public string T { get; set; }

        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("ts")]
        public DateTimeOffset Ts { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("u")]
        public UMessage U { get; set; }

        [JsonProperty("groupable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Groupable { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("mentions", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Mentions { get; set; }

        [JsonProperty("channels", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Channels { get; set; }
    }

    public partial class UMessage
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}