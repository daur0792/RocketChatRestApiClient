using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Chat
{
    public partial class SendMessageParam
    {
        [JsonProperty("message")]
        public MessageSendMessage Message { get; set; }
    }

    public partial class MessageSendMessage
    {
        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("emoji")]
        public string Emoji { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        [JsonProperty("attachments")]
        public AttachmentSendMessage[] Attachments { get; set; }
    }

    public partial class AttachmentSendMessage
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("ts")]
        public DateTimeOffset Ts { get; set; }

        [JsonProperty("thumb_url")]
        public Uri ThumbUrl { get; set; }

        [JsonProperty("message_link")]
        public Uri MessageLink { get; set; }

        [JsonProperty("collapsed")]
        public bool Collapsed { get; set; }

        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        [JsonProperty("author_link")]
        public Uri AuthorLink { get; set; }

        [JsonProperty("author_icon")]
        public Uri AuthorIcon { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("title_link")]
        public Uri TitleLink { get; set; }

        [JsonProperty("title_link_download")]
        public bool TitleLinkDownload { get; set; }

        [JsonProperty("image_url")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("audio_url")]
        public Uri AudioUrl { get; set; }

        [JsonProperty("video_url")]
        public Uri VideoUrl { get; set; }

        [JsonProperty("fields")]
        public Field[] Fields { get; set; }
    }

    public partial class Field
    {
        [JsonProperty("short")]
        public bool Short { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class SendMessageResult
    {
        [JsonProperty("message")]
        public MessageSendMessageResult Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public partial class MessageSendMessageResult
    {
        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("ts")]
        public DateTimeOffset Ts { get; set; }

        [JsonProperty("u")]
        public USendMessageResult U { get; set; }

        [JsonProperty("unread")]
        public bool Unread { get; set; }

        [JsonProperty("mentions")]
        public object[] Mentions { get; set; }

        [JsonProperty("channels")]
        public object[] Channels { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }
    }

    public partial class USendMessageResult
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}