using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Describes a recently speaking user in a group call
        /// </summary>
        public partial class GroupCallRecentSpeaker : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "groupCallRecentSpeaker";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// User identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public int UserId { get; set; }

            /// <summary>
            /// True, is the user has spoken recently
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_speaking")]
            public bool IsSpeaking { get; set; }
        }
    }
}