using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Group
{
    public partial class GroupLeaveParam
    {
        [JsonProperty("roomId")]
        public string RoomId { get; set; }
    }

    public partial class GroupLeaveResult
    {
        [JsonProperty("group")]
        public GroupGroupLeave Group { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class GroupGroupLeave
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
        public UGroupLeave U { get; set; }

        [JsonProperty("ts")]
        public DateTimeOffset Ts { get; set; }

        [JsonProperty("ro")]
        public bool Ro { get; set; }

        [JsonProperty("sysMes")]
        public bool SysMes { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }
    }

    public partial class UGroupLeave
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}