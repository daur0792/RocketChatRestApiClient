using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.IM
{
    public partial class ImSetTopicParam
    {
        [JsonProperty("roomId")]
        public string RoomId { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }
    }

    public partial class ImSetTopicResult
    {
        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}