using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Room
{
    public partial class RoomGetDiscussionsResult
    {
        [JsonProperty("discussions")]
        public Discussion[] Discussions { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class Discussion
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fname")]
        public string Fname { get; set; }

        [JsonProperty("t")]
        public string T { get; set; }

        [JsonProperty("msgs")]
        public long Msgs { get; set; }

        [JsonProperty("usersCount")]
        public long UsersCount { get; set; }

        [JsonProperty("u")]
        public DiscussionU U { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("prid")]
        public string Prid { get; set; }

        [JsonProperty("ts")]
        public DateTimeOffset Ts { get; set; }

        [JsonProperty("ro")]
        public bool Ro { get; set; }

        [JsonProperty("sysMes")]
        public bool SysMes { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("lastMessage")]
        public LastMessage LastMessage { get; set; }

        [JsonProperty("lm")]
        public DateTimeOffset Lm { get; set; }
    }

    public partial class LastMessage
    {
        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("ts")]
        public DateTimeOffset Ts { get; set; }

        [JsonProperty("u")]
        public LastMessageU U { get; set; }

        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("mentions")]
        public object[] Mentions { get; set; }

        [JsonProperty("channels")]
        public object[] Channels { get; set; }
    }

    public partial class LastMessageU
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class DiscussionU
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}