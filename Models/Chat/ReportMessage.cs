using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Chat
{
    public partial class ReportMessageParam
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public partial class ReportMessageResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}