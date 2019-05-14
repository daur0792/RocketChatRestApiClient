using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Room
{
    public partial class RoomFavoriteParam
    {
        [JsonProperty("roomId")]
        public string RoomId { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }
    }

    public partial class RoomFavoriteResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}