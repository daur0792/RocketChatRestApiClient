using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Authentication
{
    public partial class LoginParam
    {
        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }

    public partial class LoginResult
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("authToken")]
        public string AuthToken { get; set; }

        [JsonProperty("me")]
        public Me Me { get; set; }
    }

    public partial class Me
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emails")]
        public Email[] Emails { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusConnection")]
        public string StatusConnection { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("utcOffset")]
        public long UtcOffset { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("settings")]
        public Settings Settings { get; set; }
    }

    public partial class Email
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }
    }

    public partial class Settings
    {
        [JsonProperty("preferences")]
        public Preferences Preferences { get; set; }
    }

    public partial class Preferences
    {
        [JsonProperty("enableAutoAway")]
        public bool EnableAutoAway { get; set; }

        [JsonProperty("idleTimeLimit")]
        public long IdleTimeLimit { get; set; }

        [JsonProperty("desktopNotificationDuration")]
        public long DesktopNotificationDuration { get; set; }

        [JsonProperty("audioNotifications")]
        public string AudioNotifications { get; set; }

        [JsonProperty("desktopNotifications")]
        public string DesktopNotifications { get; set; }

        [JsonProperty("mobileNotifications")]
        public string MobileNotifications { get; set; }

        [JsonProperty("unreadAlert")]
        public bool UnreadAlert { get; set; }

        [JsonProperty("useEmojis")]
        public bool UseEmojis { get; set; }

        [JsonProperty("convertAsciiEmoji")]
        public bool ConvertAsciiEmoji { get; set; }

        [JsonProperty("autoImageLoad")]
        public bool AutoImageLoad { get; set; }

        [JsonProperty("saveMobileBandwidth")]
        public bool SaveMobileBandwidth { get; set; }

        [JsonProperty("collapseMediaByDefault")]
        public bool CollapseMediaByDefault { get; set; }

        [JsonProperty("hideUsernames")]
        public bool HideUsernames { get; set; }

        [JsonProperty("hideRoles")]
        public bool HideRoles { get; set; }

        [JsonProperty("hideFlexTab")]
        public bool HideFlexTab { get; set; }

        [JsonProperty("hideAvatars")]
        public bool HideAvatars { get; set; }

        [JsonProperty("sidebarGroupByType")]
        public bool SidebarGroupByType { get; set; }

        [JsonProperty("sidebarViewMode")]
        public string SidebarViewMode { get; set; }

        [JsonProperty("sidebarHideAvatar")]
        public bool SidebarHideAvatar { get; set; }

        [JsonProperty("sidebarShowUnread")]
        public bool SidebarShowUnread { get; set; }

        [JsonProperty("sidebarShowFavorites")]
        public bool SidebarShowFavorites { get; set; }

        [JsonProperty("sendOnEnter")]
        public string SendOnEnter { get; set; }

        [JsonProperty("messageViewMode")]
        public long MessageViewMode { get; set; }

        [JsonProperty("emailNotificationMode")]
        public string EmailNotificationMode { get; set; }

        [JsonProperty("roomCounterSidebar")]
        public bool RoomCounterSidebar { get; set; }

        [JsonProperty("newRoomNotification")]
        public string NewRoomNotification { get; set; }

        [JsonProperty("newMessageNotification")]
        public string NewMessageNotification { get; set; }

        [JsonProperty("muteFocusedConversations")]
        public bool MuteFocusedConversations { get; set; }

        [JsonProperty("notificationsSoundVolume")]
        public long NotificationsSoundVolume { get; set; }
    }
}
