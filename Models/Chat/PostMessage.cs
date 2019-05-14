using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Chat
{
    public partial class PostMessageParam
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public partial class PostMessageResult
    {
        [JsonProperty("ts")]
        public long Ts { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("message")]
        public MessagePostMessage Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class MessagePostMessage
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("parseUrls")]
        public bool ParseUrls { get; set; }

        [JsonProperty("groupable")]
        public bool Groupable { get; set; }

        [JsonProperty("ts")]
        public DateTimeOffset Ts { get; set; }

        [JsonProperty("u")]
        public UPostMessage U { get; set; }

        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }
    }

    public partial class UPostMessage
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}