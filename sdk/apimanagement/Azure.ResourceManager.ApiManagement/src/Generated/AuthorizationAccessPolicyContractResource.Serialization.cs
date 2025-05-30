// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class AuthorizationAccessPolicyContractResource : IJsonModel<AuthorizationAccessPolicyContractData>
    {
        void IJsonModel<AuthorizationAccessPolicyContractData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AuthorizationAccessPolicyContractData>)Data).Write(writer, options);

        AuthorizationAccessPolicyContractData IJsonModel<AuthorizationAccessPolicyContractData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AuthorizationAccessPolicyContractData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AuthorizationAccessPolicyContractData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<AuthorizationAccessPolicyContractData>(Data, options, AzureResourceManagerApiManagementContext.Default);

        AuthorizationAccessPolicyContractData IPersistableModel<AuthorizationAccessPolicyContractData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AuthorizationAccessPolicyContractData>(data, options, AzureResourceManagerApiManagementContext.Default);

        string IPersistableModel<AuthorizationAccessPolicyContractData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AuthorizationAccessPolicyContractData>)Data).GetFormatFromOptions(options);
    }
}
