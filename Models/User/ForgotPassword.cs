using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.User
{
    public partial class ForgotPasswordParam
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public partial class ForgotPasswordResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
