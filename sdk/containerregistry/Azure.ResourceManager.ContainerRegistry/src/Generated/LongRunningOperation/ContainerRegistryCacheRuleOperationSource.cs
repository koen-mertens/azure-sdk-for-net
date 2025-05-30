// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry
{
    internal class ContainerRegistryCacheRuleOperationSource : IOperationSource<ContainerRegistryCacheRuleResource>
    {
        private readonly ArmClient _client;

        internal ContainerRegistryCacheRuleOperationSource(ArmClient client)
        {
            _client = client;
        }

        ContainerRegistryCacheRuleResource IOperationSource<ContainerRegistryCacheRuleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ContainerRegistryCacheRuleData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerContainerRegistryContext.Default);
            return new ContainerRegistryCacheRuleResource(_client, data);
        }

        async ValueTask<ContainerRegistryCacheRuleResource> IOperationSource<ContainerRegistryCacheRuleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ContainerRegistryCacheRuleData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerContainerRegistryContext.Default);
            return await Task.FromResult(new ContainerRegistryCacheRuleResource(_client, data)).ConfigureAwait(false);
        }
    }
}
