// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// App Service error response.
    /// </summary>
    public partial class DefaultErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the DefaultErrorResponse class.
        /// </summary>
        public DefaultErrorResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DefaultErrorResponse class.
        /// </summary>
        /// <param name="error">Error model.</param>
        public DefaultErrorResponse(DefaultErrorResponseError error = default(DefaultErrorResponseError))
        {
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets error model.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public DefaultErrorResponseError Error { get; private set; }

    }
}
