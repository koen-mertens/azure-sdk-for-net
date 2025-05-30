// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBIndexingPolicy : IUtf8JsonSerializable, IJsonModel<CosmosDBIndexingPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBIndexingPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CosmosDBIndexingPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBIndexingPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBIndexingPolicy)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsAutomatic))
            {
                writer.WritePropertyName("automatic"u8);
                writer.WriteBooleanValue(IsAutomatic.Value);
            }
            if (Optional.IsDefined(IndexingMode))
            {
                writer.WritePropertyName("indexingMode"u8);
                writer.WriteStringValue(IndexingMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IncludedPaths))
            {
                writer.WritePropertyName("includedPaths"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedPaths)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExcludedPaths))
            {
                writer.WritePropertyName("excludedPaths"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedPaths)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CompositeIndexes))
            {
                writer.WritePropertyName("compositeIndexes"u8);
                writer.WriteStartArray();
                foreach (var item in CompositeIndexes)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteObjectValue(item0, options);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SpatialIndexes))
            {
                writer.WritePropertyName("spatialIndexes"u8);
                writer.WriteStartArray();
                foreach (var item in SpatialIndexes)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VectorIndexes))
            {
                writer.WritePropertyName("vectorIndexes"u8);
                writer.WriteStartArray();
                foreach (var item in VectorIndexes)
                {
                    writer.WriteObjectValue(item, options);
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

        CosmosDBIndexingPolicy IJsonModel<CosmosDBIndexingPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBIndexingPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBIndexingPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBIndexingPolicy(document.RootElement, options);
        }

        internal static CosmosDBIndexingPolicy DeserializeCosmosDBIndexingPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? automatic = default;
            CosmosDBIndexingMode? indexingMode = default;
            IList<CosmosDBIncludedPath> includedPaths = default;
            IList<CosmosDBExcludedPath> excludedPaths = default;
            IList<IList<CosmosDBCompositePath>> compositeIndexes = default;
            IList<SpatialSpec> spatialIndexes = default;
            IList<CosmosDBVectorIndex> vectorIndexes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("automatic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automatic = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("indexingMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    indexingMode = new CosmosDBIndexingMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("includedPaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBIncludedPath> array = new List<CosmosDBIncludedPath>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBIncludedPath.DeserializeCosmosDBIncludedPath(item, options));
                    }
                    includedPaths = array;
                    continue;
                }
                if (property.NameEquals("excludedPaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBExcludedPath> array = new List<CosmosDBExcludedPath>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBExcludedPath.DeserializeCosmosDBExcludedPath(item, options));
                    }
                    excludedPaths = array;
                    continue;
                }
                if (property.NameEquals("compositeIndexes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IList<CosmosDBCompositePath>> array = new List<IList<CosmosDBCompositePath>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<CosmosDBCompositePath> array0 = new List<CosmosDBCompositePath>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                array0.Add(CosmosDBCompositePath.DeserializeCosmosDBCompositePath(item0, options));
                            }
                            array.Add(array0);
                        }
                    }
                    compositeIndexes = array;
                    continue;
                }
                if (property.NameEquals("spatialIndexes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SpatialSpec> array = new List<SpatialSpec>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpatialSpec.DeserializeSpatialSpec(item, options));
                    }
                    spatialIndexes = array;
                    continue;
                }
                if (property.NameEquals("vectorIndexes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBVectorIndex> array = new List<CosmosDBVectorIndex>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBVectorIndex.DeserializeCosmosDBVectorIndex(item, options));
                    }
                    vectorIndexes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CosmosDBIndexingPolicy(
                automatic,
                indexingMode,
                includedPaths ?? new ChangeTrackingList<CosmosDBIncludedPath>(),
                excludedPaths ?? new ChangeTrackingList<CosmosDBExcludedPath>(),
                compositeIndexes ?? new ChangeTrackingList<IList<CosmosDBCompositePath>>(),
                spatialIndexes ?? new ChangeTrackingList<SpatialSpec>(),
                vectorIndexes ?? new ChangeTrackingList<CosmosDBVectorIndex>(),
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsAutomatic), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  automatic: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsAutomatic))
                {
                    builder.Append("  automatic: ");
                    var boolValue = IsAutomatic.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IndexingMode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  indexingMode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IndexingMode))
                {
                    builder.Append("  indexingMode: ");
                    builder.AppendLine($"'{IndexingMode.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IncludedPaths), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  includedPaths: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(IncludedPaths))
                {
                    if (IncludedPaths.Any())
                    {
                        builder.Append("  includedPaths: ");
                        builder.AppendLine("[");
                        foreach (var item in IncludedPaths)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  includedPaths: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExcludedPaths), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  excludedPaths: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ExcludedPaths))
                {
                    if (ExcludedPaths.Any())
                    {
                        builder.Append("  excludedPaths: ");
                        builder.AppendLine("[");
                        foreach (var item in ExcludedPaths)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  excludedPaths: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CompositeIndexes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  compositeIndexes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(CompositeIndexes))
                {
                    if (CompositeIndexes.Any())
                    {
                        builder.Append("  compositeIndexes: ");
                        builder.AppendLine("[");
                        foreach (var item in CompositeIndexes)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine("[");
                            foreach (var item0 in item)
                            {
                                BicepSerializationHelpers.AppendChildObject(builder, item0, options, 4, true, "  compositeIndexes: ");
                            }
                            builder.AppendLine("  ]");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SpatialIndexes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  spatialIndexes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SpatialIndexes))
                {
                    if (SpatialIndexes.Any())
                    {
                        builder.Append("  spatialIndexes: ");
                        builder.AppendLine("[");
                        foreach (var item in SpatialIndexes)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  spatialIndexes: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(VectorIndexes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  vectorIndexes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(VectorIndexes))
                {
                    if (VectorIndexes.Any())
                    {
                        builder.Append("  vectorIndexes: ");
                        builder.AppendLine("[");
                        foreach (var item in VectorIndexes)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  vectorIndexes: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CosmosDBIndexingPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBIndexingPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerCosmosDBContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBIndexingPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        CosmosDBIndexingPolicy IPersistableModel<CosmosDBIndexingPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBIndexingPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCosmosDBIndexingPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBIndexingPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBIndexingPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
