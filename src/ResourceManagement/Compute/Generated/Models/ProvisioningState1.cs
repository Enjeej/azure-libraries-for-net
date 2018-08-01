// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for ProvisioningState1.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<ProvisioningState1>))]
    public class ProvisioningState1 : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<ProvisioningState1>
    {
        public static readonly ProvisioningState1 Creating = Parse("Creating");
        public static readonly ProvisioningState1 Updating = Parse("Updating");
        public static readonly ProvisioningState1 Failed = Parse("Failed");
        public static readonly ProvisioningState1 Succeeded = Parse("Succeeded");
        public static readonly ProvisioningState1 Deleting = Parse("Deleting");
        public static readonly ProvisioningState1 Migrating = Parse("Migrating");
    }
}
