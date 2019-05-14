using System;
using System.Collections.Generic;
using System.Text;
using Rocker.Chat.RestApiClient.Helpers;
using Rocker.Chat.RestApiClient.Models.Authentication;
using Rocker.Chat.RestApiClient.Models.Channel;
using Rocker.Chat.RestApiClient.Models.Chat;
using Rocker.Chat.RestApiClient.Models.Group;
using Rocker.Chat.RestApiClient.Models.IM;
using Rocker.Chat.RestApiClient.Models.Room;
using Rocker.Chat.RestApiClient.Models.User;

namespace Rocker.Chat.RestApiClient.Core
{
    public class RocketChatClient
    {
        private RestHelper _restHelper;
        private Dictionary<string, string> _headers;

        public RocketChatClient(string url)
        {
            _restHelper = new RestHelper(url);
            _headers = new Dictionary<string, string>();
        }

        #region Authentication

        public LoginResult Login(string username, string password)
        {
            var result = _restHelper.Post<LoginParam, LoginResult>("/api/v1/login", new LoginParam()
            {
                User = username,
                Password = password
            });

            _headers.Remove("X-Auth-Token");
            _headers.Remove("X-User-Id");
            _headers.Add("X-Auth-Token", result.Data.AuthToken);
            _headers.Add("X-User-Id", result.Data.UserId);

            return result;
        }

        public LogoutResult Logout()
        {
            var result = _restHelper.Post<LogoutResult>("/api/v1/logout", _headers);

            _headers.Remove("X-Auth-Token");
            _headers.Remove("X-User-Id");
            return result;
        }
        #endregion

        #region Users

        public CreateUserResult CreateUser(CreateUserParam createUserParam)
        {
            var result = _restHelper.Post<CreateUserParam, CreateUserResult>("/api/v1/users.create", createUserParam, _headers);
            return result;
        }

        public UpdateUserResult UpdateUser(UpdateUserParam updateUserParam)
        {
            var result = _restHelper.Post<UpdateUserParam, UpdateUserResult>("/api/v1/users.update", updateUserParam, _headers);
            return result;
        }

        public DeleteUserResult DeleteUser(DeleteUserParam deleteUserParam)
        {
            var result = _restHelper.Post<DeleteUserParam, DeleteUserResult>("/api/v1/users.delete", deleteUserParam, _headers);
            return result;
        }

        public UserListResult UserList()
        {
            var result = _restHelper.Get<UserListResult>("/api/v1/users.list", _headers);
            return result;
        }

        public ForgotPasswordResult ForgotPassword(ForgotPasswordParam forgotPasswordParam)
        {
            var result = _restHelper.Post<ForgotPasswordParam, ForgotPasswordResult>("/api/v1/users.forgotPassword", forgotPasswordParam, _headers);
            return result;
        }

        public UserInfoResult UserInfo(string userId)
        {
            if (!string.IsNullOrWhiteSpace(userId))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("userId", userId);
                var result = _restHelper.Get<UserInfoResult>("/api/v1/users.info", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("userId == null");
            }
        }

        public UserRegisterResult UserRegister(UserRegisterParam userRegisterParam)
        {
            var result = _restHelper.Post<UserRegisterParam, UserRegisterResult>("/api/v1/users.register", userRegisterParam, _headers);
            return result;
        }

        //TODO: Не работает нужно проверить
        //public SetActiveStatusResult SetActiveStatus(SetActiveStatusParam setActiveStatusParam)
        //{
        //    var result = _restHelper.Post<SetActiveStatusParam, SetActiveStatusResult>("/api/v1/users.setActiveStatus", setActiveStatusParam, _headers);
        //    return result;
        //}

        public CreateUserTokenResult CreateUserToken(CreateUserTokenParam createUserTokenParam)
        {
            var result = _restHelper.Post<CreateUserTokenParam, CreateUserTokenResult>("/api/v1/users.createToken", createUserTokenParam, _headers);
            return result;
        }

        #endregion

        #region Channel

