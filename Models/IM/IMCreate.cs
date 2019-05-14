using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.IM
{
    public partial class ImCreateParam
    {
        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public partial class ImCreateResult
    {
        [JsonProperty("room")]
        public Room Room { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class Room
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

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("$loki")]
        public long Loki { get; set; }

        [JsonProperty("usernames")]
        public string[] Usernames { get; set; }
    }

    public partial class Meta
    {
        [JsonProperty("revision")]
        public long Revision { get; set; }

        [JsonProperty("created")]
        public long Created { get; set; }

        [JsonProperty("version")]
        public long Version { get; set; }
    }
}