using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.User
{
    public partial class UserListResult
    {
        [JsonProperty("users")]
        public UserList[] Users { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class UserList
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("utcOffset")]
        public long UtcOffset { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
