using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Authentication
{
    public partial class LogoutResult
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
