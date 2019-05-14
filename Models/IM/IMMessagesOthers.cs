using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.IM
{
    public partial class ImMessagesOthersResult
    {
        [JsonProperty("messages")]
        public MessageImMessagesOthers[] Messages { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class MessageImMessagesOthers
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("ts")]
        public DateTimeOffset Ts { get; set; }

        [JsonProperty("u")]
        public UImMessagesOthers U { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("t", NullValueHandling = NullValueHandling.Ignore)]
        public string T { get; set; }

        [JsonProperty("groupable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Groupable { get; set; }
    }

    public partial class UImMessagesOthers
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}