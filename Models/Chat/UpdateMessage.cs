using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Chat
{
    public partial class UpdateMessageParam
    {
        [JsonProperty("roomId")]
        public string RoomId { get; set; }

        [JsonProperty("msgId")]
        public string MsgId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public partial class UpdateMessageResult
    {
        [JsonProperty("message")]
        public MessageUpdateMessage Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class MessageUpdateMessage
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
        public EditedBy U { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("editedAt")]
        public DateTimeOffset EditedAt { get; set; }

        [JsonProperty("editedBy")]
        public EditedBy EditedBy { get; set; }
    }

    public partial class EditedBy
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}