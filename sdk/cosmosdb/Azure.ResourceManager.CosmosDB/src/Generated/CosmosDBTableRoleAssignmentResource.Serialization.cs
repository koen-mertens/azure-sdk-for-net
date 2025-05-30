// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CosmosDB
{
    public partial class CosmosDBTableRoleAssignmentResource : IJsonModel<CosmosDBTableRoleAssignmentData>
    {
        void IJsonModel<CosmosDBTableRoleAssignmentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CosmosDBTableRoleAssignmentData>)Data).Write(writer, options);

        CosmosDBTableRoleAssignmentData IJsonModel<CosmosDBTableRoleAssignmentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CosmosDBTableRoleAssignmentData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<CosmosDBTableRoleAssignmentData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<CosmosDBTableRoleAssignmentData>(Data, options, AzureResourceManagerCosmosDBContext.Default);

        CosmosDBTableRoleAssignmentData IPersistableModel<CosmosDBTableRoleAssignmentData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CosmosDBTableRoleAssignmentData>(data, options, AzureResourceManagerCosmosDBContext.Default);

        string IPersistableModel<CosmosDBTableRoleAssignmentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CosmosDBTableRoleAssignmentData>)Data).GetFormatFromOptions(options);
    }
}
