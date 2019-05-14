using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Channel
{
    public partial class DeleteChannelParam
    {
        [JsonProperty("roomName")]
        public string RoomName { get; set; }
    }

    public partial class DeleteChannelResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}