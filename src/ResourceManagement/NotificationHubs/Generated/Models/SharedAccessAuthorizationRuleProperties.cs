// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.NotificationHubs.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.NotificationHubs;
    using Microsoft.Azure.Management.NotificationHubs.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// SharedAccessAuthorizationRule properties.
    /// </summary>
    public partial class SharedAccessAuthorizationRuleProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleProperties class.
        /// </summary>
        public SharedAccessAuthorizationRuleProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleProperties class.
        /// </summary>
        /// <param name="rights">The rights associated with the rule.</param>
        public SharedAccessAuthorizationRuleProperties(IList<AccessRights?> rights = default(IList<AccessRights?>))
        {
            Rights = rights;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the rights associated with the rule.
        /// </summary>
        [JsonProperty(PropertyName = "rights")]
        public IList<AccessRights?> Rights { get; set; }

    }
}