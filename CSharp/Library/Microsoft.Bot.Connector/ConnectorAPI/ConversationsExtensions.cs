// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;


    public static partial class ConversationsExtensions
    {
        /// <summary>
        /// Start a new conversation
        /// </summary>
        /// System.IO.DirectoryNotFoundException: Could not find a part of the path
        /// 'C:\\\\source\\\\Intercom\\\\Channels\\\\SampleChannel\\\\Content\\\\Methods\\\\SendMessage.md'.
        /// at System.IO.__Error.WinIOError(Int32 errorCode, String maybeFullPath)
        /// at System.IO.FileStream.Init(String path, FileMode mode, FileAccess
        /// access, Int32 rights, Boolean useRights, FileShare share, Int32
        /// bufferSize, FileOptions options, SECURITY_ATTRIBUTES secAttrs, String
        /// msgPath, Boolean bFromProxy, Boolean useLongPath, Boolean checkHost)
        /// at System.IO.FileStream..ctor(String path, FileMode mode, FileAccess
        /// access, FileShare share, Int32 bufferSize, FileOptions options, String
        /// msgPath, Boolean bFromProxy, Boolean useLongPath, Boolean checkHost)
        /// at System.IO.StreamReader..ctor(String path, Encoding encoding, Boolean
        /// detectEncodingFromByteOrderMarks, Int32 bufferSize, Boolean checkHost)
        /// at System.IO.File.InternalReadAllText(String path, Encoding encoding,
        /// Boolean checkHost)
        /// at System.IO.File.ReadAllText(String path)
        /// at MarkdownDocs.Program.Main(String[] args)
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='activity'>
        /// Message to send
        /// </param>
        public static APIResponse StartConversation(this IConversations operations, Activity activity)
        {
            return Task.Factory.StartNew(s => ((IConversations)s).StartConversationAsync(activity), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Start a new conversation
        /// </summary>
        /// System.IO.DirectoryNotFoundException: Could not find a part of the path
        /// 'C:\\\\source\\\\Intercom\\\\Channels\\\\SampleChannel\\\\Content\\\\Methods\\\\SendMessage.md'.
        /// at System.IO.__Error.WinIOError(Int32 errorCode, String maybeFullPath)
        /// at System.IO.FileStream.Init(String path, FileMode mode, FileAccess
        /// access, Int32 rights, Boolean useRights, FileShare share, Int32
        /// bufferSize, FileOptions options, SECURITY_ATTRIBUTES secAttrs, String
        /// msgPath, Boolean bFromProxy, Boolean useLongPath, Boolean checkHost)
        /// at System.IO.FileStream..ctor(String path, FileMode mode, FileAccess
        /// access, FileShare share, Int32 bufferSize, FileOptions options, String
        /// msgPath, Boolean bFromProxy, Boolean useLongPath, Boolean checkHost)
        /// at System.IO.StreamReader..ctor(String path, Encoding encoding, Boolean
        /// detectEncodingFromByteOrderMarks, Int32 bufferSize, Boolean checkHost)
        /// at System.IO.File.InternalReadAllText(String path, Encoding encoding,
        /// Boolean checkHost)
        /// at System.IO.File.ReadAllText(String path)
        /// at MarkdownDocs.Program.Main(String[] args)
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='activity'>
        /// Message to send
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<APIResponse> StartConversationAsync(this IConversations operations, Activity activity, CancellationToken cancellationToken = default(CancellationToken))
        {
            var _result = await operations.StartConversationWithHttpMessagesAsync(activity, null, cancellationToken).ConfigureAwait(false);
            return _result.Body;
        }

        /// <summary>
        /// Send an activity to an existing conversation
        /// </summary>
        /// System.IO.DirectoryNotFoundException: Could not find a part of the path
        /// 'C:\\\\source\\\\Intercom\\\\Channels\\\\SampleChannel\\\\Content\\\\Methods\\\\SendMessage.md'.
        /// at System.IO.__Error.WinIOError(Int32 errorCode, String maybeFullPath)
        /// at System.IO.FileStream.Init(String path, FileMode mode, FileAccess
        /// access, Int32 rights, Boolean useRights, FileShare share, Int32
        /// bufferSize, FileOptions options, SECURITY_ATTRIBUTES secAttrs, String
        /// msgPath, Boolean bFromProxy, Boolean useLongPath, Boolean checkHost)
        /// at System.IO.FileStream..ctor(String path, FileMode mode, FileAccess
        /// access, FileShare share, Int32 bufferSize, FileOptions options, String
        /// msgPath, Boolean bFromProxy, Boolean useLongPath, Boolean checkHost)
        /// at System.IO.StreamReader..ctor(String path, Encoding encoding, Boolean
        /// detectEncodingFromByteOrderMarks, Int32 bufferSize, Boolean checkHost)
        /// at System.IO.File.InternalReadAllText(String path, Encoding encoding,
        /// Boolean checkHost)
        /// at System.IO.File.ReadAllText(String path)
        /// at MarkdownDocs.Program.Main(String[] args)
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        /// <param name='activity'>
        /// Message to send
        /// </param>
        public static APIResponse ReplyToConversation(this IConversations operations, string conversationId, Activity activity)
        {
            return Task.Factory.StartNew(s => ((IConversations)s).ReplyToConversationAsync(conversationId, activity), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Send an activity to an existing conversation
        /// </summary>
        /// System.IO.DirectoryNotFoundException: Could not find a part of the path
        /// 'C:\\\\source\\\\Intercom\\\\Channels\\\\SampleChannel\\\\Content\\\\Methods\\\\SendMessage.md'.
        /// at System.IO.__Error.WinIOError(Int32 errorCode, String maybeFullPath)
        /// at System.IO.FileStream.Init(String path, FileMode mode, FileAccess
        /// access, Int32 rights, Boolean useRights, FileShare share, Int32
        /// bufferSize, FileOptions options, SECURITY_ATTRIBUTES secAttrs, String
        /// msgPath, Boolean bFromProxy, Boolean useLongPath, Boolean checkHost)
        /// at System.IO.FileStream..ctor(String path, FileMode mode, FileAccess
        /// access, FileShare share, Int32 bufferSize, FileOptions options, String
        /// msgPath, Boolean bFromProxy, Boolean useLongPath, Boolean checkHost)
        /// at System.IO.StreamReader..ctor(String path, Encoding encoding, Boolean
        /// detectEncodingFromByteOrderMarks, Int32 bufferSize, Boolean checkHost)
        /// at System.IO.File.InternalReadAllText(String path, Encoding encoding,
        /// Boolean checkHost)
        /// at System.IO.File.ReadAllText(String path)
        /// at MarkdownDocs.Program.Main(String[] args)
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        /// <param name='activity'>
        /// Message to send
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<APIResponse> ReplyToConversationAsync(this IConversations operations, string conversationId, Activity activity, CancellationToken cancellationToken = default(CancellationToken))
        {
            // TEMP UNTIL WE HAVE JWT TOKENS
            Dictionary<string, List<string>> headers = new Dictionary<string, List<string>>();
            headers.Add("botid", new List<string>() { System.Configuration.ConfigurationManager.AppSettings["appId"] });
            var _result = await operations.ReplyToConversationWithHttpMessagesAsync(conversationId, activity, headers, cancellationToken).ConfigureAwait(false);
            // END TEmP
            // var _result = await operations.ReplyToConversationWithHttpMessagesAsync(conversationId, activity, null, cancellationToken).ConfigureAwait(false);
            return _result.Body;
        }

        /// <summary>
        /// Get the list of members in this conversation
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        /// <param name='activityId'>
        /// (OPTIONAL) Message ID
        /// </param>
        public static object GetMembers(this IConversations operations, string conversationId, string activityId = default(string))
        {
            return Task.Factory.StartNew(s => ((IConversations)s).GetMembersAsync(conversationId, activityId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the list of members in this conversation
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='conversationId'>
        /// Conversation ID
        /// </param>
        /// <param name='activityId'>
        /// (OPTIONAL) Message ID
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<object> GetMembersAsync(this IConversations operations, string conversationId, string activityId = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            var _result = await operations.GetMembersWithHttpMessagesAsync(conversationId, activityId, null, cancellationToken).ConfigureAwait(false);
            return _result.Body;
        }

    }
}
