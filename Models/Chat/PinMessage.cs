using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Chat
{
    public partial class PinMessageParam
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }
    }

    public partial class PinMessageResult
    {
        [JsonProperty("message")]
        public MessagePinMessage Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class MessagePinMessage
    {
        [JsonProperty("t")]
        public string T { get; set; }

        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("ts")]
        public DateTimeOffset Ts { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("u")]
        public UPinMessage U { get; set; }

        [JsonProperty("groupable")]
        public bool Groupable { get; set; }

        [JsonProperty("attachments")]
        public Attachment[] Attachments { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }
    }

    public partial class Attachment
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        [JsonProperty("author_icon")]
        public string AuthorIcon { get; set; }

        [JsonProperty("ts")]
        public DateTimeOffset Ts { get; set; }
    }

    public partial class UPinMessage
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}