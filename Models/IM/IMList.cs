using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.IM
{
    public partial class ImListResult
    {
        [JsonProperty("ims")]
        public Im[] Ims { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class Im
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("t")]
        public string T { get; set; }

        [JsonProperty("msgs")]
        public long Msgs { get; set; }

        [JsonProperty("ts")]
        public DateTimeOffset Ts { get; set; }

        [JsonProperty("lm")]
        public DateTimeOffset Lm { get; set; }

        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }
    }
}