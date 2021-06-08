// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.EdgeOrderPartner.Models;

namespace Azure.ResourceManager.EdgeOrderPartner
{
    internal partial class EdgeOrderPartnerManagementRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of EdgeOrderPartnerManagementRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public EdgeOrderPartnerManagementRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2020-12-01-preview")
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListOperationsPartnerRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/providers/Microsoft.EdgeOrderPartner/operations", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> This method gets all the operations that are exposed for customer. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<OperationListResult>> ListOperationsPartnerAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListOperationsPartnerRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OperationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = OperationListResult.DeserializeOperationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> This method gets all the operations that are exposed for customer. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<OperationListResult> ListOperationsPartner(CancellationToken cancellationToken = default)
        {
            using var message = CreateListOperationsPartnerRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OperationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = OperationListResult.DeserializeOperationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateManageInventoryMetadataRequest(string familyIdentifier, string location, string serialNumber, ManageInventoryMetadataRequest manageInventoryMetadataRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.EdgeOrderPartner/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/productFamilies/", false);
            uri.AppendPath(familyIdentifier, true);
            uri.AppendPath("/inventories/", false);
            uri.AppendPath(serialNumber, true);
            uri.AppendPath("/manageInventoryMetadata", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(manageInventoryMetadataRequest);
            request.Content = content;
            return message;
        }

        /// <summary> API for updating inventory metadata and inventory configuration. </summary>
        /// <param name="familyIdentifier"> Unique identifier for the product family. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="serialNumber"> The serial number of the device. </param>
        /// <param name="manageInventoryMetadataRequest"> Updates inventory metadata and inventory configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="familyIdentifier"/>, <paramref name="location"/>, <paramref name="serialNumber"/>, or <paramref name="manageInventoryMetadataRequest"/> is null. </exception>
        public async Task<Response> ManageInventoryMetadataAsync(string familyIdentifier, string location, string serialNumber, ManageInventoryMetadataRequest manageInventoryMetadataRequest, CancellationToken cancellationToken = default)
        {
            if (familyIdentifier == null)
            {
                throw new ArgumentNullException(nameof(familyIdentifier));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (serialNumber == null)
            {
                throw new ArgumentNullException(nameof(serialNumber));
            }
            if (manageInventoryMetadataRequest == null)
            {
                throw new ArgumentNullException(nameof(manageInventoryMetadataRequest));
            }

            using var message = CreateManageInventoryMetadataRequest(familyIdentifier, location, serialNumber, manageInventoryMetadataRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> API for updating inventory metadata and inventory configuration. </summary>
        /// <param name="familyIdentifier"> Unique identifier for the product family. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="serialNumber"> The serial number of the device. </param>
        /// <param name="manageInventoryMetadataRequest"> Updates inventory metadata and inventory configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="familyIdentifier"/>, <paramref name="location"/>, <paramref name="serialNumber"/>, or <paramref name="manageInventoryMetadataRequest"/> is null. </exception>
        public Response ManageInventoryMetadata(string familyIdentifier, string location, string serialNumber, ManageInventoryMetadataRequest manageInventoryMetadataRequest, CancellationToken cancellationToken = default)
        {
            if (familyIdentifier == null)
            {
                throw new ArgumentNullException(nameof(familyIdentifier));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (serialNumber == null)
            {
                throw new ArgumentNullException(nameof(serialNumber));
            }
            if (manageInventoryMetadataRequest == null)
            {
                throw new ArgumentNullException(nameof(manageInventoryMetadataRequest));
            }

            using var message = CreateManageInventoryMetadataRequest(familyIdentifier, location, serialNumber, manageInventoryMetadataRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateManageLinkRequest(string familyIdentifier, string location, string serialNumber, ManageLinkRequest manageLinkRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.EdgeOrderPartner/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/productFamilies/", false);
            uri.AppendPath(familyIdentifier, true);
            uri.AppendPath("/inventories/", false);
            uri.AppendPath(serialNumber, true);
            uri.AppendPath("/manageLink", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(manageLinkRequest);
            request.Content = content;
            return message;
        }

        /// <summary> API for linking management resource with inventory. </summary>
        /// <param name="familyIdentifier"> Unique identifier for the product family. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="serialNumber"> The serial number of the device. </param>
        /// <param name="manageLinkRequest"> Links the management resource to the inventory. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="familyIdentifier"/>, <paramref name="location"/>, <paramref name="serialNumber"/>, or <paramref name="manageLinkRequest"/> is null. </exception>
        public async Task<Response> ManageLinkAsync(string familyIdentifier, string location, string serialNumber, ManageLinkRequest manageLinkRequest, CancellationToken cancellationToken = default)
        {
            if (familyIdentifier == null)
            {
                throw new ArgumentNullException(nameof(familyIdentifier));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (serialNumber == null)
            {
                throw new ArgumentNullException(nameof(serialNumber));
            }
            if (manageLinkRequest == null)
            {
                throw new ArgumentNullException(nameof(manageLinkRequest));
            }

            using var message = CreateManageLinkRequest(familyIdentifier, location, serialNumber, manageLinkRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> API for linking management resource with inventory. </summary>
        /// <param name="familyIdentifier"> Unique identifier for the product family. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="serialNumber"> The serial number of the device. </param>
        /// <param name="manageLinkRequest"> Links the management resource to the inventory. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="familyIdentifier"/>, <paramref name="location"/>, <paramref name="serialNumber"/>, or <paramref name="manageLinkRequest"/> is null. </exception>
        public Response ManageLink(string familyIdentifier, string location, string serialNumber, ManageLinkRequest manageLinkRequest, CancellationToken cancellationToken = default)
        {
            if (familyIdentifier == null)
            {
                throw new ArgumentNullException(nameof(familyIdentifier));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (serialNumber == null)
            {
                throw new ArgumentNullException(nameof(serialNumber));
            }
            if (manageLinkRequest == null)
            {
                throw new ArgumentNullException(nameof(manageLinkRequest));
            }

            using var message = CreateManageLinkRequest(familyIdentifier, location, serialNumber, manageLinkRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateSearchInventoriesRequest(SearchInventoriesRequest searchInventoriesRequest, string expand, string skipToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.EdgeOrderPartner/searchInventories", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(searchInventoriesRequest);
            request.Content = content;
            return message;
        }

        /// <summary> API for Search inventories. </summary>
        /// <param name="searchInventoriesRequest"> Searches inventories with the given filters and returns in the form of a list. </param>
        /// <param name="expand"> $expand is supported on details of inventory. </param>
        /// <param name="skipToken"> $skipToken is supported on list partner inventories, which provides the next page in the list of partner inventories. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="searchInventoriesRequest"/> is null. </exception>
        public async Task<Response<PartnerInventoryList>> SearchInventoriesAsync(SearchInventoriesRequest searchInventoriesRequest, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            if (searchInventoriesRequest == null)
            {
                throw new ArgumentNullException(nameof(searchInventoriesRequest));
            }

            using var message = CreateSearchInventoriesRequest(searchInventoriesRequest, expand, skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PartnerInventoryList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PartnerInventoryList.DeserializePartnerInventoryList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> API for Search inventories. </summary>
        /// <param name="searchInventoriesRequest"> Searches inventories with the given filters and returns in the form of a list. </param>
        /// <param name="expand"> $expand is supported on details of inventory. </param>
        /// <param name="skipToken"> $skipToken is supported on list partner inventories, which provides the next page in the list of partner inventories. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="searchInventoriesRequest"/> is null. </exception>
        public Response<PartnerInventoryList> SearchInventories(SearchInventoriesRequest searchInventoriesRequest, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            if (searchInventoriesRequest == null)
            {
                throw new ArgumentNullException(nameof(searchInventoriesRequest));
            }

            using var message = CreateSearchInventoriesRequest(searchInventoriesRequest, expand, skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PartnerInventoryList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PartnerInventoryList.DeserializePartnerInventoryList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListOperationsPartnerNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> This method gets all the operations that are exposed for customer. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<OperationListResult>> ListOperationsPartnerNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListOperationsPartnerNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OperationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = OperationListResult.DeserializeOperationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> This method gets all the operations that are exposed for customer. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<OperationListResult> ListOperationsPartnerNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListOperationsPartnerNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OperationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = OperationListResult.DeserializeOperationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateSearchInventoriesNextPageRequest(string nextLink, SearchInventoriesRequest searchInventoriesRequest, string expand, string skipToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> API for Search inventories. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="searchInventoriesRequest"> Searches inventories with the given filters and returns in the form of a list. </param>
        /// <param name="expand"> $expand is supported on details of inventory. </param>
        /// <param name="skipToken"> $skipToken is supported on list partner inventories, which provides the next page in the list of partner inventories. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="searchInventoriesRequest"/> is null. </exception>
        public async Task<Response<PartnerInventoryList>> SearchInventoriesNextPageAsync(string nextLink, SearchInventoriesRequest searchInventoriesRequest, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (searchInventoriesRequest == null)
            {
                throw new ArgumentNullException(nameof(searchInventoriesRequest));
            }

            using var message = CreateSearchInventoriesNextPageRequest(nextLink, searchInventoriesRequest, expand, skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PartnerInventoryList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PartnerInventoryList.DeserializePartnerInventoryList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> API for Search inventories. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="searchInventoriesRequest"> Searches inventories with the given filters and returns in the form of a list. </param>
        /// <param name="expand"> $expand is supported on details of inventory. </param>
        /// <param name="skipToken"> $skipToken is supported on list partner inventories, which provides the next page in the list of partner inventories. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="searchInventoriesRequest"/> is null. </exception>
        public Response<PartnerInventoryList> SearchInventoriesNextPage(string nextLink, SearchInventoriesRequest searchInventoriesRequest, string expand = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (searchInventoriesRequest == null)
            {
                throw new ArgumentNullException(nameof(searchInventoriesRequest));
            }

            using var message = CreateSearchInventoriesNextPageRequest(nextLink, searchInventoriesRequest, expand, skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PartnerInventoryList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PartnerInventoryList.DeserializePartnerInventoryList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
