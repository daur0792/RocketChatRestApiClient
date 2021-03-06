﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Group
{
    public partial class CloseGroupParam
    {
        [JsonProperty("roomId")]
        public string RoomId { get; set; }
    }

    public partial class CloseGroupResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}