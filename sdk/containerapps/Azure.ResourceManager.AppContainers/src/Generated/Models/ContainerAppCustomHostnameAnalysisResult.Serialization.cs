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
    public partial class ContainerAppCustomHostnameAnalysisResult : IUtf8JsonSerializable, IJsonModel<ContainerAppCustomHostnameAnalysisResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppCustomHostnameAnalysisResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppCustomHostnameAnalysisResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppCustomHostnameAnalysisResult)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (options.Format != "W" && Optional.IsDefined(IsHostnameAlreadyVerified))
            {
                writer.WritePropertyName("isHostnameAlreadyVerified"u8);
                writer.WriteBooleanValue(IsHostnameAlreadyVerified.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CustomDomainVerificationTest))
            {
                writer.WritePropertyName("customDomainVerificationTest"u8);
                writer.WriteStringValue(CustomDomainVerificationTest.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(CustomDomainVerificationFailureInfo))
            {
                writer.WritePropertyName("customDomainVerificationFailureInfo"u8);
                writer.WriteObjectValue(CustomDomainVerificationFailureInfo, options);
            }
            if (options.Format != "W" && Optional.IsDefined(HasConflictOnManagedEnvironment))
            {
                writer.WritePropertyName("hasConflictOnManagedEnvironment"u8);
                writer.WriteBooleanValue(HasConflictOnManagedEnvironment.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ConflictWithEnvironmentCustomDomain))
            {
                writer.WritePropertyName("conflictWithEnvironmentCustomDomain"u8);
                writer.WriteBooleanValue(ConflictWithEnvironmentCustomDomain.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ConflictingContainerAppResourceId))
            {
                writer.WritePropertyName("conflictingContainerAppResourceId"u8);
                writer.WriteStringValue(ConflictingContainerAppResourceId);
            }
            if (Optional.IsCollectionDefined(CNameRecords))
            {
                writer.WritePropertyName("cNameRecords"u8);
                writer.WriteStartArray();
                foreach (var item in CNameRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TxtRecords))
            {
                writer.WritePropertyName("txtRecords"u8);
                writer.WriteStartArray();
                foreach (var item in TxtRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ARecords))
            {
                writer.WritePropertyName("aRecords"u8);
                writer.WriteStartArray();
                foreach (var item in ARecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AlternateCNameRecords))
            {
                writer.WritePropertyName("alternateCNameRecords"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateCNameRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AlternateTxtRecords))
            {
                writer.WritePropertyName("alternateTxtRecords"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateTxtRecords)
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

        ContainerAppCustomHostnameAnalysisResult IJsonModel<ContainerAppCustomHostnameAnalysisResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppCustomHostnameAnalysisResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppCustomHostnameAnalysisResult(document.RootElement, options);
        }

        internal static ContainerAppCustomHostnameAnalysisResult DeserializeContainerAppCustomHostnameAnalysisResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string hostName = default;
            bool? isHostnameAlreadyVerified = default;
            ContainerAppDnsVerificationTestResult? customDomainVerificationTest = default;
            ContainerAppCustomDomainVerificationFailureInfo customDomainVerificationFailureInfo = default;
            bool? hasConflictOnManagedEnvironment = default;
            bool? conflictWithEnvironmentCustomDomain = default;
            string conflictingContainerAppResourceId = default;
            IReadOnlyList<string> cNameRecords = default;
            IReadOnlyList<string> txtRecords = default;
            IReadOnlyList<string> aRecords = default;
            IReadOnlyList<string> alternateCNameRecords = default;
            IReadOnlyList<string> alternateTxtRecords = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isHostnameAlreadyVerified"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isHostnameAlreadyVerified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("customDomainVerificationTest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customDomainVerificationTest = property.Value.GetString().ToContainerAppDnsVerificationTestResult();
                    continue;
                }
                if (property.NameEquals("customDomainVerificationFailureInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customDomainVerificationFailureInfo = ContainerAppCustomDomainVerificationFailureInfo.DeserializeContainerAppCustomDomainVerificationFailureInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("hasConflictOnManagedEnvironment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasConflictOnManagedEnvironment = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("conflictWithEnvironmentCustomDomain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conflictWithEnvironmentCustomDomain = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("conflictingContainerAppResourceId"u8))
                {
                    conflictingContainerAppResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cNameRecords"u8))
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
                    cNameRecords = array;
                    continue;
                }
                if (property.NameEquals("txtRecords"u8))
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
                    txtRecords = array;
                    continue;
                }
                if (property.NameEquals("aRecords"u8))
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
                    aRecords = array;
                    continue;
                }
                if (property.NameEquals("alternateCNameRecords"u8))
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
                    alternateCNameRecords = array;
                    continue;
                }
                if (property.NameEquals("alternateTxtRecords"u8))
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
                    alternateTxtRecords = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerAppCustomHostnameAnalysisResult(
                hostName,
                isHostnameAlreadyVerified,
                customDomainVerificationTest,
                customDomainVerificationFailureInfo,
                hasConflictOnManagedEnvironment,
                conflictWithEnvironmentCustomDomain,
                conflictingContainerAppResourceId,
                cNameRecords ?? new ChangeTrackingList<string>(),
                txtRecords ?? new ChangeTrackingList<string>(),
                aRecords ?? new ChangeTrackingList<string>(),
                alternateCNameRecords ?? new ChangeTrackingList<string>(),
                alternateTxtRecords ?? new ChangeTrackingList<string>(),
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HostName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  hostName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HostName))
                {
                    builder.Append("  hostName: ");
                    if (HostName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{HostName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{HostName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsHostnameAlreadyVerified), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isHostnameAlreadyVerified: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsHostnameAlreadyVerified))
                {
                    builder.Append("  isHostnameAlreadyVerified: ");
                    var boolValue = IsHostnameAlreadyVerified.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CustomDomainVerificationTest), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  customDomainVerificationTest: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CustomDomainVerificationTest))
                {
                    builder.Append("  customDomainVerificationTest: ");
                    builder.AppendLine($"'{CustomDomainVerificationTest.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CustomDomainVerificationFailureInfo), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  customDomainVerificationFailureInfo: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CustomDomainVerificationFailureInfo))
                {
                    builder.Append("  customDomainVerificationFailureInfo: ");
                    BicepSerializationHelpers.AppendChildObject(builder, CustomDomainVerificationFailureInfo, options, 2, false, "  customDomainVerificationFailureInfo: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HasConflictOnManagedEnvironment), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  hasConflictOnManagedEnvironment: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HasConflictOnManagedEnvironment))
                {
                    builder.Append("  hasConflictOnManagedEnvironment: ");
                    var boolValue = HasConflictOnManagedEnvironment.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConflictWithEnvironmentCustomDomain), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  conflictWithEnvironmentCustomDomain: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConflictWithEnvironmentCustomDomain))
                {
                    builder.Append("  conflictWithEnvironmentCustomDomain: ");
                    var boolValue = ConflictWithEnvironmentCustomDomain.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConflictingContainerAppResourceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  conflictingContainerAppResourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConflictingContainerAppResourceId))
                {
                    builder.Append("  conflictingContainerAppResourceId: ");
                    if (ConflictingContainerAppResourceId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ConflictingContainerAppResourceId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ConflictingContainerAppResourceId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CNameRecords), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  cNameRecords: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(CNameRecords))
                {
                    if (CNameRecords.Any())
                    {
                        builder.Append("  cNameRecords: ");
                        builder.AppendLine("[");
                        foreach (var item in CNameRecords)
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TxtRecords), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  txtRecords: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(TxtRecords))
                {
                    if (TxtRecords.Any())
                    {
                        builder.Append("  txtRecords: ");
                        builder.AppendLine("[");
                        foreach (var item in TxtRecords)
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ARecords), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  aRecords: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ARecords))
                {
                    if (ARecords.Any())
                    {
                        builder.Append("  aRecords: ");
                        builder.AppendLine("[");
                        foreach (var item in ARecords)
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AlternateCNameRecords), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  alternateCNameRecords: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AlternateCNameRecords))
                {
                    if (AlternateCNameRecords.Any())
                    {
                        builder.Append("  alternateCNameRecords: ");
                        builder.AppendLine("[");
                        foreach (var item in AlternateCNameRecords)
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AlternateTxtRecords), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  alternateTxtRecords: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AlternateTxtRecords))
                {
                    if (AlternateTxtRecords.Any())
                    {
                        builder.Append("  alternateTxtRecords: ");
                        builder.AppendLine("[");
                        foreach (var item in AlternateTxtRecords)
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

        BinaryData IPersistableModel<ContainerAppCustomHostnameAnalysisResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppContainersContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppCustomHostnameAnalysisResult)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppCustomHostnameAnalysisResult IPersistableModel<ContainerAppCustomHostnameAnalysisResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerAppCustomHostnameAnalysisResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppCustomHostnameAnalysisResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppCustomHostnameAnalysisResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