        public CreateChannelResult CreateChannel(CreateChannelParam createChannelParam)
        {
            var result = _restHelper.Post<CreateChannelParam, CreateChannelResult>("/api/v1/channels.create", createChannelParam, _headers);
            return result;
        }

        public DeleteChannelResult DeleteChannel(DeleteChannelParam deleteChannelParam)
        {
            var result = _restHelper.Post<DeleteChannelParam, DeleteChannelResult>("/api/v1/channels.delete", deleteChannelParam, _headers);
            return result;
        }

        //TODO: Не работает нужно проверить
        //public AddChannelLeaderResult AddChannelLeader(AddChannelLeaderParam addChannelLeaderParam)
        //{
        //    var result = _restHelper.Post<AddChannelLeaderParam, AddChannelLeaderResult>("/api/v1/channels.addLeader", addChannelLeaderParam, _headers);
        //    return result;
        //}

        public OpenChannelResult OpenChannel(OpenChannelParam openChannelParam)
        {
            var result = _restHelper.Post<OpenChannelParam, OpenChannelResult>("/api/v1/channels.open", openChannelParam, _headers);
            return result;
        }

        public CloseChannelResult CloseChannel(CloseChannelParam closeChannelParam)
        {
            var result = _restHelper.Post<CloseChannelParam, CloseChannelResult>("/api/v1/channels.close", closeChannelParam, _headers);
            return result;
        }

        public ChannelListResult ChannelList()
        {
            var result = _restHelper.Get<ChannelListResult>("/api/v1/channels.list", _headers);
            return result;
        }

        public ChannelCountersResult ChannelCounters(string roomId)
        {
            if (!string.IsNullOrWhiteSpace(roomId))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("roomId", roomId);
                var result = _restHelper.Get<ChannelCountersResult>("/api/v1/channels.counters", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("roomId == null");
            }
        }

        public ChannelMessagesResult ChannelMessages(string roomId)
        {
            if (!string.IsNullOrWhiteSpace(roomId))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("roomId", roomId);
                var result = _restHelper.Get<ChannelMessagesResult>("/api/v1/channels.messages", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("roomId == null");
            }
        }

        public ChannelInfoResult ChannelInfo(string roomId)
        {
            if (!string.IsNullOrWhiteSpace(roomId))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("roomId", roomId);
                var result = _restHelper.Get<ChannelInfoResult>("/api/v1/channels.info", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("roomId == null");
            }
        }

        public InviteChannelResult InviteChannel(InviteChannelParam inviteChannelParam)
        {
            var result = _restHelper.Post<InviteChannelParam, InviteChannelResult>("/api/v1/channels.invite", inviteChannelParam, _headers);
            return result;
        }

        public ChannelKickResult ChannelKick(ChannelKickParam inviteChannelParam)
        {
            var result = _restHelper.Post<ChannelKickParam, ChannelKickResult>("/api/v1/channels.kick", inviteChannelParam, _headers);
            return result;
        }

        public JoinChannelResult JoinChannel(JoinChannelParam joinChannelParam)
        {
            var result = _restHelper.Post<JoinChannelParam, JoinChannelResult>("/api/v1/channels.join", joinChannelParam, _headers);
            return result;
        }

        public LeaveChannelResult LeaveChannel(LeaveChannelParam leaveChannelParam)
        {
            var result = _restHelper.Post<LeaveChannelParam, LeaveChannelResult>("/api/v1/channels.leave", leaveChannelParam, _headers);
            return result;
        }

        public ChannelMemberListResult ChannelMemberList(string roomId)
        {
            if (!string.IsNullOrWhiteSpace(roomId))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("roomId", roomId);
                var result = _restHelper.Get<ChannelMemberListResult>("/api/v1/channels.members", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("roomId == null");
            }
        }

        public OnlineChannelUsersResult OnlineChannelUsers()
        {
            //var queryParams = new Dictionary<string, string>();
            //queryParams.Add("roomId", roomId);
            var result = _restHelper.Get<OnlineChannelUsersResult>("/api/v1/channels.online", _headers
                //, queryParams
                );
            return result;
        }

