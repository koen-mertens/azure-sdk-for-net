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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MaterializationSettings : IUtf8JsonSerializable, IJsonModel<MaterializationSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MaterializationSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MaterializationSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaterializationSettings)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(StoreType))
            {
                writer.WritePropertyName("storeType"u8);
                writer.WriteStringValue(StoreType.Value.ToString());
            }
            if (Optional.IsDefined(Schedule))
            {
                if (Schedule != null)
                {
                    writer.WritePropertyName("schedule"u8);
                    writer.WriteObjectValue(Schedule, options);
                }
                else
                {
                    writer.WriteNull("schedule");
                }
            }
            if (Optional.IsDefined(Notification))
            {
                if (Notification != null)
                {
                    writer.WritePropertyName("notification"u8);
                    writer.WriteObjectValue(Notification, options);
                }
                else
                {
                    writer.WriteNull("notification");
                }
            }
            if (Optional.IsDefined(Resource))
            {
                if (Resource != null)
                {
                    writer.WritePropertyName("resource"u8);
                    writer.WriteObjectValue(Resource, options);
                }
                else
                {
                    writer.WriteNull("resource");
                }
            }
            if (Optional.IsCollectionDefined(SparkConfiguration))
            {
                if (SparkConfiguration != null)
                {
                    writer.WritePropertyName("sparkConfiguration"u8);
                    writer.WriteStartObject();
                    foreach (var item in SparkConfiguration)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("sparkConfiguration");
                }
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

        MaterializationSettings IJsonModel<MaterializationSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaterializationSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMaterializationSettings(document.RootElement, options);
        }

        internal static MaterializationSettings DeserializeMaterializationSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MaterializationStoreType? storeType = default;
            MachineLearningRecurrenceTrigger schedule = default;
            NotificationSetting notification = default;
            MaterializationComputeResource resource = default;
            IDictionary<string, string> sparkConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storeType = new MaterializationStoreType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("schedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        schedule = null;
                        continue;
                    }
                    schedule = MachineLearningRecurrenceTrigger.DeserializeMachineLearningRecurrenceTrigger(property.Value, options);
                    continue;
                }
                if (property.NameEquals("notification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        notification = null;
                        continue;
                    }
                    notification = NotificationSetting.DeserializeNotificationSetting(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resource = null;
                        continue;
                    }
                    resource = MaterializationComputeResource.DeserializeMaterializationComputeResource(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sparkConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sparkConfiguration = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    sparkConfiguration = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MaterializationSettings(
                storeType,
                schedule,
                notification,
                resource,
                sparkConfiguration ?? new ChangeTrackingDictionary<string, string>(),
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StoreType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  storeType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StoreType))
                {
                    builder.Append("  storeType: ");
                    builder.AppendLine($"'{StoreType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Schedule), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  schedule: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Schedule))
                {
                    builder.Append("  schedule: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Schedule, options, 2, false, "  schedule: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Notification), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  notification: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Notification))
                {
                    builder.Append("  notification: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Notification, options, 2, false, "  notification: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("ResourceInstanceType", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  resource: ");
                builder.AppendLine("{");
                builder.Append("    instanceType: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(Resource))
                {
                    builder.Append("  resource: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Resource, options, 2, false, "  resource: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SparkConfiguration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sparkConfiguration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SparkConfiguration))
                {
                    if (SparkConfiguration.Any())
                    {
                        builder.Append("  sparkConfiguration: ");
                        builder.AppendLine("{");
                        foreach (var item in SparkConfiguration)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MaterializationSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMachineLearningContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MaterializationSettings)} does not support writing '{options.Format}' format.");
            }
        }

        MaterializationSettings IPersistableModel<MaterializationSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMaterializationSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MaterializationSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MaterializationSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
