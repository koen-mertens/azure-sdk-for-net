// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Avs
{
    public partial class ExpressRouteAuthorizationResource : IJsonModel<ExpressRouteAuthorizationData>
    {
        void IJsonModel<ExpressRouteAuthorizationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ExpressRouteAuthorizationData>)Data).Write(writer, options);

        ExpressRouteAuthorizationData IJsonModel<ExpressRouteAuthorizationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ExpressRouteAuthorizationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ExpressRouteAuthorizationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ExpressRouteAuthorizationData>(Data, options, AzureResourceManagerAvsContext.Default);

        ExpressRouteAuthorizationData IPersistableModel<ExpressRouteAuthorizationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ExpressRouteAuthorizationData>(data, options, AzureResourceManagerAvsContext.Default);

        string IPersistableModel<ExpressRouteAuthorizationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ExpressRouteAuthorizationData>)Data).GetFormatFromOptions(options);
    }
}
