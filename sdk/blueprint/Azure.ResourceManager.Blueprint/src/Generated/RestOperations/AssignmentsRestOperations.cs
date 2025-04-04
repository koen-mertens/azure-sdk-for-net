// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Blueprint.Models;

namespace Azure.ResourceManager.Blueprint
{
    internal partial class AssignmentsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AssignmentsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AssignmentsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2018-11-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string resourceScope, string assignmentName, AssignmentData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Blueprint/blueprintAssignments/", false);
            uri.AppendPath(assignmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceScope, string assignmentName, AssignmentData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Blueprint/blueprintAssignments/", false);
            uri.AppendPath(assignmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create or update a blueprint assignment. </summary>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="assignmentName"> Name of the blueprint assignment. </param>
        /// <param name="data"> Blueprint assignment object to save. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/>, <paramref name="assignmentName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AssignmentData>> CreateOrUpdateAsync(string resourceScope, string assignmentName, AssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));
            Argument.AssertNotNullOrEmpty(assignmentName, nameof(assignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(resourceScope, assignmentName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        AssignmentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = AssignmentData.DeserializeAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create or update a blueprint assignment. </summary>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="assignmentName"> Name of the blueprint assignment. </param>
        /// <param name="data"> Blueprint assignment object to save. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/>, <paramref name="assignmentName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AssignmentData> CreateOrUpdate(string resourceScope, string assignmentName, AssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));
            Argument.AssertNotNullOrEmpty(assignmentName, nameof(assignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(resourceScope, assignmentName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        AssignmentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = AssignmentData.DeserializeAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string resourceScope, string assignmentName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Blueprint/blueprintAssignments/", false);
            uri.AppendPath(assignmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string resourceScope, string assignmentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Blueprint/blueprintAssignments/", false);
            uri.AppendPath(assignmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a blueprint assignment. </summary>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="assignmentName"> Name of the blueprint assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/> or <paramref name="assignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AssignmentData>> GetAsync(string resourceScope, string assignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));
            Argument.AssertNotNullOrEmpty(assignmentName, nameof(assignmentName));

            using var message = CreateGetRequest(resourceScope, assignmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssignmentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = AssignmentData.DeserializeAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AssignmentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a blueprint assignment. </summary>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="assignmentName"> Name of the blueprint assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/> or <paramref name="assignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AssignmentData> Get(string resourceScope, string assignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));
            Argument.AssertNotNullOrEmpty(assignmentName, nameof(assignmentName));

            using var message = CreateGetRequest(resourceScope, assignmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssignmentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = AssignmentData.DeserializeAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AssignmentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string resourceScope, string assignmentName, AssignmentDeleteBehavior? deleteBehavior)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Blueprint/blueprintAssignments/", false);
            uri.AppendPath(assignmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (deleteBehavior != null)
            {
                uri.AppendQuery("deleteBehavior", deleteBehavior.Value.ToString(), true);
            }
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string resourceScope, string assignmentName, AssignmentDeleteBehavior? deleteBehavior)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Blueprint/blueprintAssignments/", false);
            uri.AppendPath(assignmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (deleteBehavior != null)
            {
                uri.AppendQuery("deleteBehavior", deleteBehavior.Value.ToString(), true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a blueprint assignment. </summary>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="assignmentName"> Name of the blueprint assignment. </param>
        /// <param name="deleteBehavior"> When deleteBehavior=all, the resources that were created by the blueprint assignment will be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/> or <paramref name="assignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AssignmentData>> DeleteAsync(string resourceScope, string assignmentName, AssignmentDeleteBehavior? deleteBehavior = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));
            Argument.AssertNotNullOrEmpty(assignmentName, nameof(assignmentName));

            using var message = CreateDeleteRequest(resourceScope, assignmentName, deleteBehavior);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        AssignmentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = AssignmentData.DeserializeAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 204:
                    return Response.FromValue((AssignmentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete a blueprint assignment. </summary>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="assignmentName"> Name of the blueprint assignment. </param>
        /// <param name="deleteBehavior"> When deleteBehavior=all, the resources that were created by the blueprint assignment will be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/> or <paramref name="assignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AssignmentData> Delete(string resourceScope, string assignmentName, AssignmentDeleteBehavior? deleteBehavior = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));
            Argument.AssertNotNullOrEmpty(assignmentName, nameof(assignmentName));

            using var message = CreateDeleteRequest(resourceScope, assignmentName, deleteBehavior);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        AssignmentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = AssignmentData.DeserializeAssignmentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 204:
                    return Response.FromValue((AssignmentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateWhoIsBlueprintRequestUri(string resourceScope, string assignmentName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Blueprint/blueprintAssignments/", false);
            uri.AppendPath(assignmentName, true);
            uri.AppendPath("/whoIsBlueprint", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateWhoIsBlueprintRequest(string resourceScope, string assignmentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Blueprint/blueprintAssignments/", false);
            uri.AppendPath(assignmentName, true);
            uri.AppendPath("/whoIsBlueprint", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get Blueprints service SPN objectId. </summary>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="assignmentName"> Name of the blueprint assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/> or <paramref name="assignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<WhoIsBlueprintContract>> WhoIsBlueprintAsync(string resourceScope, string assignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));
            Argument.AssertNotNullOrEmpty(assignmentName, nameof(assignmentName));

            using var message = CreateWhoIsBlueprintRequest(resourceScope, assignmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WhoIsBlueprintContract value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = WhoIsBlueprintContract.DeserializeWhoIsBlueprintContract(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get Blueprints service SPN objectId. </summary>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="assignmentName"> Name of the blueprint assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/> or <paramref name="assignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<WhoIsBlueprintContract> WhoIsBlueprint(string resourceScope, string assignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));
            Argument.AssertNotNullOrEmpty(assignmentName, nameof(assignmentName));

            using var message = CreateWhoIsBlueprintRequest(resourceScope, assignmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WhoIsBlueprintContract value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = WhoIsBlueprintContract.DeserializeWhoIsBlueprintContract(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListRequestUri(string resourceScope)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Blueprint/blueprintAssignments", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string resourceScope)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Blueprint/blueprintAssignments", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List blueprint assignments within a subscription or a management group. </summary>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/> is null. </exception>
        public async Task<Response<AssignmentList>> ListAsync(string resourceScope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));

            using var message = CreateListRequest(resourceScope);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssignmentList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = AssignmentList.DeserializeAssignmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List blueprint assignments within a subscription or a management group. </summary>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/> is null. </exception>
        public Response<AssignmentList> List(string resourceScope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));

            using var message = CreateListRequest(resourceScope);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssignmentList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = AssignmentList.DeserializeAssignmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string resourceScope)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string resourceScope)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List blueprint assignments within a subscription or a management group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceScope"/> is null. </exception>
        public async Task<Response<AssignmentList>> ListNextPageAsync(string nextLink, string resourceScope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));

            using var message = CreateListNextPageRequest(nextLink, resourceScope);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssignmentList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = AssignmentList.DeserializeAssignmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List blueprint assignments within a subscription or a management group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceScope"/> is null. </exception>
        public Response<AssignmentList> ListNextPage(string nextLink, string resourceScope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));

            using var message = CreateListNextPageRequest(nextLink, resourceScope);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssignmentList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = AssignmentList.DeserializeAssignmentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
