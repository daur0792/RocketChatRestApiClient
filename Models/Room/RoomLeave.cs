using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Room
{
    public partial class RoomLeaveParam
    {
        [JsonProperty("roomId")]
        public string RoomId { get; set; }
    }

    public partial class RoomLeaveResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}