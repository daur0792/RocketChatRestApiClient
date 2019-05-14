using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.User
{
    public partial class UserInfoResult
    {
        [JsonProperty("user")]
        public UserInfo User { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class UserInfo
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
