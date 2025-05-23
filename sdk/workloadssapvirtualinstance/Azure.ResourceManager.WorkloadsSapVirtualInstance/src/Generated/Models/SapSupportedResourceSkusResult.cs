// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.WorkloadsSapVirtualInstance.Models
{
    /// <summary> The list of supported SKUs for different resources which are part of SAP deployment. </summary>
    public partial class SapSupportedResourceSkusResult
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

        /// <summary> Initializes a new instance of <see cref="SapSupportedResourceSkusResult"/>. </summary>
        internal SapSupportedResourceSkusResult()
        {
            SupportedSkus = new ChangeTrackingList<SapSupportedSku>();
        }

        /// <summary> Initializes a new instance of <see cref="SapSupportedResourceSkusResult"/>. </summary>
        /// <param name="supportedSkus"> Gets the list of SAP supported SKUs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SapSupportedResourceSkusResult(IReadOnlyList<SapSupportedSku> supportedSkus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SupportedSkus = supportedSkus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the list of SAP supported SKUs. </summary>
        public IReadOnlyList<SapSupportedSku> SupportedSkus { get; }
    }
}
