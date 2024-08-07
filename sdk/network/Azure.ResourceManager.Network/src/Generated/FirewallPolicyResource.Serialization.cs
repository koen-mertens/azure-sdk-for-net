// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class FirewallPolicyResource : IJsonModel<FirewallPolicyData>
    {
        void IJsonModel<FirewallPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<FirewallPolicyData>)Data).Write(writer, options);

        FirewallPolicyData IJsonModel<FirewallPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<FirewallPolicyData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<FirewallPolicyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        FirewallPolicyData IPersistableModel<FirewallPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<FirewallPolicyData>(data, options);

        string IPersistableModel<FirewallPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<FirewallPolicyData>)Data).GetFormatFromOptions(options);
    }
}
