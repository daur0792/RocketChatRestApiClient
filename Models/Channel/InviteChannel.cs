using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Channel
{
    public partial class InviteChannelParam
    {
        [JsonProperty("roomId")]
        public string RoomId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public partial class InviteChannelResult
    {
        [JsonProperty("channel")]
        public ChannelInviteChannel Channel { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class ChannelInviteChannel
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

        [JsonProperty("msgs")]
        public long Msgs { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("lm")]
        public DateTimeOffset Lm { get; set; }
    }
}