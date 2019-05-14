using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Group
{
    public partial class GroupKickParam
    {
        [JsonProperty("roomId")]
        public string RoomId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public partial class GroupKickResult
    {
        [JsonProperty("group")]
        public GroupGroupKick Group { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class GroupGroupKick
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
        public UGroupKick U { get; set; }

        [JsonProperty("ts")]
        public DateTimeOffset Ts { get; set; }

        [JsonProperty("ro")]
        public bool Ro { get; set; }

        [JsonProperty("sysMes")]
        public bool SysMes { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }
    }

    public partial class UGroupKick
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}