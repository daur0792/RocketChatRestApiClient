using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Room
{
    public partial class RoomCleanHistoryParam
    {
        [JsonProperty("roomId")]
        public string RoomId { get; set; }

        [JsonProperty("latest")]
        public DateTimeOffset Latest { get; set; }

        [JsonProperty("oldest")]
        public DateTimeOffset Oldest { get; set; }
    }

    public partial class RoomCleanHistoryResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}