        public RenameChannelResult RenameChannel(RenameChannelParam leaveChannelParam)
        {
            var result = _restHelper.Post<RenameChannelParam, RenameChannelResult>("/api/v1/channels.rename", leaveChannelParam, _headers);
            return result;
        }

        public SetChannelJoinCodeResult SetChannelJoinCode(SetChannelJoinCodeParam leaveChannelParam)
        {
            var result = _restHelper.Post<SetChannelJoinCodeParam, SetChannelJoinCodeResult>("/api/v1/channels.setJoinCode", leaveChannelParam, _headers);
            return result;
        }

        #endregion

        #region Group

        public CreateGroupResult CreateGroup(CreateGroupParam createGroupParam)
        {
            var result = _restHelper.Post<CreateGroupParam, CreateGroupResult>("/api/v1/groups.create", createGroupParam, _headers);
            return result;
        }

        public DeleteGroupResult DeleteGroup(DeleteGroupParam deleteGroupParam)
        {
            var result = _restHelper.Post<DeleteGroupParam, DeleteGroupResult>("/api/v1/groups.delete", deleteGroupParam, _headers);
            return result;
        }

        public CloseGroupResult CloseGroup(CloseGroupParam closeGroupParam)
        {
            var result = _restHelper.Post<CloseGroupParam, CloseGroupResult>("/api/v1/groups.close", closeGroupParam, _headers);
            return result;
        }

        public OpenGroupResult OpenGroup(OpenGroupParam openGroupParam)
        {
            var result = _restHelper.Post<OpenGroupParam, OpenGroupResult>("/api/v1/groups.open", openGroupParam, _headers);
            return result;
        }

        public GroupCountersResult GroupCounters(string roomId)
        {
            if (!string.IsNullOrWhiteSpace(roomId))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("roomId", roomId);
                var result = _restHelper.Get<GroupCountersResult>("/api/v1/groups.counters", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("roomId == null");
            }
        }

        public GroupInfoResult GroupInfo(string roomId)
        {
            if (!string.IsNullOrWhiteSpace(roomId))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("roomId", roomId);
                var result = _restHelper.Get<GroupInfoResult>("/api/v1/groups.info", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("roomId == null");
            }
        }

        public GroupInviteResult GroupInvite(GroupInviteParam groupInviteParam)
        {
            var result = _restHelper.Post<GroupInviteParam, GroupInviteResult>("/api/v1/groups.invite", groupInviteParam, _headers);
            return result;
        }

        public GroupKickResult GroupKick(GroupKickParam groupKickParam)
        {
            var result = _restHelper.Post<GroupKickParam, GroupKickResult>("/api/v1/groups.kick", groupKickParam, _headers);
            return result;
        }

        public GroupLeaveResult GroupLeave(GroupLeaveParam groupLeaveParam)
        {
            var result = _restHelper.Post<GroupLeaveParam, GroupLeaveResult>("/api/v1/groups.leave", groupLeaveParam, _headers);
            return result;
        }

        public GroupListResult GroupList()
        {
            var result = _restHelper.Get<GroupListResult>("/api/v1/groups.list", _headers);
            return result;
        }

        public GroupMembersResult GroupMembers(string roomId)
        {
            if (!string.IsNullOrWhiteSpace(roomId))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("roomId", roomId);
                var result = _restHelper.Get<GroupMembersResult>("/api/v1/groups.members", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("roomId == null");
            }
        }

        public GroupMessagesResult GroupMessages(string roomId)
        {
            if (!string.IsNullOrWhiteSpace(roomId))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("roomId", roomId);
                var result = _restHelper.Get<GroupMessagesResult>("/api/v1/groups.messages", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("roomId == null");
            }
        }

        public RenameGroupResult RenameGroup(RenameGroupParam groupLeaveParam)
        {
            var result = _restHelper.Post<RenameGroupParam, RenameGroupResult>("/api/v1/groups.rename", groupLeaveParam, _headers);
            return result;
        }

