// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningComputeInstanceCreatedBy : IUtf8JsonSerializable, IJsonModel<MachineLearningComputeInstanceCreatedBy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningComputeInstanceCreatedBy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningComputeInstanceCreatedBy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceCreatedBy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningComputeInstanceCreatedBy)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(UserName))
            {
                if (UserName != null)
                {
                    writer.WritePropertyName("userName"u8);
                    writer.WriteStringValue(UserName);
                }
                else
                {
                    writer.WriteNull("userName");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(UserOrgId))
            {
                writer.WritePropertyName("userOrgId"u8);
                writer.WriteStringValue(UserOrgId);
            }
            if (options.Format != "W" && Optional.IsDefined(UserId))
            {
                if (UserId != null)
                {
                    writer.WritePropertyName("userId"u8);
                    writer.WriteStringValue(UserId);
                }
                else
                {
                    writer.WriteNull("userId");
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

        MachineLearningComputeInstanceCreatedBy IJsonModel<MachineLearningComputeInstanceCreatedBy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceCreatedBy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningComputeInstanceCreatedBy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningComputeInstanceCreatedBy(document.RootElement, options);
        }

        internal static MachineLearningComputeInstanceCreatedBy DeserializeMachineLearningComputeInstanceCreatedBy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string userName = default;
            string userOrgId = default;
            string userId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userName = null;
                        continue;
                    }
                    userName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userOrgId"u8))
                {
                    userOrgId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userId = null;
                        continue;
                    }
                    userId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningComputeInstanceCreatedBy(userName, userOrgId, userId, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UserName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  userName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UserName))
                {
                    builder.Append("  userName: ");
                    if (UserName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UserName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UserName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UserOrgId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  userOrgId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UserOrgId))
                {
                    builder.Append("  userOrgId: ");
                    if (UserOrgId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UserOrgId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UserOrgId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UserId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  userId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UserId))
                {
                    builder.Append("  userId: ");
                    if (UserId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UserId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UserId}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningComputeInstanceCreatedBy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceCreatedBy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMachineLearningContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningComputeInstanceCreatedBy)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningComputeInstanceCreatedBy IPersistableModel<MachineLearningComputeInstanceCreatedBy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceCreatedBy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMachineLearningComputeInstanceCreatedBy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningComputeInstanceCreatedBy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningComputeInstanceCreatedBy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
