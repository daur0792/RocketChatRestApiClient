using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Room
{
    public partial class GetRoomsResult
    {
        [JsonProperty("update")]
        public Update[] Update { get; set; }

        [JsonProperty("remove")]
        public object[] Remove { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class Update
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("t")]
        public string T { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default { get; set; }

        [JsonProperty("fname", NullValueHandling = NullValueHandling.Ignore)]
        public string Fname { get; set; }

        [JsonProperty("u", NullValueHandling = NullValueHandling.Ignore)]
        public U U { get; set; }

        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public CustomFields CustomFields { get; set; }

        [JsonProperty("ro", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ro { get; set; }
    }

    public partial class CustomFields
    {
    }

    public partial class U
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}