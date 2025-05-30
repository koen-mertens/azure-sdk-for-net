// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkDeviceSkuResource : IJsonModel<NetworkDeviceSkuData>
    {
        void IJsonModel<NetworkDeviceSkuData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<NetworkDeviceSkuData>)Data).Write(writer, options);

        NetworkDeviceSkuData IJsonModel<NetworkDeviceSkuData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<NetworkDeviceSkuData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<NetworkDeviceSkuData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<NetworkDeviceSkuData>(Data, options, AzureResourceManagerManagedNetworkFabricContext.Default);

        NetworkDeviceSkuData IPersistableModel<NetworkDeviceSkuData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<NetworkDeviceSkuData>(data, options, AzureResourceManagerManagedNetworkFabricContext.Default);

        string IPersistableModel<NetworkDeviceSkuData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<NetworkDeviceSkuData>)Data).GetFormatFromOptions(options);
    }
}
