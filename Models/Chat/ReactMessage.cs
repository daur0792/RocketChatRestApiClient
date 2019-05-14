using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Chat
{
    public partial class ReactMessageParam
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("emoji")]
        public string Emoji { get; set; }

        [JsonProperty("shouldReact")]
        public bool ShouldReact { get; set; }
    }

    public partial class ReactMessageResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}