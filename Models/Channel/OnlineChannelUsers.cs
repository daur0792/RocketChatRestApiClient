using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Channel
{
    public partial class OnlineChannelUsersResult
    {
        [JsonProperty("online")]
        public Online[] Online { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class Online
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}