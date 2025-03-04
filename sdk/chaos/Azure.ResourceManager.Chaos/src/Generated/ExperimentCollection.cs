// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Chaos
{
    /// <summary>
    /// A class representing a collection of <see cref="ExperimentResource" /> and their operations.
    /// Each <see cref="ExperimentResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="ExperimentCollection" /> instance call the GetExperiments method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ExperimentCollection : ArmCollection, IEnumerable<ExperimentResource>, IAsyncEnumerable<ExperimentResource>
    {
        private readonly ClientDiagnostics _experimentClientDiagnostics;
        private readonly ExperimentsRestOperations _experimentRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExperimentCollection"/> class for mocking. </summary>
        protected ExperimentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExperimentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExperimentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _experimentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Chaos", ExperimentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExperimentResource.ResourceType, out string experimentApiVersion);
            _experimentRestClient = new ExperimentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, experimentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Experiment resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}
        /// Operation Id: Experiments_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="experimentName"> String that represents a Experiment resource name. </param>
        /// <param name="data"> Experiment resource to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ExperimentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string experimentName, ExperimentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(experimentName, nameof(experimentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _experimentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, experimentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ChaosArmOperation<ExperimentResource>(Response.FromValue(new ExperimentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a Experiment resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}
        /// Operation Id: Experiments_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="experimentName"> String that represents a Experiment resource name. </param>
        /// <param name="data"> Experiment resource to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ExperimentResource> CreateOrUpdate(WaitUntil waitUntil, string experimentName, ExperimentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(experimentName, nameof(experimentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _experimentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, experimentName, data, cancellationToken);
                var operation = new ChaosArmOperation<ExperimentResource>(Response.FromValue(new ExperimentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Experiment resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}
        /// Operation Id: Experiments_Get
        /// </summary>
        /// <param name="experimentName"> String that represents a Experiment resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        public virtual async Task<Response<ExperimentResource>> GetAsync(string experimentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(experimentName, nameof(experimentName));

            using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.Get");
            scope.Start();
            try
            {
                var response = await _experimentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, experimentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExperimentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Experiment resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}
        /// Operation Id: Experiments_Get
        /// </summary>
        /// <param name="experimentName"> String that represents a Experiment resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        public virtual Response<ExperimentResource> Get(string experimentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(experimentName, nameof(experimentName));

            using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.Get");
            scope.Start();
            try
            {
                var response = _experimentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, experimentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExperimentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of Experiment resources in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments
        /// Operation Id: Experiments_List
        /// </summary>
        /// <param name="running"> Optional value that indicates whether to filter results based on if the Experiment is currently running. If null, then the results will not be filtered. </param>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExperimentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExperimentResource> GetAllAsync(bool? running = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ExperimentResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _experimentRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, running, continuationToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExperimentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExperimentResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _experimentRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, running, continuationToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExperimentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Get a list of Experiment resources in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments
        /// Operation Id: Experiments_List
        /// </summary>
        /// <param name="running"> Optional value that indicates whether to filter results based on if the Experiment is currently running. If null, then the results will not be filtered. </param>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExperimentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExperimentResource> GetAll(bool? running = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            Page<ExperimentResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _experimentRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, running, continuationToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExperimentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExperimentResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _experimentRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, running, continuationToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExperimentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}
        /// Operation Id: Experiments_Get
        /// </summary>
        /// <param name="experimentName"> String that represents a Experiment resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string experimentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(experimentName, nameof(experimentName));

            using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _experimentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, experimentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}
        /// Operation Id: Experiments_Get
        /// </summary>
        /// <param name="experimentName"> String that represents a Experiment resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="experimentName"/> is null. </exception>
        public virtual Response<bool> Exists(string experimentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(experimentName, nameof(experimentName));

            using var scope = _experimentClientDiagnostics.CreateScope("ExperimentCollection.Exists");
            scope.Start();
            try
            {
                var response = _experimentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, experimentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExperimentResource> IEnumerable<ExperimentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExperimentResource> IAsyncEnumerable<ExperimentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
