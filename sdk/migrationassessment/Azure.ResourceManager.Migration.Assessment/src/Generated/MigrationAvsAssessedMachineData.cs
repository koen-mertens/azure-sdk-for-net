// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Migration.Assessment.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Migration.Assessment
{
    /// <summary>
    /// A class representing the MigrationAvsAssessedMachine data model.
    /// AVS assessment Assessed Machine resource.
    /// </summary>
    public partial class MigrationAvsAssessedMachineData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MigrationAvsAssessedMachineData"/>. </summary>
        public MigrationAvsAssessedMachineData()
        {
            Errors = new ChangeTrackingList<MigrationAssessmentError>();
            Disks = new ChangeTrackingDictionary<string, AvsAssessedDisk>();
            NetworkAdapters = new ChangeTrackingDictionary<string, AvsAssessedNetworkAdapter>();
        }

        /// <summary> Initializes a new instance of <see cref="MigrationAvsAssessedMachineData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="errors"> List of errors for this machine. </param>
        /// <param name="disks"> List of Disks that were assessed as part of this machine's assessment. </param>
        /// <param name="networkAdapters">
        /// List of Network Adapters that were assessed as part of this machine's
        /// assessment.
        /// </param>
        /// <param name="storageInUseGB"> Gets the storage in use. </param>
        /// <param name="suitabilityExplanation"> Gets the explanation if machine is not suitable for cloud. </param>
        /// <param name="suitabilityDetail"> Gets the details if machine is not suitable for cloud. </param>
        /// <param name="typePropertiesType"> Assessed machine type. </param>
        /// <param name="bootType"> Boot type of machine discovered in private data center. </param>
        /// <param name="operatingSystemType"> Operating system as reported by datacenter management solution. </param>
        /// <param name="operatingSystemName"> Operating system as reported by datacenter management solution. </param>
        /// <param name="operatingSystemVersion"> Operating system version as reported by datacenter management solution. </param>
        /// <param name="operatingSystemArchitecture"> Operating system architecture as reported by datacenter management solution. </param>
        /// <param name="createdOn"> When was machine first created. </param>
        /// <param name="updatedOn"> When was machine last updated. </param>
        /// <param name="displayName"> Display Name of the Machine. </param>
        /// <param name="description"> Description for the machine. </param>
        /// <param name="datacenterMachineArmId"> Data center machine ARM id. </param>
        /// <param name="datacenterManagementServerArmId"> Data center management server ARM id. </param>
        /// <param name="datacenterManagementServerName"> Data center management server name. </param>
        /// <param name="megabytesOfMemory"> Megabytes of memory found allocated for the machine in private data center. </param>
        /// <param name="numberOfCores"> Number of CPU cores found on the machine. </param>
        /// <param name="confidenceRatingInPercentage"> Confidence Rating in Percentage. </param>
        /// <param name="percentageCoresUtilization">
        /// Percentile of Percentage of Cores Utilized noted during time period T.
        ///
        ///    Here N and T are settings on Assessment.
        /// </param>
        /// <param name="percentageMemoryUtilization">
        /// Percentile of Percentage of Memory Utilized noted during time period T.
        ///
        ///     Here N and T are settings on Assessment.
        /// </param>
        /// <param name="suitability">
        /// Gets a value indicating whether machine is suitable for the cloud platform
        /// selected.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MigrationAvsAssessedMachineData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IReadOnlyList<MigrationAssessmentError> errors, IReadOnlyDictionary<string, AvsAssessedDisk> disks, IReadOnlyDictionary<string, AvsAssessedNetworkAdapter> networkAdapters, double? storageInUseGB, AvsVmSuitabilityExplanation? suitabilityExplanation, AvsVmSuitabilityDetail? suitabilityDetail, MigrationAssessedMachineType? typePropertiesType, AssessedMachineBootType? bootType, string operatingSystemType, string operatingSystemName, string operatingSystemVersion, GuestOperatingSystemArchitecture? operatingSystemArchitecture, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, string displayName, string description, ResourceIdentifier datacenterMachineArmId, ResourceIdentifier datacenterManagementServerArmId, string datacenterManagementServerName, double? megabytesOfMemory, int? numberOfCores, double? confidenceRatingInPercentage, double? percentageCoresUtilization, double? percentageMemoryUtilization, MigrationAssessmentCloudSuitability? suitability, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Errors = errors;
            Disks = disks;
            NetworkAdapters = networkAdapters;
            StorageInUseGB = storageInUseGB;
            SuitabilityExplanation = suitabilityExplanation;
            SuitabilityDetail = suitabilityDetail;
            TypePropertiesType = typePropertiesType;
            BootType = bootType;
            OperatingSystemType = operatingSystemType;
            OperatingSystemName = operatingSystemName;
            OperatingSystemVersion = operatingSystemVersion;
            OperatingSystemArchitecture = operatingSystemArchitecture;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            DisplayName = displayName;
            Description = description;
            DatacenterMachineArmId = datacenterMachineArmId;
            DatacenterManagementServerArmId = datacenterManagementServerArmId;
            DatacenterManagementServerName = datacenterManagementServerName;
            MegabytesOfMemory = megabytesOfMemory;
            NumberOfCores = numberOfCores;
            ConfidenceRatingInPercentage = confidenceRatingInPercentage;
            PercentageCoresUtilization = percentageCoresUtilization;
            PercentageMemoryUtilization = percentageMemoryUtilization;
            Suitability = suitability;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of errors for this machine. </summary>
        public IReadOnlyList<MigrationAssessmentError> Errors { get; }
        /// <summary> List of Disks that were assessed as part of this machine's assessment. </summary>
        public IReadOnlyDictionary<string, AvsAssessedDisk> Disks { get; }
        /// <summary>
        /// List of Network Adapters that were assessed as part of this machine's
        /// assessment.
        /// </summary>
        public IReadOnlyDictionary<string, AvsAssessedNetworkAdapter> NetworkAdapters { get; }
        /// <summary> Gets the storage in use. </summary>
        public double? StorageInUseGB { get; }
        /// <summary> Gets the explanation if machine is not suitable for cloud. </summary>
        public AvsVmSuitabilityExplanation? SuitabilityExplanation { get; }
        /// <summary> Gets the details if machine is not suitable for cloud. </summary>
        public AvsVmSuitabilityDetail? SuitabilityDetail { get; }
        /// <summary> Assessed machine type. </summary>
        public MigrationAssessedMachineType? TypePropertiesType { get; }
        /// <summary> Boot type of machine discovered in private data center. </summary>
        public AssessedMachineBootType? BootType { get; }
        /// <summary> Operating system as reported by datacenter management solution. </summary>
        public string OperatingSystemType { get; }
        /// <summary> Operating system as reported by datacenter management solution. </summary>
        public string OperatingSystemName { get; }
        /// <summary> Operating system version as reported by datacenter management solution. </summary>
        public string OperatingSystemVersion { get; }
        /// <summary> Operating system architecture as reported by datacenter management solution. </summary>
        public GuestOperatingSystemArchitecture? OperatingSystemArchitecture { get; }
        /// <summary> When was machine first created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> When was machine last updated. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> Display Name of the Machine. </summary>
        public string DisplayName { get; }
        /// <summary> Description for the machine. </summary>
        public string Description { get; }
        /// <summary> Data center machine ARM id. </summary>
        public ResourceIdentifier DatacenterMachineArmId { get; }
        /// <summary> Data center management server ARM id. </summary>
        public ResourceIdentifier DatacenterManagementServerArmId { get; }
        /// <summary> Data center management server name. </summary>
        public string DatacenterManagementServerName { get; }
        /// <summary> Megabytes of memory found allocated for the machine in private data center. </summary>
        public double? MegabytesOfMemory { get; }
        /// <summary> Number of CPU cores found on the machine. </summary>
        public int? NumberOfCores { get; }
        /// <summary> Confidence Rating in Percentage. </summary>
        public double? ConfidenceRatingInPercentage { get; }
        /// <summary>
        /// Percentile of Percentage of Cores Utilized noted during time period T.
        ///
        ///    Here N and T are settings on Assessment.
        /// </summary>
        public double? PercentageCoresUtilization { get; }
        /// <summary>
        /// Percentile of Percentage of Memory Utilized noted during time period T.
        ///
        ///     Here N and T are settings on Assessment.
        /// </summary>
        public double? PercentageMemoryUtilization { get; }
        /// <summary>
        /// Gets a value indicating whether machine is suitable for the cloud platform
        /// selected.
        /// </summary>
        public MigrationAssessmentCloudSuitability? Suitability { get; }
    }
}
