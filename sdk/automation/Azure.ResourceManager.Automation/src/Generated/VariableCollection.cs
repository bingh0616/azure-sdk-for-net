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
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing a collection of <see cref="VariableResource" /> and their operations.
    /// Each <see cref="VariableResource" /> in the collection will belong to the same instance of <see cref="AutomationAccountResource" />.
    /// To get a <see cref="VariableCollection" /> instance call the GetVariables method from an instance of <see cref="AutomationAccountResource" />.
    /// </summary>
    public partial class VariableCollection : ArmCollection, IEnumerable<VariableResource>, IAsyncEnumerable<VariableResource>
    {
        private readonly ClientDiagnostics _variableClientDiagnostics;
        private readonly VariableRestOperations _variableRestClient;

        /// <summary> Initializes a new instance of the <see cref="VariableCollection"/> class for mocking. </summary>
        protected VariableCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VariableCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VariableCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _variableClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", VariableResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VariableResource.ResourceType, out string variableApiVersion);
            _variableRestClient = new VariableRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, variableApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AutomationAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AutomationAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a variable.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/variables/{variableName}
        /// Operation Id: Variable_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="variableName"> The variable name. </param>
        /// <param name="content"> The parameters supplied to the create or update variable operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="variableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="variableName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<VariableResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string variableName, VariableCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(variableName, nameof(variableName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _variableClientDiagnostics.CreateScope("VariableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _variableRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, variableName, content, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation<VariableResource>(Response.FromValue(new VariableResource(Client, response), response.GetRawResponse()));
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
        /// Create a variable.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/variables/{variableName}
        /// Operation Id: Variable_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="variableName"> The variable name. </param>
        /// <param name="content"> The parameters supplied to the create or update variable operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="variableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="variableName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<VariableResource> CreateOrUpdate(WaitUntil waitUntil, string variableName, VariableCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(variableName, nameof(variableName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _variableClientDiagnostics.CreateScope("VariableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _variableRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, variableName, content, cancellationToken);
                var operation = new AutomationArmOperation<VariableResource>(Response.FromValue(new VariableResource(Client, response), response.GetRawResponse()));
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
        /// Retrieve the variable identified by variable name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/variables/{variableName}
        /// Operation Id: Variable_Get
        /// </summary>
        /// <param name="variableName"> The name of variable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="variableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="variableName"/> is null. </exception>
        public virtual async Task<Response<VariableResource>> GetAsync(string variableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(variableName, nameof(variableName));

            using var scope = _variableClientDiagnostics.CreateScope("VariableCollection.Get");
            scope.Start();
            try
            {
                var response = await _variableRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, variableName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VariableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the variable identified by variable name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/variables/{variableName}
        /// Operation Id: Variable_Get
        /// </summary>
        /// <param name="variableName"> The name of variable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="variableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="variableName"/> is null. </exception>
        public virtual Response<VariableResource> Get(string variableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(variableName, nameof(variableName));

            using var scope = _variableClientDiagnostics.CreateScope("VariableCollection.Get");
            scope.Start();
            try
            {
                var response = _variableRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, variableName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VariableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of variables.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/variables
        /// Operation Id: Variable_ListByAutomationAccount
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VariableResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VariableResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VariableResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _variableClientDiagnostics.CreateScope("VariableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _variableRestClient.ListByAutomationAccountAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VariableResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VariableResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _variableClientDiagnostics.CreateScope("VariableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _variableRestClient.ListByAutomationAccountNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VariableResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Retrieve a list of variables.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/variables
        /// Operation Id: Variable_ListByAutomationAccount
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VariableResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VariableResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VariableResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _variableClientDiagnostics.CreateScope("VariableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _variableRestClient.ListByAutomationAccount(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VariableResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VariableResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _variableClientDiagnostics.CreateScope("VariableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _variableRestClient.ListByAutomationAccountNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VariableResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/variables/{variableName}
        /// Operation Id: Variable_Get
        /// </summary>
        /// <param name="variableName"> The name of variable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="variableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="variableName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string variableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(variableName, nameof(variableName));

            using var scope = _variableClientDiagnostics.CreateScope("VariableCollection.Exists");
            scope.Start();
            try
            {
                var response = await _variableRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, variableName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/variables/{variableName}
        /// Operation Id: Variable_Get
        /// </summary>
        /// <param name="variableName"> The name of variable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="variableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="variableName"/> is null. </exception>
        public virtual Response<bool> Exists(string variableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(variableName, nameof(variableName));

            using var scope = _variableClientDiagnostics.CreateScope("VariableCollection.Exists");
            scope.Start();
            try
            {
                var response = _variableRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, variableName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VariableResource> IEnumerable<VariableResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VariableResource> IAsyncEnumerable<VariableResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
