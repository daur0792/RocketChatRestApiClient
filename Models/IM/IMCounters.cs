using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.IM
{
    public partial class ImCountersResult
    {
        [JsonProperty("joined")]
        public bool Joined { get; set; }

        [JsonProperty("members")]
        public long Members { get; set; }

        [JsonProperty("unreads")]
        public long Unreads { get; set; }

        [JsonProperty("unreadsFrom")]
        public DateTimeOffset UnreadsFrom { get; set; }

        [JsonProperty("msgs")]
        public long Msgs { get; set; }

        [JsonProperty("latest")]
        public DateTimeOffset Latest { get; set; }

        [JsonProperty("userMentions")]
        public long UserMentions { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}