using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Chat
{
    public partial class StarMessageParam
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }
    }

    public partial class StarMessageResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}