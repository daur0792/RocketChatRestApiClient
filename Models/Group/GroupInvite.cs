using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Group
{
    public partial class GroupInviteParam
    {
        [JsonProperty("roomId")]
        public string RoomId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public partial class GroupInviteResult
    {
        [JsonProperty("group")]
        public GroupGroupInvite Group { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class GroupGroupInvite
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
        public UGroupInvite U { get; set; }

        [JsonProperty("msgs")]
        public long Msgs { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("lm")]
        public DateTimeOffset Lm { get; set; }
    }

    public partial class UGroupInvite
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}