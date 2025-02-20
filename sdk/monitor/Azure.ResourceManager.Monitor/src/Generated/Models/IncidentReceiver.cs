// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> An Incident receiver. </summary>
    public partial class IncidentReceiver
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

        /// <summary> Initializes a new instance of <see cref="IncidentReceiver"/>. </summary>
        /// <param name="name"> The name of the Incident receiver. Names must be unique across all receivers within an action group. </param>
        /// <param name="connection"> The incident service connection. </param>
        /// <param name="incidentManagementService"> The incident management service type. </param>
        /// <param name="mappings"> Field mappings for the incident service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="connection"/> or <paramref name="mappings"/> is null. </exception>
        public IncidentReceiver(string name, IncidentServiceConnection connection, IncidentManagementService incidentManagementService, IDictionary<string, string> mappings)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(connection, nameof(connection));
            Argument.AssertNotNull(mappings, nameof(mappings));

            Name = name;
            Connection = connection;
            IncidentManagementService = incidentManagementService;
            Mappings = mappings;
        }

        /// <summary> Initializes a new instance of <see cref="IncidentReceiver"/>. </summary>
        /// <param name="name"> The name of the Incident receiver. Names must be unique across all receivers within an action group. </param>
        /// <param name="connection"> The incident service connection. </param>
        /// <param name="incidentManagementService"> The incident management service type. </param>
        /// <param name="mappings"> Field mappings for the incident service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IncidentReceiver(string name, IncidentServiceConnection connection, IncidentManagementService incidentManagementService, IDictionary<string, string> mappings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Connection = connection;
            IncidentManagementService = incidentManagementService;
            Mappings = mappings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IncidentReceiver"/> for deserialization. </summary>
        internal IncidentReceiver()
        {
        }

        /// <summary> The name of the Incident receiver. Names must be unique across all receivers within an action group. </summary>
        public string Name { get; set; }
        /// <summary> The incident service connection. </summary>
        public IncidentServiceConnection Connection { get; set; }
        /// <summary> The incident management service type. </summary>
        public IncidentManagementService IncidentManagementService { get; set; }
        /// <summary> Field mappings for the incident service. </summary>
        public IDictionary<string, string> Mappings { get; }
    }
}
