using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.IM
{
    public partial class ImCloseParam
    {
        [JsonProperty("roomId")]
        public string RoomId { get; set; }
    }

    public partial class ImCloseResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}