// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Message Media Content. </summary>
    public partial class AcsMessageMediaContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AcsMessageMediaContent"/>. </summary>
        /// <param name="mimeType"> Required. The MIME type of the file this media represents. </param>
        /// <param name="mediaId"> Required. The media identifier. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mimeType"/> or <paramref name="mediaId"/> is null. </exception>
        internal AcsMessageMediaContent(string mimeType, string mediaId)
        {
            Argument.AssertNotNull(mimeType, nameof(mimeType));
            Argument.AssertNotNull(mediaId, nameof(mediaId));

            MimeType = mimeType;
            MediaId = mediaId;
        }

        /// <summary> Initializes a new instance of <see cref="AcsMessageMediaContent"/>. </summary>
        /// <param name="mimeType"> Required. The MIME type of the file this media represents. </param>
        /// <param name="mediaId"> Required. The media identifier. </param>
        /// <param name="fileName"> Optional. The filename of the underlying media file as specified when uploaded. </param>
        /// <param name="caption"> Optional. The caption for the media object, if supported and provided. </param>
        /// <param name="animated"> Optional. Set to true if the sticker is animated; false otherwise. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AcsMessageMediaContent(string mimeType, string mediaId, string fileName, string caption, bool? animated, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MimeType = mimeType;
            MediaId = mediaId;
            FileName = fileName;
            Caption = caption;
            Animated = animated;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AcsMessageMediaContent"/> for deserialization. </summary>
        internal AcsMessageMediaContent()
        {
        }

        /// <summary> Required. The MIME type of the file this media represents. </summary>
        public string MimeType { get; }
        /// <summary> Required. The media identifier. </summary>
        public string MediaId { get; }
        /// <summary> Optional. The filename of the underlying media file as specified when uploaded. </summary>
        public string FileName { get; }
        /// <summary> Optional. The caption for the media object, if supported and provided. </summary>
        public string Caption { get; }
        /// <summary> Optional. Set to true if the sticker is animated; false otherwise. </summary>
        public bool? Animated { get; }
    }
}
