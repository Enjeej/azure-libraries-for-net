// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DiagnosticSettingsOperations.
    /// </summary>
    public static partial class DiagnosticSettingsOperationsExtensions
    {
        /// <summary>
        /// Gets the active diagnostic settings for the specified resource.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceUri'>
        /// The identifier of the resource.
        /// </param>
        /// <param name='name'>
        /// The name of the diagnostic setting.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<DiagnosticSettingsResourceInner> GetAsync(this IDiagnosticSettingsOperations operations, string resourceUri, string name, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceUri, name, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Creates or updates diagnostic settings for the specified resource.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceUri'>
        /// The identifier of the resource.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the operation.
        /// </param>
        /// <param name='name'>
        /// The name of the diagnostic setting.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<DiagnosticSettingsResourceInner> CreateOrUpdateAsync(this IDiagnosticSettingsOperations operations, string resourceUri, DiagnosticSettingsResourceInner parameters, string name, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceUri, parameters, name, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Deletes existing diagnostic settings for the specified resource.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceUri'>
        /// The identifier of the resource.
        /// </param>
        /// <param name='name'>
        /// The name of the diagnostic setting.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task DeleteAsync(this IDiagnosticSettingsOperations operations, string resourceUri, string name, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(resourceUri, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Gets the active diagnostic settings list for the specified resource.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceUri'>
        /// The identifier of the resource.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<DiagnosticSettingsResourceCollectionInner> ListAsync(this IDiagnosticSettingsOperations operations, string resourceUri, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceUri, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}