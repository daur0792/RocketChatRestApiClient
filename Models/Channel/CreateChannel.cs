using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Channel
{
    public partial class CreateChannelParam
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class CreateChannelResult
    {
        [JsonProperty("channel")]
        public Channel Channel { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class Channel
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("t")]
        public string T { get; set; }

        [JsonProperty("usernames")]
        public string[] Usernames { get; set; }

        [JsonProperty("msgs")]
        public long Msgs { get; set; }

        [JsonProperty("u")]
        public U U { get; set; }

        [JsonProperty("ts")]
        public DateTimeOffset Ts { get; set; }
    }

    public partial class U
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}