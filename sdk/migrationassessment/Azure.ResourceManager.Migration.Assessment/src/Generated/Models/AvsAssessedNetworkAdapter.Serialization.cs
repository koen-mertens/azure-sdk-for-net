// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migration.Assessment.Models
{
    public partial class AvsAssessedNetworkAdapter : IUtf8JsonSerializable, IJsonModel<AvsAssessedNetworkAdapter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvsAssessedNetworkAdapter>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AvsAssessedNetworkAdapter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsAssessedNetworkAdapter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsAssessedNetworkAdapter)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(MacAddress))
            {
                writer.WritePropertyName("macAddress"u8);
                writer.WriteStringValue(MacAddress);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(IPAddresses))
            {
                writer.WritePropertyName("ipAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in IPAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(MegabytesPerSecondReceived))
            {
                writer.WritePropertyName("megabytesPerSecondReceived"u8);
                writer.WriteNumberValue(MegabytesPerSecondReceived.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MegabytesPerSecondTransmitted))
            {
                writer.WritePropertyName("megabytesPerSecondTransmitted"u8);
                writer.WriteNumberValue(MegabytesPerSecondTransmitted.Value);
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

        AvsAssessedNetworkAdapter IJsonModel<AvsAssessedNetworkAdapter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsAssessedNetworkAdapter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsAssessedNetworkAdapter)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvsAssessedNetworkAdapter(document.RootElement, options);
        }

        internal static AvsAssessedNetworkAdapter DeserializeAvsAssessedNetworkAdapter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string macAddress = default;
            IReadOnlyList<string> ipAddresses = default;
            string displayName = default;
            double? megabytesPerSecondReceived = default;
            double? megabytesPerSecondTransmitted = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("macAddress"u8))
                {
                    macAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddresses"u8))
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
                    ipAddresses = array;
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("megabytesPerSecondReceived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    megabytesPerSecondReceived = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("megabytesPerSecondTransmitted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    megabytesPerSecondTransmitted = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AvsAssessedNetworkAdapter(
                macAddress,
                ipAddresses ?? new ChangeTrackingList<string>(),
                displayName,
                megabytesPerSecondReceived,
                megabytesPerSecondTransmitted,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvsAssessedNetworkAdapter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsAssessedNetworkAdapter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMigrationAssessmentContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AvsAssessedNetworkAdapter)} does not support writing '{options.Format}' format.");
            }
        }

        AvsAssessedNetworkAdapter IPersistableModel<AvsAssessedNetworkAdapter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsAssessedNetworkAdapter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAvsAssessedNetworkAdapter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvsAssessedNetworkAdapter)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvsAssessedNetworkAdapter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
