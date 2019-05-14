using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Chat
{
    public partial class DeleteChatMessageParam
    {
        [JsonProperty("roomId")]
        public string RoomId { get; set; }

        [JsonProperty("msgId")]
        public string MsgId { get; set; }

        [JsonProperty("asUser")]
        public bool AsUser { get; set; }
    }

    public partial class DeleteChatMessageResult
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("ts")]
        public long Ts { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}