using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.User
{
    public partial class DeleteUserParam
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public partial class DeleteUserResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
