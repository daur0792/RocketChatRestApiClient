using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.User
{
    public partial class UpdateUserParam
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public partial class UpdateUserResult
    {
        [JsonProperty("user")]
        public UserUpdateUser User { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class UserUpdateUser
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("services")]
        public ServicesUserUpdate Services { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("emails")]
        public EmailUpdateUser[] Emails { get; set; }

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
        public CustomFieldsUpdateUser CustomFields { get; set; }
    }

    public partial class CustomFieldsUpdateUser
    {
        [JsonProperty("twitter")]
        public string Twitter { get; set; }
    }

    public partial class EmailUpdateUser
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }
    }

    public partial class ServicesUserUpdate
    {
        [JsonProperty("password")]
        public PasswordUserUpdate Password { get; set; }
    }

    public partial class PasswordUserUpdate
    {
        [JsonProperty("bcrypt")]
        public string Bcrypt { get; set; }
    }
}