        #endregion

        #region Chat

        public DeleteChatMessageResult DeleteChatMessage(DeleteChatMessageParam groupLeaveParam)
        {
            var result = _restHelper.Post<DeleteChatMessageParam, DeleteChatMessageResult>("/api/v1/chat.delete", groupLeaveParam, _headers);
            return result;
        }

        public GetDeletedMessagesResult GetDeletedMessages(string roomId, DateTime? since)
        {
            if (!string.IsNullOrWhiteSpace(roomId) && since.HasValue)
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("roomId", roomId);
                queryParams.Add("since", since.Value.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz"));
                var result = _restHelper.Get<GetDeletedMessagesResult>("/api/v1/chat.getDeletedMessages", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("roomId == null && since == null");
            }
        }

        public GetMessageResult GetMessage(string msgId)
        {
            if (!string.IsNullOrWhiteSpace(msgId))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("msgId", msgId);
                var result = _restHelper.Get<GetMessageResult>("/api/v1/chat.getMessage", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("msgId == null");
            }
        }

        public GetMessageReadReceiptsResult GetMessageReadReceipts(string messageId)
        {
            if (!string.IsNullOrWhiteSpace(messageId))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("messageId", messageId);
                var result = _restHelper.Get<GetMessageReadReceiptsResult>("/api/v1/chat.getMessageReadReceipts", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("messageId == null");
            }
        }

        public IgnoreUserResult IgnoreUser(string rid, string userId, bool? ignore)
        {
            if (!string.IsNullOrWhiteSpace(rid) && !string.IsNullOrWhiteSpace(userId))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("rid", rid);
                queryParams.Add("userId", userId);

                if (ignore.HasValue)
                {
                    if (ignore.Value)
                    {
                        queryParams.Add("ignore", "true");
                    }
                    else
                    {
                        queryParams.Add("ignore", "false");
                    }
                }

                var result = _restHelper.Get<IgnoreUserResult>("/api/v1/chat.ignoreUser", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("rid == null && userId == null");
            }
        }

        public PinMessageResult PinMessage(PinMessageParam pinMessageParam)
        {
            var result = _restHelper.Post<PinMessageParam, PinMessageResult>("/api/v1/chat.pinMessage", pinMessageParam, _headers);
            return result;
        }

        public PostMessageResult PostMessage(PostMessageParam pinMessageParam)
        {
            var result = _restHelper.Post<PostMessageParam, PostMessageResult>("/api/v1/chat.postMessage", pinMessageParam, _headers);
            return result;
        }

        public ReactMessageResult ReactMessage(ReactMessageParam reactMessageParam)
        {
            var result = _restHelper.Post<ReactMessageParam, ReactMessageResult>("/api/v1/chat.react", reactMessageParam, _headers);
            return result;
        }

        public ReportMessageResult ReportMessage(ReportMessageParam reportMessageParam)
        {
            var result = _restHelper.Post<ReportMessageParam, ReportMessageResult>("/api/v1/chat.reportMessage", reportMessageParam, _headers);
            return result;
        }

        public SearchMessageResult SearchMessage(string roomId, string searchText, int? count)
        {
            if (!string.IsNullOrWhiteSpace(roomId) && !string.IsNullOrWhiteSpace(searchText))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("roomId", roomId);
                queryParams.Add("searchText", searchText);

                if (count.HasValue)
                {
                    queryParams.Add("count", count.Value.ToString());
                }

                var result = _restHelper.Get<SearchMessageResult>("/api/v1/chat.search", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("roomId == null && searchText == null");
            }
        }

        public StarMessageResult StarMessage(StarMessageParam reportMessageParam)
        {
            var result = _restHelper.Post<StarMessageParam, StarMessageResult>("/api/v1/chat.starMessage", reportMessageParam, _headers);
            return result;
        }

        public SendMessageResult SendMessage(SendMessageParam reportMessageParam)
        {
            var result = _restHelper.Post<SendMessageParam, SendMessageResult>("/api/v1/chat.sendMessage", reportMessageParam, _headers);
            return result;
        }

        public UnPinMessageResult UnPinMessage(UnPinMessageParam reportMessageParam)
        {
            var result = _restHelper.Post<UnPinMessageParam, UnPinMessageResult>("/api/v1/chat.unPinMessage", reportMessageParam, _headers);
            return result;
        }

        public UnStarMessageResult UnStarMessage(UnStarMessageParam unStarMessageParam)
        {
            var result = _restHelper.Post<UnStarMessageParam, UnStarMessageResult>("/api/v1/chat.unStarMessage", unStarMessageParam, _headers);
            return result;
        }

        public UpdateMessageResult UpdateMessage(UpdateMessageParam updateMessageParam)
        {
            var result = _restHelper.Post<UpdateMessageParam, UpdateMessageResult>("/api/v1/chat.update", updateMessageParam, _headers);
            return result;
        }

        #endregion

        #region IM

        public ImCloseResult ImClose(ImCloseParam imCloseParam)
        {
            var result = _restHelper.Post<ImCloseParam, ImCloseResult>("/api/v1/im.close", imCloseParam, _headers);
            return result;
        }

        public ImCountersResult ImCounters(string roomId, string username)
        {
            if (!string.IsNullOrWhiteSpace(roomId))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("roomId", roomId);

                if (!string.IsNullOrWhiteSpace(username))
                {
                    queryParams.Add("username", username);
                }

                var result = _restHelper.Get<ImCountersResult>("/api/v1/im.counters", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("roomId == null");
            }
        }

        public ImCreateResult ImCreate(ImCreateParam imCreateParam)
        {
            var result = _restHelper.Post<ImCreateParam, ImCreateResult>("/api/v1/im.create", imCreateParam, _headers);
            return result;
        }

        public ImHistoryResult ImHistory(ImHistoryParam imHistoryParam)
        {
            if (!string.IsNullOrWhiteSpace(imHistoryParam.RoomId))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("roomId", imHistoryParam.RoomId);

                if (imHistoryParam.Latest.HasValue)
                {
                    queryParams.Add("latest", imHistoryParam.Latest.Value.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz"));
                }

                if (imHistoryParam.Oldest.HasValue)
                {
                    queryParams.Add("oldest", imHistoryParam.Oldest.Value.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz"));
                }

                if (imHistoryParam.Inclusive.HasValue)
                {
                    queryParams.Add("inclusive", imHistoryParam.Inclusive.Value.ToString());
                }

                if (imHistoryParam.Offset.HasValue)
                {
                    queryParams.Add("offset", imHistoryParam.Offset.Value.ToString());
                }

                if (imHistoryParam.Count.HasValue)
                {
                    queryParams.Add("count", imHistoryParam.Count.Value.ToString());
                }

                if (imHistoryParam.Unreads.HasValue)
                {
                    queryParams.Add("unreads", imHistoryParam.Unreads.Value.ToString());
                }

                var result = _restHelper.Get<ImHistoryResult>("/api/v1/im.history", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("roomId == null");
            }
        }

        public ImFilesResult ImFiles(string roomId, string username)
        {
            if (!string.IsNullOrWhiteSpace(roomId) && !string.IsNullOrWhiteSpace(username))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("roomId", roomId);
                queryParams.Add("username", username);

                var result = _restHelper.Get<ImFilesResult>("/api/v1/im.files", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("roomId == null && username == null");
            }
        }

        public ImMembersResult ImMembers(string roomId, string username)
        {
            if (!string.IsNullOrWhiteSpace(roomId) && !string.IsNullOrWhiteSpace(username))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("roomId", roomId);
                queryParams.Add("username", username);

                var result = _restHelper.Get<ImMembersResult>("/api/v1/im.members", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("roomId == null && username == null");
            }
        }

        public ImMessagesResult ImMessages(string roomId, string username)
        {
            if (!string.IsNullOrWhiteSpace(roomId) || !string.IsNullOrWhiteSpace(username))
            {
                var queryParams = new Dictionary<string, string>();

                if (!string.IsNullOrWhiteSpace(roomId))
                {
                    queryParams.Add("roomId", roomId);
                }

                if (!string.IsNullOrWhiteSpace(username))
                {
                    queryParams.Add("username", username);
                }

                var result = _restHelper.Get<ImMessagesResult>("/api/v1/im.messages", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("roomId == null || username == null");
            }
        }

        public ImMessagesOthersResult ImMessagesOthers(string roomId)
        {
            if (!string.IsNullOrWhiteSpace(roomId))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("roomId", roomId);

                var result = _restHelper.Get<ImMessagesOthersResult>("/api/v1/im.messages.others", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("roomId == null");
            }
        }

        public ImListResult ImList()
        {
            var result = _restHelper.Get<ImListResult>("/api/v1/im.list", _headers);
            return result;
        }

        public ImListEveryoneResult ImListEveryone()
        {
            var result = _restHelper.Get<ImListEveryoneResult>("/api/v1/im.list.everyone", _headers);
            return result;
        }

        public ImOpenResult ImOpen(ImOpenParam imOpenParam)
        {
            var result = _restHelper.Post<ImOpenParam, ImOpenResult>("/api/v1/im.open", imOpenParam, _headers);
            return result;
        }

        public ImSetTopicResult ImSetTopic(ImSetTopicParam imSetTopicParam)
        {
            var result = _restHelper.Post<ImSetTopicParam, ImSetTopicResult>("/api/v1/im.setTopic", imSetTopicParam, _headers);
            return result;
        }

        #endregion

        #region Rooms

        public RoomCleanHistoryResult RoomCleanHistory(RoomCleanHistoryParam roomCleanHistoryParam)
        {
            var result = _restHelper.Post<RoomCleanHistoryParam, RoomCleanHistoryResult>("/api/v1/rooms.cleanHistory", roomCleanHistoryParam, _headers);
            return result;
        }

        public RoomCreateDiscussionResult RoomCreateDiscussion(RoomCreateDiscussionParam roomCreateDiscussionParam)
        {
            var result = _restHelper.Post<RoomCreateDiscussionParam, RoomCreateDiscussionResult>("/api/v1/rooms.createDiscussion", roomCreateDiscussionParam, _headers);
            return result;
        }

        public RoomFavoriteResult RoomFavorite(RoomFavoriteParam roomFavoriteParam)
        {
            var result = _restHelper.Post<RoomFavoriteParam, RoomFavoriteResult>("/api/v1/rooms.favorite", roomFavoriteParam, _headers);
            return result;
        }

        public GetRoomsResult GetRooms()
        {
            var result = _restHelper.Get<GetRoomsResult>("/api/v1/rooms.get", _headers);
            return result;
        }

        public RoomGetDiscussionsResult RoomGetDiscussions(string roomId)
        {
            if (!string.IsNullOrWhiteSpace(roomId))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("roomId", roomId);

                var result = _restHelper.Get<RoomGetDiscussionsResult>("/api/v1/rooms.getDiscussions", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("roomId == null");
            }
        }

        public RoomInfoResult RoomInfo(string roomId)
        {
            if (!string.IsNullOrWhiteSpace(roomId))
            {
                var queryParams = new Dictionary<string, string>();
                queryParams.Add("roomId", roomId);

                var result = _restHelper.Get<RoomInfoResult>("/api/v1/rooms.info", _headers, queryParams);
                return result;
            }
            else
            {
                throw new Exception("roomId == null");
            }
        }

        public RoomLeaveResult RoomLeave(RoomLeaveParam roomLeaveParam)
        {
            var result = _restHelper.Post<RoomLeaveParam, RoomLeaveResult>("/api/v1/rooms.leave", roomLeaveParam, _headers);
            return result;
        }

        #endregion
    }
}
