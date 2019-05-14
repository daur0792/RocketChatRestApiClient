using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Group
{
    public partial class GroupInfoResult
    {
        [JsonProperty("group")]
        public GroupGroupInfo Group { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class GroupGroupInfo
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("ts")]
        public DateTimeOffset Ts { get; set; }

        [JsonProperty("t")]
        public string T { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("usernames")]
        public string[] Usernames { get; set; }

        [JsonProperty("u")]
        public UGroupInfo U { get; set; }

        [JsonProperty("msgs")]
        public long Msgs { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("lm")]
        public DateTimeOffset Lm { get; set; }
    }

    public partial class UGroupInfo
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

}