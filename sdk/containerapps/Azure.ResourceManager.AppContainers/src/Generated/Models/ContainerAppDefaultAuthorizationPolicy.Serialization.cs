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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppDefaultAuthorizationPolicy : IUtf8JsonSerializable, IJsonModel<ContainerAppDefaultAuthorizationPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppDefaultAuthorizationPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppDefaultAuthorizationPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDefaultAuthorizationPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppDefaultAuthorizationPolicy)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AllowedPrincipals))
            {
                writer.WritePropertyName("allowedPrincipals"u8);
                writer.WriteObjectValue(AllowedPrincipals, options);
            }
            if (Optional.IsCollectionDefined(AllowedApplications))
            {
                writer.WritePropertyName("allowedApplications"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedApplications)
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

        ContainerAppDefaultAuthorizationPolicy IJsonModel<ContainerAppDefaultAuthorizationPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDefaultAuthorizationPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppDefaultAuthorizationPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppDefaultAuthorizationPolicy(document.RootElement, options);
        }

        internal static ContainerAppDefaultAuthorizationPolicy DeserializeContainerAppDefaultAuthorizationPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerAppAllowedPrincipals allowedPrincipals = default;
            IList<string> allowedApplications = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedPrincipals"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowedPrincipals = ContainerAppAllowedPrincipals.DeserializeContainerAppAllowedPrincipals(property.Value, options);
                    continue;
                }
                if (property.NameEquals("allowedApplications"u8))
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
                    allowedApplications = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerAppDefaultAuthorizationPolicy(allowedPrincipals, allowedApplications ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AllowedPrincipals), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  allowedPrincipals: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AllowedPrincipals))
                {
                    builder.Append("  allowedPrincipals: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AllowedPrincipals, options, 2, false, "  allowedPrincipals: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AllowedApplications), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  allowedApplications: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AllowedApplications))
                {
                    if (AllowedApplications.Any())
                    {
                        builder.Append("  allowedApplications: ");
                        builder.AppendLine("[");
                        foreach (var item in AllowedApplications)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerAppDefaultAuthorizationPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDefaultAuthorizationPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppContainersContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppDefaultAuthorizationPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppDefaultAuthorizationPolicy IPersistableModel<ContainerAppDefaultAuthorizationPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDefaultAuthorizationPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerAppDefaultAuthorizationPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppDefaultAuthorizationPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppDefaultAuthorizationPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
