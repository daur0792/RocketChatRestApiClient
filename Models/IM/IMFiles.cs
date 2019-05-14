using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.IM
{
    public partial class ImFilesResult
    {
        [JsonProperty("files")]
        public File[] Files { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class File
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("store")]
        public string Store { get; set; }

        [JsonProperty("complete")]
        public bool Complete { get; set; }

        [JsonProperty("uploading")]
        public bool Uploading { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("progress")]
        public long Progress { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("instanceId")]
        public string InstanceId { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("uploadedAt")]
        public DateTimeOffset UploadedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class User
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}