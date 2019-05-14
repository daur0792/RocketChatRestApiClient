using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Group
{
    public partial class DeleteGroupParam
    {
        [JsonProperty("roomName")]
        public string RoomName { get; set; }
    }

    public partial class DeleteGroupResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}