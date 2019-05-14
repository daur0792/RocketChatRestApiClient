using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.IM
{
    public partial class ImOpenParam
    {
        [JsonProperty("roomId")]
        public string RoomId { get; set; }
    }

    public partial class ImOpenResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}