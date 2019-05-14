using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.User
{
    public partial class CreateUserTokenParam
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public partial class CreateUserTokenResult
    {
        [JsonProperty("data")]
        public DataCreateUserToken Data { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class DataCreateUserToken
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("authToken")]
        public string AuthToken { get; set; }
    }
}
