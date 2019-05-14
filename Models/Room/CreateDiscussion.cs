using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Room
{
    public partial class RoomCreateDiscussionParam
    {
        [JsonProperty("prid")]
        public string Prid { get; set; }

        [JsonProperty("t_name")]
        public string TName { get; set; }
    }

    public partial class RoomCreateDiscussionResult
    {
        [JsonProperty("discussion")]
        public DiscussionRoomCreateDiscussion Discussion { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class DiscussionRoomCreateDiscussion
    {
        [JsonProperty("rid")]
        public string Rid { get; set; }

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
        public UDiscussionRoomCreate U { get; set; }

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

        [JsonProperty("_id")]
        public string Id { get; set; }
    }

    public partial class UDiscussionRoomCreate
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}