// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Migration.Assessment
{
    internal class MigrationAvsAssessmentOperationSource : IOperationSource<MigrationAvsAssessmentResource>
    {
        private readonly ArmClient _client;

        internal MigrationAvsAssessmentOperationSource(ArmClient client)
        {
            _client = client;
        }

        MigrationAvsAssessmentResource IOperationSource<MigrationAvsAssessmentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<MigrationAvsAssessmentData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerMigrationAssessmentContext.Default);
            return new MigrationAvsAssessmentResource(_client, data);
        }

        async ValueTask<MigrationAvsAssessmentResource> IOperationSource<MigrationAvsAssessmentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<MigrationAvsAssessmentData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerMigrationAssessmentContext.Default);
            return await Task.FromResult(new MigrationAvsAssessmentResource(_client, data)).ConfigureAwait(false);
        }
    }
}
