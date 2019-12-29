using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public partial class TdApi
    {
        /// <summary>
        /// Removes background from the list of installed backgrounds 
        /// </summary>
        public class RemoveBackground : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "removeBackground";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The background indentifier
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("background_id")]
            public Int64 BackgroundId { get; set; }
        }
    }
}