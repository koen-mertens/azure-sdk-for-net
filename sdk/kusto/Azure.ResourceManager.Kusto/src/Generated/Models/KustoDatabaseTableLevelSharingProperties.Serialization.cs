// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class KustoDatabaseTableLevelSharingProperties : IUtf8JsonSerializable, IJsonModel<KustoDatabaseTableLevelSharingProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KustoDatabaseTableLevelSharingProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<KustoDatabaseTableLevelSharingProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoDatabaseTableLevelSharingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KustoDatabaseTableLevelSharingProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(TablesToInclude))
            {
                writer.WritePropertyName("tablesToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in TablesToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TablesToExclude))
            {
                writer.WritePropertyName("tablesToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in TablesToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExternalTablesToInclude))
            {
                writer.WritePropertyName("externalTablesToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalTablesToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExternalTablesToExclude))
            {
                writer.WritePropertyName("externalTablesToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalTablesToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MaterializedViewsToInclude))
            {
                writer.WritePropertyName("materializedViewsToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in MaterializedViewsToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MaterializedViewsToExclude))
            {
                writer.WritePropertyName("materializedViewsToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in MaterializedViewsToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FunctionsToInclude))
            {
                writer.WritePropertyName("functionsToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in FunctionsToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FunctionsToExclude))
            {
                writer.WritePropertyName("functionsToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in FunctionsToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        KustoDatabaseTableLevelSharingProperties IJsonModel<KustoDatabaseTableLevelSharingProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoDatabaseTableLevelSharingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KustoDatabaseTableLevelSharingProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKustoDatabaseTableLevelSharingProperties(document.RootElement, options);
        }

        internal static KustoDatabaseTableLevelSharingProperties DeserializeKustoDatabaseTableLevelSharingProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> tablesToInclude = default;
            IList<string> tablesToExclude = default;
            IList<string> externalTablesToInclude = default;
            IList<string> externalTablesToExclude = default;
            IList<string> materializedViewsToInclude = default;
            IList<string> materializedViewsToExclude = default;
            IList<string> functionsToInclude = default;
            IList<string> functionsToExclude = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tablesToInclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tablesToInclude = array;
                    continue;
                }
                if (property.NameEquals("tablesToExclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tablesToExclude = array;
                    continue;
                }
                if (property.NameEquals("externalTablesToInclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    externalTablesToInclude = array;
                    continue;
                }
                if (property.NameEquals("externalTablesToExclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    externalTablesToExclude = array;
                    continue;
                }
                if (property.NameEquals("materializedViewsToInclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    materializedViewsToInclude = array;
                    continue;
                }
                if (property.NameEquals("materializedViewsToExclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    materializedViewsToExclude = array;
                    continue;
                }
                if (property.NameEquals("functionsToInclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    functionsToInclude = array;
                    continue;
                }
                if (property.NameEquals("functionsToExclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    functionsToExclude = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new KustoDatabaseTableLevelSharingProperties(
                tablesToInclude ?? new ChangeTrackingList<string>(),
                tablesToExclude ?? new ChangeTrackingList<string>(),
                externalTablesToInclude ?? new ChangeTrackingList<string>(),
                externalTablesToExclude ?? new ChangeTrackingList<string>(),
                materializedViewsToInclude ?? new ChangeTrackingList<string>(),
                materializedViewsToExclude ?? new ChangeTrackingList<string>(),
                functionsToInclude ?? new ChangeTrackingList<string>(),
                functionsToExclude ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KustoDatabaseTableLevelSharingProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoDatabaseTableLevelSharingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerKustoContext.Default);
                default:
                    throw new FormatException($"The model {nameof(KustoDatabaseTableLevelSharingProperties)} does not support writing '{options.Format}' format.");
            }
        }

        KustoDatabaseTableLevelSharingProperties IPersistableModel<KustoDatabaseTableLevelSharingProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoDatabaseTableLevelSharingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeKustoDatabaseTableLevelSharingProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KustoDatabaseTableLevelSharingProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KustoDatabaseTableLevelSharingProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
