using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.User
{
    public partial class SetActiveStatusParam
    {
        [JsonProperty("activeStatus")]
        public bool ActiveStatus { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public partial class SetActiveStatusResult
    {
        [JsonProperty("user")]
        public UserSetActiveStatus User { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class UserSetActiveStatus
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }
}
