using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Chat
{
    public partial class GetMessageReadReceiptsResult
    {
        [JsonProperty("receipts")]
        public Receipt[] Receipts { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class Receipt
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("roomId")]
        public string RoomId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("ts")]
        public DateTimeOffset Ts { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public partial class User
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }
    }
}