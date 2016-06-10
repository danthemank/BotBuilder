// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// </summary>
    public partial class Activity
    {
        /// <summary>
        /// Initializes a new instance of the Activity class.
        /// </summary>
        public Activity() { }

        /// <summary>
        /// Initializes a new instance of the Activity class.
        /// </summary>
        public Activity(string type = default(string), string id = default(string), DateTime? timestamp = default(DateTime?), string serviceUrl = default(string), string channelId = default(string), ChannelAccount from = default(ChannelAccount), ConversationAccount to = default(ConversationAccount), ChannelAccount recipient = default(ChannelAccount), IList<ChannelAccount> membersAdded = default(IList<ChannelAccount>), IList<ChannelAccount> membersRemoved = default(IList<ChannelAccount>), string topicName = default(string), bool? historyDisclosed = default(bool?), string locale = default(string), string text = default(string), string summary = default(string), IList<Attachment> attachments = default(IList<Attachment>), IList<Entity> entities = default(IList<Entity>), object channelData = default(object), string action = default(string))
        {
            Type = type;
            Id = id;
            Timestamp = timestamp;
            ServiceUrl = serviceUrl;
            ChannelId = channelId;
            From = from;
            To = to;
            Recipient = recipient;
            MembersAdded = membersAdded;
            MembersRemoved = membersRemoved;
            TopicName = topicName;
            HistoryDisclosed = historyDisclosed;
            Locale = locale;
            Text = text;
            Summary = summary;
            Attachments = attachments;
            Entities = entities;
            ChannelData = channelData;
            Action = action;
        }

        /// <summary>
        /// Activity type
        /// The type of the activity (aka "message/carosel" "contactUpdate"
        /// "typing" etc.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Id for the activity
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Time when message was sent
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Service endpoint
        /// </summary>
        [JsonProperty(PropertyName = "serviceUrl")]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// ChannelId the activity was on
        /// </summary>
        [JsonProperty(PropertyName = "channelId")]
        public string ChannelId { get; set; }

        /// <summary>
        /// Sender address
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public ChannelAccount From { get; set; }

        /// <summary>
        /// Conversation
        /// </summary>
        [JsonProperty(PropertyName = "to")]
        public ConversationAccount To { get; set; }

        /// <summary>
        /// (Outbound to bot only) Bot's address that received the message
        /// </summary>
        [JsonProperty(PropertyName = "recipient")]
        public ChannelAccount Recipient { get; set; }

        /// <summary>
        /// Array of address added
        /// </summary>
        [JsonProperty(PropertyName = "membersAdded")]
        public IList<ChannelAccount> MembersAdded { get; set; }

        /// <summary>
        /// Array of addresses removed
        /// </summary>
        [JsonProperty(PropertyName = "membersRemoved")]
        public IList<ChannelAccount> MembersRemoved { get; set; }

        /// <summary>
        /// Conversations new topic name
        /// </summary>
        [JsonProperty(PropertyName = "topicName")]
        public string TopicName { get; set; }

        /// <summary>
        /// fughly
        /// </summary>
        [JsonProperty(PropertyName = "historyDisclosed")]
        public bool? HistoryDisclosed { get; set; }

        /// <summary>
        /// The language code of the Text field
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Content for the message
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Text to display if you can't render cards
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Attachments
        /// </summary>
        [JsonProperty(PropertyName = "attachments")]
        public IList<Attachment> Attachments { get; set; }

        /// <summary>
        /// Entities
        /// Collection of Entity which contain metadata about this activity
        /// (each is typed)
        /// </summary>
        [JsonProperty(PropertyName = "entities")]
        public IList<Entity> Entities { get; set; }

        /// <summary>
        /// Channel specific payload
        /// </summary>
        [JsonProperty(PropertyName = "channelData")]
        public object ChannelData { get; set; }

        /// <summary>
        /// ContactAdded/Removed action
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

    }
}
