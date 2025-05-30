// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Dynatrace
{
    public partial class DynatraceSingleSignOnResource : IJsonModel<DynatraceSingleSignOnData>
    {
        void IJsonModel<DynatraceSingleSignOnData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DynatraceSingleSignOnData>)Data).Write(writer, options);

        DynatraceSingleSignOnData IJsonModel<DynatraceSingleSignOnData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DynatraceSingleSignOnData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DynatraceSingleSignOnData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DynatraceSingleSignOnData>(Data, options, AzureResourceManagerDynatraceContext.Default);

        DynatraceSingleSignOnData IPersistableModel<DynatraceSingleSignOnData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DynatraceSingleSignOnData>(data, options, AzureResourceManagerDynatraceContext.Default);

        string IPersistableModel<DynatraceSingleSignOnData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DynatraceSingleSignOnData>)Data).GetFormatFromOptions(options);
    }
}
