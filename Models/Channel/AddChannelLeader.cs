using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Channel
{
    public partial class AddChannelLeaderParam
    {
        [JsonProperty("roomId")]
        public string RoomId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public partial class AddChannelLeaderResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}