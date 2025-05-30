// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.StorageSync
{
    public partial class StorageSyncWorkflowResource : IJsonModel<StorageSyncWorkflowData>
    {
        void IJsonModel<StorageSyncWorkflowData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<StorageSyncWorkflowData>)Data).Write(writer, options);

        StorageSyncWorkflowData IJsonModel<StorageSyncWorkflowData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<StorageSyncWorkflowData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<StorageSyncWorkflowData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<StorageSyncWorkflowData>(Data, options, AzureResourceManagerStorageSyncContext.Default);

        StorageSyncWorkflowData IPersistableModel<StorageSyncWorkflowData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<StorageSyncWorkflowData>(data, options, AzureResourceManagerStorageSyncContext.Default);

        string IPersistableModel<StorageSyncWorkflowData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<StorageSyncWorkflowData>)Data).GetFormatFromOptions(options);
    }
}
