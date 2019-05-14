using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.User
{
    public partial class CreateUserParam
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("customFields")]
        public CustomFields CustomFields { get; set; }
    }

    public partial class CustomFields
    {
        [JsonProperty("twitter")]
        public string Twitter { get; set; }
    }

    public partial class CreateUserResult
    {
        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class User
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("services")]
        public Services Services { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("emails")]
        public Email[] Emails { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("customFields")]
        public CustomFields CustomFields { get; set; }
    }

    //public partial class CustomFields
    //{
    //    [JsonProperty("twitter")]
    //    public string Twitter { get; set; }
    //}

    public partial class Email
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }
    }

    public partial class Services
    {
        [JsonProperty("password")]
        public Password Password { get; set; }
    }

    public partial class Password
    {
        [JsonProperty("bcrypt")]
        public string Bcrypt { get; set; }
    }
}
