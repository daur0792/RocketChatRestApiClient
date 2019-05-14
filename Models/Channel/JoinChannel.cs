using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Channel
{
    public partial class JoinChannelParam
    {
        [JsonProperty("roomId")]
        public string RoomId { get; set; }

        [JsonProperty("joinCode")]
        public string JoinCode { get; set; }
    }

    public partial class JoinChannelResult
    {
        [JsonProperty("channel")]
        public ChannelJoinChannel Channel { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class ChannelJoinChannel
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
        public UChannelJoin U { get; set; }

        [JsonProperty("customFields")]
        public CustomFields CustomFields { get; set; }

        [JsonProperty("broadcast")]
        public bool Broadcast { get; set; }

        [JsonProperty("encrypted")]
        public bool Encrypted { get; set; }

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

        [JsonProperty("joinCodeRequired")]
        public bool JoinCodeRequired { get; set; }
    }

    public partial class CustomFields
    {
    }

    public partial class UChannelJoin
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}